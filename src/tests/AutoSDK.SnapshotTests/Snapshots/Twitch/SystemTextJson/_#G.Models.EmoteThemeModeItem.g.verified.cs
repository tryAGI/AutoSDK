//HintName: G.Models.EmoteThemeModeItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmoteThemeModeItem
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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmoteThemeModeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmoteThemeModeItem value)
        {
            return value switch
            {
                EmoteThemeModeItem.Dark => "dark",
                EmoteThemeModeItem.Light => "light",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmoteThemeModeItem? ToEnum(string value)
        {
            return value switch
            {
                "dark" => EmoteThemeModeItem.Dark,
                "light" => EmoteThemeModeItem.Light,
                _ => null,
            };
        }
    }
}