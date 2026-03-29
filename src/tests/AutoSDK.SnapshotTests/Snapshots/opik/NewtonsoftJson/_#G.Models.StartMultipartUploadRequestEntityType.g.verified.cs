//HintName: G.Models.StartMultipartUploadRequestEntityType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StartMultipartUploadRequestEntityType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="span")]
        Span,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="trace")]
        Trace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StartMultipartUploadRequestEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StartMultipartUploadRequestEntityType value)
        {
            return value switch
            {
                StartMultipartUploadRequestEntityType.Span => "span",
                StartMultipartUploadRequestEntityType.Trace => "trace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StartMultipartUploadRequestEntityType? ToEnum(string value)
        {
            return value switch
            {
                "span" => StartMultipartUploadRequestEntityType.Span,
                "trace" => StartMultipartUploadRequestEntityType.Trace,
                _ => null,
            };
        }
    }
}