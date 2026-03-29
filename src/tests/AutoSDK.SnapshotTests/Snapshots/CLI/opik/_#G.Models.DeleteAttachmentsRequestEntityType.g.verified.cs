//HintName: G.Models.DeleteAttachmentsRequestEntityType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteAttachmentsRequestEntityType
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
    public static class DeleteAttachmentsRequestEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteAttachmentsRequestEntityType value)
        {
            return value switch
            {
                DeleteAttachmentsRequestEntityType.Span => "span",
                DeleteAttachmentsRequestEntityType.Trace => "trace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteAttachmentsRequestEntityType? ToEnum(string value)
        {
            return value switch
            {
                "span" => DeleteAttachmentsRequestEntityType.Span,
                "trace" => DeleteAttachmentsRequestEntityType.Trace,
                _ => null,
            };
        }
    }
}