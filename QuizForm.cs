using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using SmartEduAssistant.Models;

namespace SmartEduAssistant
{
    public class QuizForm : Form
    {
        private readonly QuizResponse _response;
        private readonly bool _isMultipleChoice;
        private readonly List<(QuizQuestion question, Control answerControl)> _map = new();
        private readonly FlowLayoutPanel _flow;
        private readonly Label _progressLabel;

        public QuizForm(QuizResponse response, bool isMultipleChoice)
        {
            _response = response ?? throw new ArgumentNullException(nameof(response));
            _isMultipleChoice = isMultipleChoice;

            // Form styling
            Text = "اختبار الأسئلة";
            Width = 1000;
            Height = 750;
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.FromArgb(245, 245, 250);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            // Create header panel
            var headerPanel = new Panel
            {
                Height = 80,
                Dock = DockStyle.Top,
                // here we have to change the color
                BackColor = Color.FromArgb(37, 62, 63)
            };

            var titleLabel = new Label
            {
                Text = _isMultipleChoice ? " اختيارات " : " صح أو خطأ",
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.White,
                Dock = DockStyle.Left,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(20, 0, 0, 0)
            };

            _progressLabel = new Label
            {
                Text = $"عدد الأسئلة: {_response.Questions.Count}",
                Font = new Font("Segoe UI", 11F, FontStyle.Regular),
                ForeColor = Color.White,
                Dock = DockStyle.Right,
                TextAlign = ContentAlignment.MiddleRight,
                Padding = new Padding(0, 0, 20, 0)
            };

            headerPanel.Controls.Add(titleLabel);
            headerPanel.Controls.Add(_progressLabel);

            // Create main scrollable content panel
            _flow = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                BackColor = Color.FromArgb(245, 245, 250),
                Padding = new Padding(20)
            };

            // Create footer panel with submit button
            var footerPanel = new Panel
            {
                Height = 80,
                Dock = DockStyle.Bottom,
                BackColor = Color.FromArgb(240, 240, 240),
                Padding = new Padding(20)
            };

            var submit = new Button
            {
                Text = "تسليم الإجابات",
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                BackColor = Color.FromArgb(46, 204, 113),
                ForeColor = Color.White,
                Dock = DockStyle.Right,
                Width = 200,
                Height = 45,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            submit.FlatAppearance.BorderSize = 0;
            submit.Click += Submit_Click;
            submit.MouseEnter += (s, e) => submit.BackColor = Color.FromArgb(39, 174, 96);
            submit.MouseLeave += (s, e) => submit.BackColor = Color.FromArgb(46, 204, 113);

            footerPanel.Controls.Add(submit);

            Controls.Add(_flow);
            Controls.Add(footerPanel);
            Controls.Add(headerPanel);

            BuildQuestions();
        }

