//HintName: G.Models.CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="static")]
        Static,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType value)
        {
            return value switch
            {
                CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType.Auto => "auto",
                CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType.Auto,
                "static" => CreateAssistantRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType.Static,
                _ => null,
            };
        }
    }
}