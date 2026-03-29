//HintName: G.Models.ProviderSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The provider sorting strategy (price, throughput, latency)
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProviderSort
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="exacto")]
        Exacto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="latency")]
        Latency,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="price")]
        Price,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="throughput")]
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