        private void BuildQuestions()
        {
            int idx = 1;
            foreach (var q in _response.Questions)
            {
                var gb = new GroupBox
                {
                    Text = "",
                    Width = 920,
                    AutoSize = false,
                    BackColor = Color.White,
                    ForeColor = Color.FromArgb(50, 50, 50),
                    Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                    Padding = new Padding(15, 15, 15, 15),
                    Margin = new Padding(0, 0, 0, 15),
                    RightToLeft = RightToLeft.Yes
                };

                // Add question text label at the top
                var questionLabel = new Label
                {
                    Text = $"السؤال {idx}: {q.QuestionText}",
                    Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(41, 128, 185),
                    AutoSize = false,
                    Width = 880,
                    Height = 50,
                    Location = new Point(10, 15),
                    RightToLeft = RightToLeft.Yes,
                    TextAlign = ContentAlignment.TopRight
                };
                gb.Controls.Add(questionLabel);

                // Add a subtle border effect
                gb.Paint += (s, e) =>
                {
                    e.Graphics.DrawRectangle(new Pen(Color.FromArgb(200, 200, 200)), 0, 0, gb.Width - 1, gb.Height - 1);
                };

                if (_isMultipleChoice && q.Options != null && q.Options.Count > 0)
                {
                    int optionHeight = (q.Options.Count * 50) + 20; // Increased height per option
                    gb.Height = optionHeight + 80;

                    var optionsPanel = new Panel
                    {
                        Width = 880,
                        Height = optionHeight,
                        BackColor = Color.White,
                        Margin = new Padding(5),
                        Location = new Point(10, 70)
                    };

                    int y = 10;
                    int optionNum = 1;
                    foreach (var opt in q.Options)
                    {
                        var rb = new RadioButton
                        {
                            Text = opt, // Remove extra spacing, let the button handle alignment
                            AutoSize = false,
                            Width = 860,
                            Height = 45, // Increased from 30 to 45
                            Location = new Point(10, y),
                            Font = new Font("Segoe UI", 11F, FontStyle.Regular), // Increased from 10 to 11
                            ForeColor = Color.FromArgb(50, 50, 50),
                            RightToLeft = RightToLeft.No,
                            Appearance = Appearance.Button,
                            FlatStyle = FlatStyle.Flat,
                            BackColor = Color.FromArgb(240, 240, 245),
                            TextAlign = ContentAlignment.MiddleLeft, // Align text to left
                            Padding = new Padding(15, 5, 15, 5) // Add padding for better text visibility
                        };

                        // Store the original option text for comparison
                        rb.Tag = opt;

                        // Style for checked/unchecked states
                        rb.CheckedChanged += (s, e) =>
                        {
                            if (rb.Checked)
                            {
                                rb.BackColor = Color.FromArgb(41, 128, 185);
                                rb.ForeColor = Color.White;
                            }
                            else
                            {
                                rb.BackColor = Color.FromArgb(240, 240, 245);
                                rb.ForeColor = Color.FromArgb(50, 50, 50);
                            }
                        };

                        optionsPanel.Controls.Add(rb);
                        y += 50; // Increased spacing between options
                        optionNum++;
                    }

                    gb.Controls.Add(optionsPanel);
                    _map.Add((q, optionsPanel));
                }
                else
                {
                    // True/False with better styling
                    gb.Height = 150;

                    var container = new Panel
                    {
                        Width = 880,
                        Height = 60,
                        BackColor = Color.White,
                        Margin = new Padding(5),
                        Location = new Point(10, 70)
                    };

                    var rbTrue = new RadioButton
                    {
                        Text = "✓ صح",
                        AutoSize = false,
                        Width = 200,
                        Height = 50,
                        Location = new Point(450, 5),
                        Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                        ForeColor = Color.FromArgb(50, 50, 50),
                        Appearance = Appearance.Button,
                        FlatStyle = FlatStyle.Flat,
                        BackColor = Color.FromArgb(240, 240, 245)
                    };

                    var rbFalse = new RadioButton
                    {
                        Text = "✗ خطأ",
                        AutoSize = false,
                        Width = 200,
                        Height = 50,
                        Location = new Point(10, 5),
                        Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                        ForeColor = Color.FromArgb(50, 50, 50),
                        Appearance = Appearance.Button,
                        FlatStyle = FlatStyle.Flat,
                        BackColor = Color.FromArgb(240, 240, 245)
                    };

                    rbTrue.CheckedChanged += (s, e) =>
                    {
                        if (rbTrue.Checked)
                        {
                            rbTrue.BackColor = Color.FromArgb(46, 204, 113);
                            rbTrue.ForeColor = Color.White;
                            rbFalse.BackColor = Color.FromArgb(240, 240, 245);
                            rbFalse.ForeColor = Color.FromArgb(50, 50, 50);
                        }
                    };

                    rbFalse.CheckedChanged += (s, e) =>
                    {
                        if (rbFalse.Checked)
                        {
                            rbFalse.BackColor = Color.FromArgb(231, 76, 60);
                            rbFalse.ForeColor = Color.White;
                            rbTrue.BackColor = Color.FromArgb(240, 240, 245);
                            rbTrue.ForeColor = Color.FromArgb(50, 50, 50);
                        }
                    };

                    container.Controls.Add(rbTrue);
                    container.Controls.Add(rbFalse);
                    gb.Controls.Add(container);
                    _map.Add((q, container));
                }

                _flow.Controls.Add(gb);
                idx++;
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            int correct = 0;
            int total = _map.Count;
            var debugInfo = new List<string>();
            var wrongAnswers = new List<(int QuestionNum, string QuestionText, string UserAnswer, string CorrectAnswer)>();

            int questionNum = 1;
            foreach (var entry in _map)
            {
                var q = entry.question;
                var ctrl = entry.answerControl;

                if (_isMultipleChoice)
                {
                    // container with radio buttons
                    var selected = ctrl.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                    string userAnswer = "لم يتم الإجابة";

                    if (selected != null)
                    {
                        // Use the Tag which stores the original option text
                        userAnswer = selected.Tag?.ToString() ?? selected.Text?.Trim() ?? "لم يتم الإجابة";
                    }

                    var correctAns = q.CorrectAnswerString?.Trim();

                    debugInfo.Add($"Question: {q.QuestionText}");
                    debugInfo.Add($"  Selected: '{userAnswer}'");
                    debugInfo.Add($"  Correct: '{correctAns}'");

                    if (!string.IsNullOrEmpty(correctAns) && string.Equals(userAnswer, correctAns, StringComparison.OrdinalIgnoreCase))
                    {
                        correct++;
                        debugInfo.Add($"  Result: ✓ CORRECT");
                    }
                    else
                    {
                        debugInfo.Add($"  Result: ✗ WRONG");
                        wrongAnswers.Add((questionNum, q.QuestionText, userAnswer, correctAns ?? "Unknown"));
                    }
                }
                else
                {
                    var rbTrue = ctrl.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Text.Contains("صح"));
                    var rbFalse = ctrl.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Text.Contains("خطأ"));
                    bool? selectedBool = null;
                    if (rbTrue != null && rbTrue.Checked) selectedBool = true;
                    if (rbFalse != null && rbFalse.Checked) selectedBool = false;

                    string userAnswer = selectedBool.HasValue ? (selectedBool.Value ? "صح (True)" : "خطأ (False)") : "لم يتم الإجابة";
                    string correctAnswer = q.CorrectAnswerBool.HasValue ? (q.CorrectAnswerBool.Value ? "صح (True)" : "خطأ (False)") : "Unknown";

                    debugInfo.Add($"Question: {q.QuestionText}");
                    debugInfo.Add($"  Selected: {userAnswer}");
                    debugInfo.Add($"  Correct: {correctAnswer}");

                    if (selectedBool.HasValue && q.CorrectAnswerBool.HasValue)
                    {
                        if (selectedBool.Value == q.CorrectAnswerBool.Value)
                        {
                            correct++;
                            debugInfo.Add($"  Result: ✓ CORRECT");
                        }
                        else
                        {
                            debugInfo.Add($"  Result: ✗ WRONG");
                            wrongAnswers.Add((questionNum, q.QuestionText, userAnswer, correctAnswer));
                        }
                    }
                    else
                    {
                        debugInfo.Add($"  Result: ⊘ NOT ANSWERED");
                        wrongAnswers.Add((questionNum, q.QuestionText, userAnswer, correctAnswer));
                    }
                }

                questionNum++;
            }

