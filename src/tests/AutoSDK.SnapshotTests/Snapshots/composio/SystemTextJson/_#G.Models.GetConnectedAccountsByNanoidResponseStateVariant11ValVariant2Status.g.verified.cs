//HintName: G.Models.GetConnectedAccountsByNanoidResponseStateVariant11ValVariant2Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConnectedAccountsByNanoidResponseStateVariant11ValVariant2Status
    {
        /// <summary>
        /// 
        /// </summary>
        Initiated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsByNanoidResponseStateVariant11ValVariant2StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsByNanoidResponseStateVariant11ValVariant2Status value)
        {
            return value switch
            {
                GetConnectedAccountsByNanoidResponseStateVariant11ValVariant2Status.Initiated => "INITIATED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsByNanoidResponseStateVariant11ValVariant2Status? ToEnum(string value)
        {
            return value switch
            {
                "INITIATED" => GetConnectedAccountsByNanoidResponseStateVariant11ValVariant2Status.Initiated,
                _ => null,
            };
        }
    }
}