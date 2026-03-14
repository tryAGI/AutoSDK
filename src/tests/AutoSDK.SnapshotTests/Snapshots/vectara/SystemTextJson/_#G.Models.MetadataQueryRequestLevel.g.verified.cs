//HintName: G.Models.MetadataQueryRequestLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether to search document-level or part-level metadata. Document-level returns unique documents, part-level can return multiple parts from the same document.<br/>
    /// Default Value: document
    /// </summary>
    public enum MetadataQueryRequestLevel
    {
        /// <summary>
        /// 
        /// </summary>
        Document,
        /// <summary>
        /// 
        /// </summary>
        Part,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MetadataQueryRequestLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MetadataQueryRequestLevel value)
        {
            return value switch
            {
                MetadataQueryRequestLevel.Document => "document",
                MetadataQueryRequestLevel.Part => "part",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MetadataQueryRequestLevel? ToEnum(string value)
        {
            return value switch
            {
                "document" => MetadataQueryRequestLevel.Document,
                "part" => MetadataQueryRequestLevel.Part,
                _ => null,
            };
        }
    }
}