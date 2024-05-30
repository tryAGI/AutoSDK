//HintName: G.Models.GlobalEmoteThemeMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GlobalEmoteThemeMode
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

    public static class GlobalEmoteThemeModeExtensions
    {
        public static string ToValueString(this GlobalEmoteThemeMode value)
        {
            return value switch
            {
                GlobalEmoteThemeMode.Dark => "dark",
                GlobalEmoteThemeMode.Light => "light",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GlobalEmoteThemeMode ToEnum(string value)
        {
            return value switch
            {
                "dark" => GlobalEmoteThemeMode.Dark,
                "light" => GlobalEmoteThemeMode.Light,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static GlobalEmoteThemeMode ToEnum(int value)
        {
            return value switch
            {
                0 => GlobalEmoteThemeMode.Dark,
                1 => GlobalEmoteThemeMode.Light,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}