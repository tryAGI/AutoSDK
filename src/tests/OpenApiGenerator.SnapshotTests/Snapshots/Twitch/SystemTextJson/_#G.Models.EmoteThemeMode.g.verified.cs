//HintName: G.Models.EmoteThemeMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmoteThemeMode
    {
        /// <summary>
        /// 
        /// </summary>
        Dark,
        /// <summary>
        /// 
        /// </summary>
        Light,
    }

    public static class EmoteThemeModeExtensions
    {
        public static string ToValueString(this EmoteThemeMode value)
        {
            return value switch
            {
                EmoteThemeMode.Dark => "dark",
                EmoteThemeMode.Light => "light",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static EmoteThemeMode ToEnum(string value)
        {
            return value switch
            {
                "dark" => EmoteThemeMode.Dark,
                "light" => EmoteThemeMode.Light,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static EmoteThemeMode ToEnum(int value)
        {
            return value switch
            {
                0 => EmoteThemeMode.Dark,
                1 => EmoteThemeMode.Light,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}