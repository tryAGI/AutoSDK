//HintName: G.Models.PostConnectedAccountsRequestConnectionStateVariant7ValVariant1Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostConnectedAccountsRequestConnectionStateVariant7ValVariant1Status
    {
        /// <summary>
        /// 
        /// </summary>
        Initializing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostConnectedAccountsRequestConnectionStateVariant7ValVariant1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsRequestConnectionStateVariant7ValVariant1Status value)
        {
            return value switch
            {
                PostConnectedAccountsRequestConnectionStateVariant7ValVariant1Status.Initializing => "INITIALIZING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsRequestConnectionStateVariant7ValVariant1Status? ToEnum(string value)
        {
            return value switch
            {
                "INITIALIZING" => PostConnectedAccountsRequestConnectionStateVariant7ValVariant1Status.Initializing,
                _ => null,
            };
        }
    }
}