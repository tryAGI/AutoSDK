//HintName: G.Models.StartMultipartUploadRequestEntityType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum StartMultipartUploadRequestEntityType
    {
        /// <summary>
        /// 
        /// </summary>
        Span,
        /// <summary>
        /// 
        /// </summary>
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