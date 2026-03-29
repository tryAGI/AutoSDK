//HintName: G.Models.IngestOtlpTracesContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum IngestOtlpTracesContentType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="application/json")]
        ApplicationJson,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="application/x-protobuf")]
        ApplicationXProtobuf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IngestOtlpTracesContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IngestOtlpTracesContentType value)
        {
            return value switch
            {
                IngestOtlpTracesContentType.ApplicationJson => "application/json",
                IngestOtlpTracesContentType.ApplicationXProtobuf => "application/x-protobuf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IngestOtlpTracesContentType? ToEnum(string value)
        {
            return value switch
            {
                "application/json" => IngestOtlpTracesContentType.ApplicationJson,
                "application/x-protobuf" => IngestOtlpTracesContentType.ApplicationXProtobuf,
                _ => null,
            };
        }
    }
}