            // Log debug info to console
            Console.WriteLine("\n=== QUIZ GRADING DEBUG INFO ===");
            foreach (var line in debugInfo)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine($"\nFinal Score: {correct}/{total}\n");

            // Show beautiful results dialog with wrong answers
            ShowResultsDialog(correct, total, wrongAnswers);
            Close();
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // QuizForm
            // 
            ClientSize = new Size(432, 307);
            Name = "QuizForm";
            ResumeLayout(false);

        }

        private void ShowResultsDialog(int correct, int total, List<(int QuestionNum, string QuestionText, string UserAnswer, string CorrectAnswer)> wrongAnswers)
        {
            var resultForm = new Form
            {
                Text = "نتائج الاختبار",
                Width = 900,
                Height = 700,
                StartPosition = FormStartPosition.CenterScreen,
                BackColor = Color.FromArgb(245, 245, 250),
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                Icon = null
            };

            // Header panel
            var headerPanel = new Panel
            {
                Height = 80,
                Dock = DockStyle.Top,
                BackColor = Color.FromArgb(41, 128, 185)
            };

            var resultTitle = new Label
            {
                Text = "تم تسليم الإجابات",
                Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                ForeColor = Color.White,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            headerPanel.Controls.Add(resultTitle);

            // Content panel with scrolling
            var mainPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(245, 245, 250)
            };

            // Score summary panel
            var summaryPanel = new Panel
            {
                Height = 140,
                Dock = DockStyle.Top,
                BackColor = Color.White,
                Padding = new Padding(20)
            };

            double percentage = (double)correct / total * 100;

            var scoreLabel = new Label
            {
                Text = $"درجتك: {correct}/{total}",
                Font = new Font("Segoe UI", 24F, FontStyle.Bold),
                ForeColor = Color.FromArgb(41, 128, 185),
                AutoSize = true,
                Location = new Point(20, 10)
            };

            var percentLabel = new Label
            {
                Text = $"النسبة المئوية: {percentage:F1}%",
                Font = new Font("Segoe UI", 13F, FontStyle.Regular),
                ForeColor = Color.FromArgb(100, 100, 100),
                AutoSize = true,
                Location = new Point(20, 50)
            };

            string message = percentage >= 80 ? "ممتاز! 🎉" :
                           percentage >= 60 ? "جيد 👍" :
                           percentage >= 40 ? "مقبول" : "يحتاج لمزيد من المراجعة";

            Color msgColor = percentage >= 80 ? Color.FromArgb(46, 204, 113) :
                           percentage >= 60 ? Color.FromArgb(52, 152, 219) :
                           percentage >= 40 ? Color.FromArgb(241, 196, 15) : Color.FromArgb(231, 76, 60);

            var messageLabel = new Label
            {
                Text = message,
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = msgColor,
                AutoSize = true,
                Location = new Point(20, 90)
            };

            summaryPanel.Controls.Add(scoreLabel);
            summaryPanel.Controls.Add(percentLabel);
            summaryPanel.Controls.Add(messageLabel);

            // Wrong answers panel with scroll using FlowLayoutPanel for better layout
            var wrongAnswersPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(245, 245, 250),
                Padding = new Padding(20, 20, 20, 100), // Added bottom padding for close button space
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false
            };

