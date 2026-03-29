//HintName: G.Models.GetConnectedAccountsByNanoidResponseStateVariant9AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConnectedAccountsByNanoidResponseStateVariant9AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        BillcomAuth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsByNanoidResponseStateVariant9AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsByNanoidResponseStateVariant9AuthScheme value)
        {
            return value switch
            {
                GetConnectedAccountsByNanoidResponseStateVariant9AuthScheme.BillcomAuth => "BILLCOM_AUTH",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsByNanoidResponseStateVariant9AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "BILLCOM_AUTH" => GetConnectedAccountsByNanoidResponseStateVariant9AuthScheme.BillcomAuth,
                _ => null,
            };
        }
    }
}