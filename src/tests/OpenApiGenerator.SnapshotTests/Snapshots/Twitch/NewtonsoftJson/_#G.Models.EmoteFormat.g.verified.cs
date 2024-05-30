//HintName: G.Models.EmoteFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EmoteFormat
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

    public static class EmoteFormatExtensions
    {
        public static string ToValueString(this EmoteFormat value)
        {
            return value switch
            {
                EmoteFormat.Animated => "animated",
                EmoteFormat.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static EmoteFormat ToEnum(string value)
        {
            return value switch
            {
                "animated" => EmoteFormat.Animated,
                "static" => EmoteFormat.Static,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static EmoteFormat ToEnum(int value)
        {
            return value switch
            {
                0 => EmoteFormat.Animated,
                1 => EmoteFormat.Static,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}