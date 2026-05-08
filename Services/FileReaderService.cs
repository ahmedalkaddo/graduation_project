using System.IO;
using System.Threading.Tasks;
using System.Text;

namespace SmartEduAssistant.Services
{
    public class FileReaderService
    {
        public async Task<string> ReadFileAsync(string path)
        {
            var ext = Path.GetExtension(path)?.ToLowerInvariant();
            if (ext == ".txt")
            {
                return await File.ReadAllTextAsync(path).ConfigureAwait(false);
            }

            if (ext == ".pdf")
            {
                // use iTextSharp (already referenced in project) to extract text
                return await Task.Run(() =>
                {
                    try
                    {
                        var sb = new StringBuilder();
                        using (var reader = new iTextSharp.text.pdf.PdfReader(path))
                        {
                            int pages = reader.NumberOfPages;
                            for (int i = 1; i <= pages; i++)
                            {
                                var t = iTextSharp.text.pdf.parser.PdfTextExtractor.GetTextFromPage(reader, i);
                                if (!string.IsNullOrEmpty(t))
                                {
                                    sb.AppendLine(t);
                                }
                            }
                        }

                        return sb.ToString();
                    }
                    catch (System.Exception ex)
                    {
                        throw new System.InvalidOperationException("Failed to read PDF: " + ex.Message, ex);
                    }
                }).ConfigureAwait(false);
            }

            // Docx and other formats are not implemented to avoid extra dependencies
            if (ext == ".docx")
            {
                throw new System.NotSupportedException(".docx reading is not supported in this build. Please use .txt or .pdf files or manual input.");
            }

            throw new System.NotSupportedException($"File type '{ext}' is not supported.");
        }
    }
}
