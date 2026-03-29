//HintName: G.Models.CompleteMultipartUploadRequestEntityType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CompleteMultipartUploadRequestEntityType
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
    public static class CompleteMultipartUploadRequestEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompleteMultipartUploadRequestEntityType value)
        {
            return value switch
            {
                CompleteMultipartUploadRequestEntityType.Span => "span",
                CompleteMultipartUploadRequestEntityType.Trace => "trace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompleteMultipartUploadRequestEntityType? ToEnum(string value)
        {
            return value switch
            {
                "span" => CompleteMultipartUploadRequestEntityType.Span,
                "trace" => CompleteMultipartUploadRequestEntityType.Trace,
                _ => null,
            };
        }
    }
}