//HintName: G.Models.TextTo3DRefineRequestMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TextTo3DRefineRequestMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="refine")]
        Refine,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextTo3DRefineRequestModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextTo3DRefineRequestMode value)
        {
            return value switch
            {
                TextTo3DRefineRequestMode.Refine => "refine",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextTo3DRefineRequestMode? ToEnum(string value)
        {
            return value switch
            {
                "refine" => TextTo3DRefineRequestMode.Refine,
                _ => null,
            };
        }
    }
}