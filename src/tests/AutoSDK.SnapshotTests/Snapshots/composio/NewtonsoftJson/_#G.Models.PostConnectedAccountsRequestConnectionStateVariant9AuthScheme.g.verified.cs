//HintName: G.Models.PostConnectedAccountsRequestConnectionStateVariant9AuthScheme.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostConnectedAccountsRequestConnectionStateVariant9AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BILLCOM_AUTH")]
        BillcomAuth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostConnectedAccountsRequestConnectionStateVariant9AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsRequestConnectionStateVariant9AuthScheme value)
        {
            return value switch
            {
                PostConnectedAccountsRequestConnectionStateVariant9AuthScheme.BillcomAuth => "BILLCOM_AUTH",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsRequestConnectionStateVariant9AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "BILLCOM_AUTH" => PostConnectedAccountsRequestConnectionStateVariant9AuthScheme.BillcomAuth,
                _ => null,
            };
        }
    }
}