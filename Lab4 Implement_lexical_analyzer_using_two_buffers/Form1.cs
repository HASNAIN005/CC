using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab4_Implement_lexical_analyzer_using_two_buffers
{
    public partial class Form1 : Form
    {
        private List<string> allTokens = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputText = textBoxInput.Text;
            List<string> tokens = Analyze(inputText);
            allTokens.AddRange(tokens); // Add tokens to the list of all tokens
            DisplayTokens(allTokens); // Display all tokens
        }

        private List<string> Analyze(string input)
        {
            List<string> tokens = new List<string>();

            char[] inputBuffer = input.ToCharArray();
            char[] tokenBuffer = new char[inputBuffer.Length];
            int bufferLength = inputBuffer.Length;

            int currentIndex = 0;
            int tokenIndex = 0;

            while (currentIndex < bufferLength)
            {
                // Check for whitespace and ignore it
                while (currentIndex < bufferLength && char.IsWhiteSpace(inputBuffer[currentIndex]))
                {
                    currentIndex++;
                }

                // Check for digits
                if (char.IsDigit(inputBuffer[currentIndex]))
                {
                    int start = currentIndex;
                    while (currentIndex < bufferLength && char.IsDigit(inputBuffer[currentIndex]))
                    {
                        tokenBuffer[tokenIndex++] = inputBuffer[currentIndex++];
                    }
                    string digit = new string(tokenBuffer, 0, tokenIndex);
                    tokens.Add($"Digit: {digit}");
                    tokenIndex = 0;
                }
                // Check for keywords
                else if (char.IsLetter(inputBuffer[currentIndex]))
                {
                    int start = currentIndex;
                    while (currentIndex < bufferLength && (char.IsLetter(inputBuffer[currentIndex]) || char.IsDigit(inputBuffer[currentIndex])))
                    {
                        tokenBuffer[tokenIndex++] = inputBuffer[currentIndex++];
                    }
                    string token = new string(tokenBuffer, 0, tokenIndex);
                    if (IsKeyword(token))
                    {
                        tokens.Add($"Keyword: {token}");
                    }
                    else
                    {
                        tokens.Add($"Identifier: {token}");
                    }
                    tokenIndex = 0;
                }
                // Check for operators
                else if (IsOperator(inputBuffer[currentIndex]))
                {
                    tokens.Add($"Operator: {inputBuffer[currentIndex++]}");
                }
                else if (currentIndex < bufferLength)
                {
                    // Treat anything else as a separate token
                    tokens.Add($"Character: {inputBuffer[currentIndex++]}");
                }
            }

            return tokens;
        }

        private bool IsOperator(char c)
        {
            char[] operators = { '+', '-', '*', '/', '=', '<', '>', '&' }; // Define your operators here
            return operators.Contains(c);
        }

        private bool IsKeyword(string token)
        {
            string[] keywords = { "if", "else", "while", "int", "float" }; // Define your keywords here
            return keywords.Contains(token);
        }


        private void DisplayTokens(List<string> tokens)
        {
            textBoxTokens.Clear();
            foreach (string token in tokens)
            {
                textBoxTokens.AppendText(token + Environment.NewLine);
            }
        }
    }
}