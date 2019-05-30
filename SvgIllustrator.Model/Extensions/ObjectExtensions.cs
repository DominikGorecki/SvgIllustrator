using System.ComponentModel;
using System.Linq;

namespace SvgIllustrator.Model.Extensions
{
    public static class ObjectExtensions
    {
        public static T GetAttributeOf<T>(this object obj)
            => TypeDescriptor.GetAttributes(obj).OfType<T>().SingleOrDefault();

    }
}
