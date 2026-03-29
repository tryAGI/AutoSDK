//HintName: G.Models.BatchedFacetDataType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BatchedFacetDataType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="batched_facet")]
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