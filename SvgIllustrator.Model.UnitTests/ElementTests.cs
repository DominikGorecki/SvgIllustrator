using Microsoft.VisualStudio.TestTools.UnitTesting;
using SvgIllustrator.Model.Exceptions;

namespace SvgIllustrator.Model.UnitTests
{
    [TestClass]
    public class ElementTests
    {
        [TestMethod]
        [ExpectedException(typeof(AttributeMissingException))]
        public void MissingAttribute()
        {
            var el = new ElWithMissingAttribute();
        }

        [TestMethod]
        [ExpectedException(typeof(AttributeMalformedException))]
        public void MalformedAttribute()
        {
            var el = new ELWithEmptyAttribute();
        }

        private class ElWithMissingAttribute : Element
        {
            public ElWithMissingAttribute() : base()
            {
            }
        }

        [Element("")]
        private class ELWithEmptyAttribute : Element
        {
            public ELWithEmptyAttribute() : base()
            {
            }
        }
    }
}
