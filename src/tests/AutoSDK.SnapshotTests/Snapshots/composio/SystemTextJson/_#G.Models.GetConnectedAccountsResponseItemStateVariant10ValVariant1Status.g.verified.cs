//HintName: G.Models.GetConnectedAccountsResponseItemStateVariant10ValVariant1Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConnectedAccountsResponseItemStateVariant10ValVariant1Status
    {
        /// <summary>
        /// 
        /// </summary>
        Initializing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsResponseItemStateVariant10ValVariant1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsResponseItemStateVariant10ValVariant1Status value)
        {
            return value switch
            {
                GetConnectedAccountsResponseItemStateVariant10ValVariant1Status.Initializing => "INITIALIZING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsResponseItemStateVariant10ValVariant1Status? ToEnum(string value)
        {
            return value switch
            {
                "INITIALIZING" => GetConnectedAccountsResponseItemStateVariant10ValVariant1Status.Initializing,
                _ => null,
            };
        }
    }
}