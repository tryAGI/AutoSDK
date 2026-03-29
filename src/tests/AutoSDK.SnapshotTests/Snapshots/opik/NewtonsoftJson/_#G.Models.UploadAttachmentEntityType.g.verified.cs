//HintName: G.Models.UploadAttachmentEntityType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UploadAttachmentEntityType
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
    public static class UploadAttachmentEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UploadAttachmentEntityType value)
        {
            return value switch
            {
                UploadAttachmentEntityType.Span => "span",
                UploadAttachmentEntityType.Trace => "trace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UploadAttachmentEntityType? ToEnum(string value)
        {
            return value switch
            {
                "span" => UploadAttachmentEntityType.Span,
                "trace" => UploadAttachmentEntityType.Trace,
                _ => null,
            };
        }
    }
}