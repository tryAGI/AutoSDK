//HintName: G.Models.DownloadAttachmentEntityType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DownloadAttachmentEntityType
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
    public static class DownloadAttachmentEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DownloadAttachmentEntityType value)
        {
            return value switch
            {
                DownloadAttachmentEntityType.Span => "span",
                DownloadAttachmentEntityType.Trace => "trace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DownloadAttachmentEntityType? ToEnum(string value)
        {
            return value switch
            {
                "span" => DownloadAttachmentEntityType.Span,
                "trace" => DownloadAttachmentEntityType.Trace,
                _ => null,
            };
        }
    }
}