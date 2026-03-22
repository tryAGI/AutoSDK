//HintName: G.Models.ArtifactReadToolParametersEncoding.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The encoding format for the content.<br/>
    /// Example: raw
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ArtifactReadToolParametersEncoding
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="base64")]
        Base64,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="raw")]
        Raw,
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
                ArtifactReadToolParametersEncoding.Base64 => "base64",
                ArtifactReadToolParametersEncoding.Raw => "raw",
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
                "base64" => ArtifactReadToolParametersEncoding.Base64,
                "raw" => ArtifactReadToolParametersEncoding.Raw,
                _ => null,
            };
        }
    }
}