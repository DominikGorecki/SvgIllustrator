using System;
using System.Collections.Generic;
using System.Text;

namespace SvgIllustrator.Model.Exceptions
{
    public class AttributeMalformedException : Exception
    {
        public AttributeMalformedException() : base()
        {
        }

        public AttributeMalformedException(string message) : base(message)
        {
        }
    }
}
