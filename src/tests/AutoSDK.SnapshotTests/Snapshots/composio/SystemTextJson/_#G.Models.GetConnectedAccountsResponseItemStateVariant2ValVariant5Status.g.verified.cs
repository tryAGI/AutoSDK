//HintName: G.Models.GetConnectedAccountsResponseItemStateVariant2ValVariant5Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConnectedAccountsResponseItemStateVariant2ValVariant5Status
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsResponseItemStateVariant2ValVariant5StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsResponseItemStateVariant2ValVariant5Status value)
        {
            return value switch
            {
                GetConnectedAccountsResponseItemStateVariant2ValVariant5Status.Failed => "FAILED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsResponseItemStateVariant2ValVariant5Status? ToEnum(string value)
        {
            return value switch
            {
                "FAILED" => GetConnectedAccountsResponseItemStateVariant2ValVariant5Status.Failed,
                _ => null,
            };
        }
    }
}