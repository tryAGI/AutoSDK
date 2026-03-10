//HintName: G.Models.CaptionStyleModelTextWeight2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CaptionStyleModelTextWeight2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="normal")]
        Normal,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bold")]
        Bold,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CaptionStyleModelTextWeight2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CaptionStyleModelTextWeight2 value)
        {
            return value switch
            {
                CaptionStyleModelTextWeight2.Normal => "normal",
                CaptionStyleModelTextWeight2.Bold => "bold",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CaptionStyleModelTextWeight2? ToEnum(string value)
        {
            return value switch
            {
                "normal" => CaptionStyleModelTextWeight2.Normal,
                "bold" => CaptionStyleModelTextWeight2.Bold,
                _ => null,
            };
        }
    }
}