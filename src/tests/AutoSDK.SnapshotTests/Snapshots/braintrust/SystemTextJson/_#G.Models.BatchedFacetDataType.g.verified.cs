//HintName: G.Models.BatchedFacetDataType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BatchedFacetDataType
    {
        /// <summary>
        /// 
        /// </summary>
        BatchedFacet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchedFacetDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchedFacetDataType value)
        {
            return value switch
            {
                BatchedFacetDataType.BatchedFacet => "batched_facet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchedFacetDataType? ToEnum(string value)
        {
            return value switch
            {
                "batched_facet" => BatchedFacetDataType.BatchedFacet,
                _ => null,
            };
        }
    }
}