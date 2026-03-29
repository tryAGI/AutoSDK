//HintName: G.Models.GetConnectedAccountsResponseItemStateVariant14ValVariant1Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConnectedAccountsResponseItemStateVariant14ValVariant1Status
    {
        /// <summary>
        /// 
        /// </summary>
        Initializing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsResponseItemStateVariant14ValVariant1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsResponseItemStateVariant14ValVariant1Status value)
        {
            return value switch
            {
                GetConnectedAccountsResponseItemStateVariant14ValVariant1Status.Initializing => "INITIALIZING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsResponseItemStateVariant14ValVariant1Status? ToEnum(string value)
        {
            return value switch
            {
                "INITIALIZING" => GetConnectedAccountsResponseItemStateVariant14ValVariant1Status.Initializing,
                _ => null,
            };
        }
    }
}