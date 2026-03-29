//HintName: G.Models.ClassifyMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Supported classification execution modes.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClassifyMode
    {
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClassifyModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClassifyMode value)
        {
            return value switch
            {
                ClassifyMode.Fast => "FAST",
                ClassifyMode.Multimodal => "MULTIMODAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClassifyMode? ToEnum(string value)
        {
            return value switch
            {
                "FAST" => ClassifyMode.Fast,
                "MULTIMODAL" => ClassifyMode.Multimodal,
                _ => null,
            };
        }
    }
}