//HintName: G.Models.GlobalEmoteFormatItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GlobalEmoteFormatItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="animated")]
        Animated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="static")]
        Static,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GlobalEmoteFormatItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GlobalEmoteFormatItem value)
        {
            return value switch
            {
                GlobalEmoteFormatItem.Animated => "animated",
                GlobalEmoteFormatItem.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GlobalEmoteFormatItem? ToEnum(string value)
        {
            return value switch
            {
                "animated" => GlobalEmoteFormatItem.Animated,
                "static" => GlobalEmoteFormatItem.Static,
                _ => null,
            };
        }
    }
}