//HintName: G.Models.AttachmentListEntityType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AttachmentListEntityType
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
    public static class AttachmentListEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AttachmentListEntityType value)
        {
            return value switch
            {
                AttachmentListEntityType.Span => "span",
                AttachmentListEntityType.Trace => "trace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AttachmentListEntityType? ToEnum(string value)
        {
            return value switch
            {
                "span" => AttachmentListEntityType.Span,
                "trace" => AttachmentListEntityType.Trace,
                _ => null,
            };
        }
    }
}