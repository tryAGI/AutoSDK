//HintName: G.Models.CreateVectorStoreRequestChunkingStrategyDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateVectorStoreRequestChunkingStrategyDiscriminatorType
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
    public static class CreateVectorStoreRequestChunkingStrategyDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVectorStoreRequestChunkingStrategyDiscriminatorType value)
        {
            return value switch
            {
                CreateVectorStoreRequestChunkingStrategyDiscriminatorType.Auto => "auto",
                CreateVectorStoreRequestChunkingStrategyDiscriminatorType.Static => "static",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVectorStoreRequestChunkingStrategyDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateVectorStoreRequestChunkingStrategyDiscriminatorType.Auto,
                "static" => CreateVectorStoreRequestChunkingStrategyDiscriminatorType.Static,
                _ => null,
            };
        }
    }
}