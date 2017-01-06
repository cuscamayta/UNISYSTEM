using System;

namespace EW.Unisystems.Common
{
    public static class StringExtension
    {

        public static string ToImageString(this byte[] image)
        {
            var imageBase64 = Convert.ToBase64String(image);
            return imageBase64;
        }
    }
}