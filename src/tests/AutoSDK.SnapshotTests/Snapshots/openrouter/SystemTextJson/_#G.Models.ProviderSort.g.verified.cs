//HintName: G.Models.ProviderSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The provider sorting strategy (price, throughput, latency)
    /// </summary>
    public enum ProviderSort
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
    public static class ProviderSortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProviderSort value)
        {
            return value switch
            {
                ProviderSort.Exacto => "exacto",
                ProviderSort.Latency => "latency",
                ProviderSort.Price => "price",
                ProviderSort.Throughput => "throughput",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProviderSort? ToEnum(string value)
        {
            return value switch
            {
                "exacto" => ProviderSort.Exacto,
                "latency" => ProviderSort.Latency,
                "price" => ProviderSort.Price,
                "throughput" => ProviderSort.Throughput,
                _ => null,
            };
        }
    }
}