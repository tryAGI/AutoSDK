//HintName: G.Models.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `static`.
    /// </summary>
    public enum CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Static,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Type value)
        {
            return value switch
            {
                CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Type.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "static" => CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyVariant2Type.Static,
                _ => null,
            };
        }
    }
}