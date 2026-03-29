//HintName: G.Models.TextTo3DPreviewRequestMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TextTo3DPreviewRequestMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="preview")]
        Preview,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextTo3DPreviewRequestModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextTo3DPreviewRequestMode value)
        {
            return value switch
            {
                TextTo3DPreviewRequestMode.Preview => "preview",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextTo3DPreviewRequestMode? ToEnum(string value)
        {
            return value switch
            {
                "preview" => TextTo3DPreviewRequestMode.Preview,
                _ => null,
            };
        }
    }
}