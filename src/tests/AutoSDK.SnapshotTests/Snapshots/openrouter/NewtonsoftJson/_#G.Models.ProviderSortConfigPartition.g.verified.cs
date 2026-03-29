//HintName: G.Models.ProviderSortConfigPartition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Partitioning strategy for sorting: "model" (default) groups endpoints by model before sorting (fallback models remain fallbacks), "none" sorts all endpoints together regardless of model.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProviderSortConfigPartition
    {
        /// <summary>
        /// "model" (default) groups endpoints by model before sorting (fallback models remain fallbacks), "none" sorts all endpoints together regardless of model.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="model")]
        Model,
        /// <summary>
        /// "model" (default) groups endpoints by model before sorting (fallback models remain fallbacks), "none" sorts all endpoints together regardless of model.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProviderSortConfigPartitionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProviderSortConfigPartition value)
        {
            return value switch
            {
                ProviderSortConfigPartition.Model => "model",
                ProviderSortConfigPartition.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProviderSortConfigPartition? ToEnum(string value)
        {
            return value switch
            {
                "model" => ProviderSortConfigPartition.Model,
                "none" => ProviderSortConfigPartition.None,
                _ => null,
            };
        }
    }
}