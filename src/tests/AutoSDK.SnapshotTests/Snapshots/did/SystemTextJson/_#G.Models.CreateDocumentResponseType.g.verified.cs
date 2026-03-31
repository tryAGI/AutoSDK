//HintName: G.Models.CreateDocumentResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of object
    /// </summary>
    public enum CreateDocumentResponseType
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
    public static class CreateDocumentResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDocumentResponseType value)
        {
            return value switch
            {
                CreateDocumentResponseType.Document => "document",
                CreateDocumentResponseType.Knowledge => "knowledge",
                CreateDocumentResponseType.Record => "record",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDocumentResponseType? ToEnum(string value)
        {
            return value switch
            {
                "document" => CreateDocumentResponseType.Document,
                "knowledge" => CreateDocumentResponseType.Knowledge,
                "record" => CreateDocumentResponseType.Record,
                _ => null,
            };
        }
    }
}