//HintName: G.Models.ExtractMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Extraction mode options.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExtractMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BALANCED")]
        Balanced,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FAST")]
        Fast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MULTIMODAL")]
        Multimodal,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PREMIUM")]
        Premium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExtractModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractMode value)
        {
            return value switch
            {
                ExtractMode.Balanced => "BALANCED",
                ExtractMode.Fast => "FAST",
                ExtractMode.Multimodal => "MULTIMODAL",
                ExtractMode.Premium => "PREMIUM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractMode? ToEnum(string value)
        {
            return value switch
            {
                "BALANCED" => ExtractMode.Balanced,
                "FAST" => ExtractMode.Fast,
                "MULTIMODAL" => ExtractMode.Multimodal,
                "PREMIUM" => ExtractMode.Premium,
                _ => null,
            };
        }
    }
}