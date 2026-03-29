//HintName: G.Models.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant2Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConnectedAccountsByNanoidResponseStateVariant2ValVariant2Status
    {
        /// <summary>
        /// 
        /// </summary>
        Initiated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsByNanoidResponseStateVariant2ValVariant2StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsByNanoidResponseStateVariant2ValVariant2Status value)
        {
            return value switch
            {
                GetConnectedAccountsByNanoidResponseStateVariant2ValVariant2Status.Initiated => "INITIATED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsByNanoidResponseStateVariant2ValVariant2Status? ToEnum(string value)
        {
            return value switch
            {
                "INITIATED" => GetConnectedAccountsByNanoidResponseStateVariant2ValVariant2Status.Initiated,
                _ => null,
            };
        }
    }
}