//HintName: G.Models.EmbeddingsResponseDataItemObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmbeddingsResponseDataItemObject
    {
        /// <summary>
        /// 
        /// </summary>
        Embedding,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingsResponseDataItemObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingsResponseDataItemObject value)
        {
            return value switch
            {
                EmbeddingsResponseDataItemObject.Embedding => "embedding",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingsResponseDataItemObject? ToEnum(string value)
        {
            return value switch
            {
                "embedding" => EmbeddingsResponseDataItemObject.Embedding,
                _ => null,
            };
        }
    }
}