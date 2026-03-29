//HintName: G.Models.TransportCostType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of cost, always 'transport' for this class.
    /// </summary>
    public enum TransportCostType
    {
        /// <summary>
        /// 
        /// </summary>
        Transport,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransportCostTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransportCostType value)
        {
            return value switch
            {
                TransportCostType.Transport => "transport",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransportCostType? ToEnum(string value)
        {
            return value switch
            {
                "transport" => TransportCostType.Transport,
                _ => null,
            };
        }
    }
}