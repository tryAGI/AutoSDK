//HintName: G.Models.VectorDBProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Supported vector database providers for archival memory
    /// </summary>
    public enum VectorDBProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Native,
        /// <summary>
        /// 
        /// </summary>
        Pinecone,
        /// <summary>
        /// 
        /// </summary>
        Tpuf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VectorDBProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VectorDBProvider value)
        {
            return value switch
            {
                VectorDBProvider.Native => "native",
                VectorDBProvider.Pinecone => "pinecone",
                VectorDBProvider.Tpuf => "tpuf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VectorDBProvider? ToEnum(string value)
        {
            return value switch
            {
                "native" => VectorDBProvider.Native,
                "pinecone" => VectorDBProvider.Pinecone,
                "tpuf" => VectorDBProvider.Tpuf,
                _ => null,
            };
        }
    }
}