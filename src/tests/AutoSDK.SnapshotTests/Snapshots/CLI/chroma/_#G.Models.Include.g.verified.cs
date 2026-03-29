//HintName: G.Models.Include.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Use this enum to specify which fields should be returned when retrieving records.
    /// </summary>
    public enum Include
    {
        /// <summary>
        /// 
        /// </summary>
        Distances,
        /// <summary>
        /// 
        /// </summary>
        Documents,
        /// <summary>
        /// 
        /// </summary>
        Embeddings,
        /// <summary>
        /// 
        /// </summary>
        Metadatas,
        /// <summary>
        /// 
        /// </summary>
        Uris,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IncludeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Include value)
        {
            return value switch
            {
                Include.Distances => "distances",
                Include.Documents => "documents",
                Include.Embeddings => "embeddings",
                Include.Metadatas => "metadatas",
                Include.Uris => "uris",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Include? ToEnum(string value)
        {
            return value switch
            {
                "distances" => Include.Distances,
                "documents" => Include.Documents,
                "embeddings" => Include.Embeddings,
                "metadatas" => Include.Metadatas,
                "uris" => Include.Uris,
                _ => null,
            };
        }
    }
}