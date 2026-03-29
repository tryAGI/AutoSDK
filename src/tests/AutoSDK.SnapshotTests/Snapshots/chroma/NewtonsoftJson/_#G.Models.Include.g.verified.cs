//HintName: G.Models.Include.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Use this enum to specify which fields should be returned when retrieving records.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Include
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="distances")]
        Distances,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="documents")]
        Documents,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="embeddings")]
        Embeddings,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="metadatas")]
        Metadatas,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="uris")]
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