using SvgIllustrator.Model.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SvgIllustrator.Model
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class ElementAttribute : Attribute
    {
        public ElementAttribute(string elementName)
        {
            ElementName = string.IsNullOrEmpty(elementName) ? throw new AttributeMalformedException("Name cannot be empty or null")
                            : elementName;
        }

        /// <summary>
        /// Name of the SVG Element
        /// </summary>
        public string ElementName { get; set; }
    }
}
