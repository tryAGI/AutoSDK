//HintName: G.Models.PostConnectedAccountsRequestConnectionStateVariant1ValVariant1Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostConnectedAccountsRequestConnectionStateVariant1ValVariant1Status
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="INITIALIZING")]
        Initializing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostConnectedAccountsRequestConnectionStateVariant1ValVariant1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsRequestConnectionStateVariant1ValVariant1Status value)
        {
            return value switch
            {
                PostConnectedAccountsRequestConnectionStateVariant1ValVariant1Status.Initializing => "INITIALIZING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsRequestConnectionStateVariant1ValVariant1Status? ToEnum(string value)
        {
            return value switch
            {
                "INITIALIZING" => PostConnectedAccountsRequestConnectionStateVariant1ValVariant1Status.Initializing,
                _ => null,
            };
        }
    }
}