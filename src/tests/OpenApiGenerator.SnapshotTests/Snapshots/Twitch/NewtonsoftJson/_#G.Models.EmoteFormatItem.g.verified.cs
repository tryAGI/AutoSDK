//HintName: G.Models.EmoteFormatItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EmoteFormatItem
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
    public static class EmoteFormatItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmoteFormatItem value)
        {
            return value switch
            {
                EmoteFormatItem.Animated => "animated",
                EmoteFormatItem.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmoteFormatItem? ToEnum(string value)
        {
            return value switch
            {
                "animated" => EmoteFormatItem.Animated,
                "static" => EmoteFormatItem.Static,
                _ => null,
            };
        }
    }
}