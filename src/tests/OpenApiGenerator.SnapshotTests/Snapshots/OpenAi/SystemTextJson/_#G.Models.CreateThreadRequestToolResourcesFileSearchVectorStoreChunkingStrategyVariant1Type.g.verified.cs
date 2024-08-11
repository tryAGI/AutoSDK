//HintName: G.Models.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `auto`.
    /// </summary>
    public enum CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1Type value)
        {
            return value switch
            {
                CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1Type.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant1Type.Auto,
                _ => null,
            };
        }
    }
}