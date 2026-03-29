//HintName: G.Models.PostConnectedAccountsResponseConnectionDataVariant1ValVariant6Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostConnectedAccountsResponseConnectionDataVariant1ValVariant6Status
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
    public static class PostConnectedAccountsResponseConnectionDataVariant1ValVariant6StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsResponseConnectionDataVariant1ValVariant6Status value)
        {
            return value switch
            {
                PostConnectedAccountsResponseConnectionDataVariant1ValVariant6Status.Inactive => "INACTIVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsResponseConnectionDataVariant1ValVariant6Status? ToEnum(string value)
        {
            return value switch
            {
                "INACTIVE" => PostConnectedAccountsResponseConnectionDataVariant1ValVariant6Status.Inactive,
                _ => null,
            };
        }
    }
}