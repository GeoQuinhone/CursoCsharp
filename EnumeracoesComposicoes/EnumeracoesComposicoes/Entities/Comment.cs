using System;
using System.Collections.Generic;


namespace EnumeracoesComposicoes.Entities
{
    class Comment
    {
        public string Text { get; set; }

        public Comment() { }

        public Comment(string text) 
        { 
            Text = text; 
        }
    }
}
