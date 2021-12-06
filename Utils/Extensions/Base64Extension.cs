namespace Jitesoft.Utils.Extensions
{
    public static class Base64Extension
    {
        /// <summary>
        /// Pads a base64 encoded string with `=`.
        /// </summary>
        /// <param name="self">String to modify.</param>
        /// <returns>String with padding.</returns>
        public static string AddBase64Padding(this string self)
        {
            while (self.Length % 4 != 0)
            {
                self += '=';
            }

            return self;
        }

        /// <summary>
        /// Remove padding from base64 encoded strings.
        /// </summary>
        /// <param name="self">String to modify.</param>
        /// <returns>String without padding.</returns>
        public static string RemoveBase64Padding(this string self)
        {
            self = self.TrimEnd('=');
            return self;
        }
    }
}