            if (wrongAnswers.Count > 0)
            {
                var titleWrong = new Label
                {
                    Text = $"الأسئلة التي لم يتم الإجابة عليها بشكل صحيح ({wrongAnswers.Count}):",
                    Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(231, 76, 60),
                    AutoSize = false,
                    Width = 820,
                    Height = 40,
                    Margin = new Padding(0, 0, 0, 15)
                };
                wrongAnswersPanel.Controls.Add(titleWrong);

                int cardIndex = 0;
                foreach (var wrong in wrongAnswers)
                {
                    cardIndex++;

                    // Calculate dynamic height based on text length
                    int questionTextLines = (int)Math.Ceiling(wrong.QuestionText.Length / 80.0);
                    int questionHeight = Math.Max(40, questionTextLines * 22);
                    int cardHeight = questionHeight + 100;

                    var wrongCard = new Panel
                    {
                        Width = 820,
                        Height = cardHeight,
                        BackColor = Color.White,
                        Margin = new Padding(0, 0, 0, 15),
                        Padding = new Padding(20)
                    };

                    // Add border with graphics
                    wrongCard.Paint += (s, e) =>
                    {
                        var borderColor = Color.FromArgb(200, 200, 200);
                        e.Graphics.DrawRectangle(new Pen(borderColor, 2), 0, 0, wrongCard.Width - 1, wrongCard.Height - 1);
                    };

                    // Question number label
                    var qNumLabel = new Label
                    {
                        Text = $"السؤال {wrong.QuestionNum}",
                        Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                        ForeColor = Color.FromArgb(41, 128, 185),
                        AutoSize = false,
                        Width = 780,
                        Height = 28,
                        Location = new Point(0, 0),
                        TextAlign = ContentAlignment.MiddleLeft,
                        Padding = new Padding(5, 0, 0, 0)
                    };

                    // Question text label with word wrapping
                    var qTextLabel = new Label
                    {
                        Text = wrong.QuestionText,
                        Font = new Font("Segoe UI", 11F, FontStyle.Regular),
                        ForeColor = Color.FromArgb(60, 60, 60),
                        AutoSize = false,
                        Width = 780,
                        Height = questionHeight,
                        Location = new Point(0, 30),
                        TextAlign = ContentAlignment.TopLeft,
                        Padding = new Padding(5, 5, 5, 5)
                    };
                    qTextLabel.AutoSize = false;

                    // User answer label
                    var userLabel = new Label
                    {
                        Text = $"✗ إجابتك: {wrong.UserAnswer}",
                        Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                        ForeColor = Color.FromArgb(220, 53, 69),
                        AutoSize = false,
                        Width = 780,
                        Height = 28,
                        Location = new Point(0, 30 + questionHeight + 5),
                        TextAlign = ContentAlignment.MiddleLeft,
                        Padding = new Padding(10, 0, 0, 0),
                        BackColor = Color.FromArgb(255, 242, 242)
                    };

                    // Correct answer label
                    var correctLabel = new Label
                    {
                        Text = $"✓ الإجابة الصحيحة: {wrong.CorrectAnswer}",
                        Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                        ForeColor = Color.FromArgb(40, 167, 69),
                        AutoSize = false,
                        Width = 780,
                        Height = 28,
                        Location = new Point(0, 30 + questionHeight + 35),
                        TextAlign = ContentAlignment.MiddleLeft,
                        Padding = new Padding(10, 0, 0, 0),
                        BackColor = Color.FromArgb(242, 249, 245)
                    };

                    wrongCard.Controls.Add(qNumLabel);
                    wrongCard.Controls.Add(qTextLabel);
                    wrongCard.Controls.Add(userLabel);
                    wrongCard.Controls.Add(correctLabel);

                    wrongAnswersPanel.Controls.Add(wrongCard);
                }
            }
            else
            {
                var perfectLabel = new Label
                {
                    Text = "🎊 تهانينا! لقد أجبت على جميع الأسئلة بشكل صحيح!",
                    Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(46, 204, 113),
                    AutoSize = false,
                    Width = 820,
                    Height = 80,
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.White,
                    Margin = new Padding(0, 20, 0, 0)
                };
                wrongAnswersPanel.Controls.Add(perfectLabel);
            }

            mainPanel.Controls.Add(wrongAnswersPanel);
            mainPanel.Controls.Add(summaryPanel);

            resultForm.Controls.Add(mainPanel);
            resultForm.Controls.Add(headerPanel);

            resultForm.ShowDialog();
        }
    }
}
