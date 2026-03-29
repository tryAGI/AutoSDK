//HintName: G.Models.PostConnectedAccountsRequestConnectionStateVariant1ValVariant2Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostConnectedAccountsRequestConnectionStateVariant1ValVariant2Status
    {
        /// <summary>
        /// 
        /// </summary>
        Initiated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostConnectedAccountsRequestConnectionStateVariant1ValVariant2StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsRequestConnectionStateVariant1ValVariant2Status value)
        {
            return value switch
            {
                PostConnectedAccountsRequestConnectionStateVariant1ValVariant2Status.Initiated => "INITIATED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsRequestConnectionStateVariant1ValVariant2Status? ToEnum(string value)
        {
            return value switch
            {
                "INITIATED" => PostConnectedAccountsRequestConnectionStateVariant1ValVariant2Status.Initiated,
                _ => null,
            };
        }
    }
}