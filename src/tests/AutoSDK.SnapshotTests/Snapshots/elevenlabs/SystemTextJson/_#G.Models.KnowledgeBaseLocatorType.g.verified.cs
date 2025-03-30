//HintName: G.Models.KnowledgeBaseLocatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the knowledge base
    /// </summary>
    public enum KnowledgeBaseLocatorType
    {
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KnowledgeBaseLocatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KnowledgeBaseLocatorType value)
        {
            return value switch
            {
                KnowledgeBaseLocatorType.File => "file",
                KnowledgeBaseLocatorType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KnowledgeBaseLocatorType? ToEnum(string value)
        {
            return value switch
            {
                "file" => KnowledgeBaseLocatorType.File,
                "url" => KnowledgeBaseLocatorType.Url,
                _ => null,
            };
        }
    }
}