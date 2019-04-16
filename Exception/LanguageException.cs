using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LightNovelSnifferCore.Exception
{
    public class LanguageException : System.Exception
    {
        public LanguageException(string message) : base(message){}
    }
}
