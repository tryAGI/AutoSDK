//HintName: G.Models.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent")]
        Agent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemDiscriminatorType value)
        {
            return value switch
            {
                ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemDiscriminatorType.Agent => "agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemDiscriminatorType.Agent,
                _ => null,
            };
        }
    }
}