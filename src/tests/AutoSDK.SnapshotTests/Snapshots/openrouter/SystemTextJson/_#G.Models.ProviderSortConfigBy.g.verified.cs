//HintName: G.Models.ProviderSortConfigBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The provider sorting strategy (price, throughput, latency)
    /// </summary>
    public enum ProviderSortConfigBy
    {
        /// <summary>
        /// 
        /// </summary>
        Exacto,
        /// <summary>
        /// 
        /// </summary>
        Latency,
        /// <summary>
        /// 
        /// </summary>
        Price,
        /// <summary>
        /// 
        /// </summary>
        Throughput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProviderSortConfigByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProviderSortConfigBy value)
        {
            return value switch
            {
                ProviderSortConfigBy.Exacto => "exacto",
                ProviderSortConfigBy.Latency => "latency",
                ProviderSortConfigBy.Price => "price",
                ProviderSortConfigBy.Throughput => "throughput",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProviderSortConfigBy? ToEnum(string value)
        {
            return value switch
            {
                "exacto" => ProviderSortConfigBy.Exacto,
                "latency" => ProviderSortConfigBy.Latency,
                "price" => ProviderSortConfigBy.Price,
                "throughput" => ProviderSortConfigBy.Throughput,
                _ => null,
            };
        }
    }
}