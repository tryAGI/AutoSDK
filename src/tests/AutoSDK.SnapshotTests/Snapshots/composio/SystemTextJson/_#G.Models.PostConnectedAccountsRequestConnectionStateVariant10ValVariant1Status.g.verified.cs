//HintName: G.Models.PostConnectedAccountsRequestConnectionStateVariant10ValVariant1Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostConnectedAccountsRequestConnectionStateVariant10ValVariant1Status
    {
        /// <summary>
        /// 
        /// </summary>
        Initializing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostConnectedAccountsRequestConnectionStateVariant10ValVariant1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsRequestConnectionStateVariant10ValVariant1Status value)
        {
            return value switch
            {
                PostConnectedAccountsRequestConnectionStateVariant10ValVariant1Status.Initializing => "INITIALIZING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsRequestConnectionStateVariant10ValVariant1Status? ToEnum(string value)
        {
            return value switch
            {
                "INITIALIZING" => PostConnectedAccountsRequestConnectionStateVariant10ValVariant1Status.Initializing,
                _ => null,
            };
        }
    }
}