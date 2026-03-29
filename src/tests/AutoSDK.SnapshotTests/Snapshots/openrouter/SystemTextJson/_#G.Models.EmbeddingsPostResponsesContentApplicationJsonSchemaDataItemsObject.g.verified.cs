//HintName: G.Models.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsObject
    {
        /// <summary>
        /// 
        /// </summary>
        Embedding,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsObject value)
        {
            return value switch
            {
                EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsObject.Embedding => "embedding",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsObject? ToEnum(string value)
        {
            return value switch
            {
                "embedding" => EmbeddingsPostResponsesContentApplicationJsonSchemaDataItemsObject.Embedding,
                _ => null,
            };
        }
    }
}