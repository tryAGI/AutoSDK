//HintName: G.Models.DownloadAttachmentEntityType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DownloadAttachmentEntityType
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