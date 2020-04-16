//Ed Louie
using System;
using System.Collections.Generic;
using System.Text;

namespace TextBox
{
    class TextBox
    {
        public int Padding { get; set; }

        public ConsoleColor BackColor { get; set; }

        public ConsoleColor ForeColor { get; set; }

        public string Text { get; set; }

        public TextBox()
        {
            Padding = 0;
            BackColor = default;
            ForeColor = default;
            Text = "";
        }

        public void DisplayText()
        {
            Console.WriteLine(Text);            
        }
        
        
    }
}
