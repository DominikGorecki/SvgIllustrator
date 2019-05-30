using System;
using System.Collections.Generic;
using System.Text;

namespace SvgIllustrator.Model.Exceptions
{
    public class AttributeMissingException : Exception
    {
        public AttributeMissingException(string message) : base(message)
        {
        }
    }
}
