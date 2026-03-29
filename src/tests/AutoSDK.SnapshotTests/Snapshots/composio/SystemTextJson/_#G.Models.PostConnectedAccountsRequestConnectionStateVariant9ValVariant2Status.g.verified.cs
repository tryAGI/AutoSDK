//HintName: G.Models.PostConnectedAccountsRequestConnectionStateVariant9ValVariant2Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostConnectedAccountsRequestConnectionStateVariant9ValVariant2Status
    {
        /// <summary>
        /// 
        /// </summary>
        Initiated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostConnectedAccountsRequestConnectionStateVariant9ValVariant2StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsRequestConnectionStateVariant9ValVariant2Status value)
        {
            return value switch
            {
                PostConnectedAccountsRequestConnectionStateVariant9ValVariant2Status.Initiated => "INITIATED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsRequestConnectionStateVariant9ValVariant2Status? ToEnum(string value)
        {
            return value switch
            {
                "INITIATED" => PostConnectedAccountsRequestConnectionStateVariant9ValVariant2Status.Initiated,
                _ => null,
            };
        }
    }
}