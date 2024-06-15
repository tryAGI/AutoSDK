//HintName: G.Models.CreateThreadRequestToolResourcesFileSearchVectorStoresChunkingStrategyType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `auto`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateThreadRequestToolResourcesFileSearchVectorStoresChunkingStrategyType
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