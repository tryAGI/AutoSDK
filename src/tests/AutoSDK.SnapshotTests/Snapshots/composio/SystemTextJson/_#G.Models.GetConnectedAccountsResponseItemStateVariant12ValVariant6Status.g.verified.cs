//HintName: G.Models.GetConnectedAccountsResponseItemStateVariant12ValVariant6Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConnectedAccountsResponseItemStateVariant12ValVariant6Status
    {
        /// <summary>
        /// 
        /// </summary>
        Expired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsResponseItemStateVariant12ValVariant6StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsResponseItemStateVariant12ValVariant6Status value)
        {
            return value switch
            {
                GetConnectedAccountsResponseItemStateVariant12ValVariant6Status.Expired => "EXPIRED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsResponseItemStateVariant12ValVariant6Status? ToEnum(string value)
        {
            return value switch
            {
                "EXPIRED" => GetConnectedAccountsResponseItemStateVariant12ValVariant6Status.Expired,
                _ => null,
            };
        }
    }
}