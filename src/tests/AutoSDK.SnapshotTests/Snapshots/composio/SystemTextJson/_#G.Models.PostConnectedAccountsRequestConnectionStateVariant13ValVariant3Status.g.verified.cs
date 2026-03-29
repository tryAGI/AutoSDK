//HintName: G.Models.PostConnectedAccountsRequestConnectionStateVariant13ValVariant3Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostConnectedAccountsRequestConnectionStateVariant13ValVariant3Status
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostConnectedAccountsRequestConnectionStateVariant13ValVariant3StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsRequestConnectionStateVariant13ValVariant3Status value)
        {
            return value switch
            {
                PostConnectedAccountsRequestConnectionStateVariant13ValVariant3Status.Active => "ACTIVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsRequestConnectionStateVariant13ValVariant3Status? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => PostConnectedAccountsRequestConnectionStateVariant13ValVariant3Status.Active,
                _ => null,
            };
        }
    }
}