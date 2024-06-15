//HintName: G.Models.CreateAssistantRequestToolResourcesFileSearchVectorStoresChunkingStrategyType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `auto`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateAssistantRequestToolResourcesFileSearchVectorStoresChunkingStrategyType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAssistantRequestToolResourcesFileSearchVectorStoresChunkingStrategyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssistantRequestToolResourcesFileSearchVectorStoresChunkingStrategyType value)
        {
            return value switch
            {
                CreateAssistantRequestToolResourcesFileSearchVectorStoresChunkingStrategyType.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssistantRequestToolResourcesFileSearchVectorStoresChunkingStrategyType? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateAssistantRequestToolResourcesFileSearchVectorStoresChunkingStrategyType.Auto,
                _ => null,
            };
        }
    }
}