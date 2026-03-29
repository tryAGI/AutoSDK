//HintName: G.Models.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1")]
        x1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyVersion value)
        {
            return value switch
            {
                ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyVersion.x1 => "1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyVersion? ToEnum(string value)
        {
            return value switch
            {
                "1" => ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyVersion.x1,
                _ => null,
            };
        }
    }
}