//HintName: G.Models.CreateThreadRequestToolResourcesFileSearchVectorStoresChunkingStrategyType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `auto`.
    /// </summary>
    public enum CreateThreadRequestToolResourcesFileSearchVectorStoresChunkingStrategyType
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateThreadRequestToolResourcesFileSearchVectorStoresChunkingStrategyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateThreadRequestToolResourcesFileSearchVectorStoresChunkingStrategyType value)
        {
            return value switch
            {
                CreateThreadRequestToolResourcesFileSearchVectorStoresChunkingStrategyType.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateThreadRequestToolResourcesFileSearchVectorStoresChunkingStrategyType? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateThreadRequestToolResourcesFileSearchVectorStoresChunkingStrategyType.Auto,
                _ => null,
            };
        }
    }
}