//HintName: G.Models.IngestOtlpTracesContentEncoding.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum IngestOtlpTracesContentEncoding
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gzip")]
        Gzip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IngestOtlpTracesContentEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IngestOtlpTracesContentEncoding value)
        {
            return value switch
            {
                IngestOtlpTracesContentEncoding.Gzip => "gzip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IngestOtlpTracesContentEncoding? ToEnum(string value)
        {
            return value switch
            {
                "gzip" => IngestOtlpTracesContentEncoding.Gzip,
                _ => null,
            };
        }
    }
}