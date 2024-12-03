//HintName: G.Models.VectorStoreFileObjectChunkingStrategyDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum VectorStoreFileObjectChunkingStrategyDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Static,
        /// <summary>
        /// 
        /// </summary>
        Other,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VectorStoreFileObjectChunkingStrategyDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VectorStoreFileObjectChunkingStrategyDiscriminatorType value)
        {
            return value switch
            {
                VectorStoreFileObjectChunkingStrategyDiscriminatorType.Static => "static",
                VectorStoreFileObjectChunkingStrategyDiscriminatorType.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VectorStoreFileObjectChunkingStrategyDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "static" => VectorStoreFileObjectChunkingStrategyDiscriminatorType.Static,
                "other" => VectorStoreFileObjectChunkingStrategyDiscriminatorType.Other,
                _ => null,
            };
        }
    }
}