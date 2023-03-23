using System;
namespace ShadowHome.Core.Extensions
{

    public static class EnumExtension
    {
        public static T ToEnum<T>(this string value, T defaultValue) where T : struct
        {
            if (string.IsNullOrEmpty(value))
            {
                return defaultValue;
            }
            return Enum.TryParse(value, true, out T result) ? result : defaultValue;
        }
    }
}
