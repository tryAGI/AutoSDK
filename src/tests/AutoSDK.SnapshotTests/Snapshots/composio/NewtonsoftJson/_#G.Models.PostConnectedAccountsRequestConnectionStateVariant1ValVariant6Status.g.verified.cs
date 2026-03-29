//HintName: G.Models.PostConnectedAccountsRequestConnectionStateVariant1ValVariant6Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostConnectedAccountsRequestConnectionStateVariant1ValVariant6Status
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="INACTIVE")]
        Inactive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostConnectedAccountsRequestConnectionStateVariant1ValVariant6StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsRequestConnectionStateVariant1ValVariant6Status value)
        {
            return value switch
            {
                PostConnectedAccountsRequestConnectionStateVariant1ValVariant6Status.Inactive => "INACTIVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsRequestConnectionStateVariant1ValVariant6Status? ToEnum(string value)
        {
            return value switch
            {
                "INACTIVE" => PostConnectedAccountsRequestConnectionStateVariant1ValVariant6Status.Inactive,
                _ => null,
            };
        }
    }
}