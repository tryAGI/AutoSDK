//HintName: G.Models.GetDocumentResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of object
    /// </summary>
    public enum GetDocumentResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        Document,
        /// <summary>
        /// 
        /// </summary>
        Knowledge,
        /// <summary>
        /// 
        /// </summary>
        Record,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDocumentResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDocumentResponseType value)
        {
            return value switch
            {
                GetDocumentResponseType.Document => "document",
                GetDocumentResponseType.Knowledge => "knowledge",
                GetDocumentResponseType.Record => "record",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDocumentResponseType? ToEnum(string value)
        {
            return value switch
            {
                "document" => GetDocumentResponseType.Document,
                "knowledge" => GetDocumentResponseType.Knowledge,
                "record" => GetDocumentResponseType.Record,
                _ => null,
            };
        }
    }
}