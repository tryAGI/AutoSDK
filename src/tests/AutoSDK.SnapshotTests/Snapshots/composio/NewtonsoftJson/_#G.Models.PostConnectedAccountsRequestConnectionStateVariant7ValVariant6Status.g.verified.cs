//HintName: G.Models.PostConnectedAccountsRequestConnectionStateVariant7ValVariant6Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostConnectedAccountsRequestConnectionStateVariant7ValVariant6Status
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="EXPIRED")]
        Expired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostConnectedAccountsRequestConnectionStateVariant7ValVariant6StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsRequestConnectionStateVariant7ValVariant6Status value)
        {
            return value switch
            {
                PostConnectedAccountsRequestConnectionStateVariant7ValVariant6Status.Expired => "EXPIRED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsRequestConnectionStateVariant7ValVariant6Status? ToEnum(string value)
        {
            return value switch
            {
                "EXPIRED" => PostConnectedAccountsRequestConnectionStateVariant7ValVariant6Status.Expired,
                _ => null,
            };
        }
    }
}