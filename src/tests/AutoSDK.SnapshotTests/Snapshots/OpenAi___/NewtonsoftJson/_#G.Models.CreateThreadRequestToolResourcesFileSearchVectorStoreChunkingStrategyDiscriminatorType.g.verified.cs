//HintName: G.Models.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType
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
    public static class CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType value)
        {
            return value switch
            {
                CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType.Auto => "auto",
                CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType.Auto,
                "static" => CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyDiscriminatorType.Static,
                _ => null,
            };
        }
    }
}