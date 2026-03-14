//HintName: G.Models.ArtifactReadToolParametersEncoding.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The encoding format for the content.<br/>
    /// Example: raw
    /// </summary>
    public enum ArtifactReadToolParametersEncoding
    {
        /// <summary>
        /// 
        /// </summary>
        Raw,
        /// <summary>
        /// 
        /// </summary>
        Base64,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ArtifactReadToolParametersEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ArtifactReadToolParametersEncoding value)
        {
            return value switch
            {
                ArtifactReadToolParametersEncoding.Raw => "raw",
                ArtifactReadToolParametersEncoding.Base64 => "base64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ArtifactReadToolParametersEncoding? ToEnum(string value)
        {
            return value switch
            {
                "raw" => ArtifactReadToolParametersEncoding.Raw,
                "base64" => ArtifactReadToolParametersEncoding.Base64,
                _ => null,
            };
        }
    }
}