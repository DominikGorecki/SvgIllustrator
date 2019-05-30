using SvgIllustrator.Model.Exceptions;
using SvgIllustrator.Model.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SvgIllustrator.Model
{
    public abstract class Element
    {
        public Element()
        {
            Name = this.GetAttributeOf<ElementAttribute>()?.ElementName ?? throw new AttributeMissingException("Element attribute needs to be present");
        }

        public string Name { get; private set; }
    }

}
