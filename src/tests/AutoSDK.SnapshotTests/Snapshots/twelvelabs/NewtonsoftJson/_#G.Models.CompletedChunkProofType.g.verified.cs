//HintName: G.Models.CompletedChunkProofType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The verification method. Supported value: `etag`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CompletedChunkProofType
    {
        /// <summary>
        /// `etag`.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="etag")]
        Etag,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletedChunkProofTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletedChunkProofType value)
        {
            return value switch
            {
                CompletedChunkProofType.Etag => "etag",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletedChunkProofType? ToEnum(string value)
        {
            return value switch
            {
                "etag" => CompletedChunkProofType.Etag,
                _ => null,
            };
        }
    }
}