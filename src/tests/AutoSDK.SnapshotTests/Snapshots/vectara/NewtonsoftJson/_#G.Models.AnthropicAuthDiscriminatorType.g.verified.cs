//HintName: G.Models.AnthropicAuthDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AnthropicAuthDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bearer")]
        Bearer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="header")]
        Header,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bedrock_static_iam")]
        BedrockStaticIam,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bedrock_api_key")]
        BedrockApiKey,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vertex_service_account")]
        VertexServiceAccount,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vertex_access_token")]
        VertexAccessToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicAuthDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicAuthDiscriminatorType value)
        {
            return value switch
            {
                AnthropicAuthDiscriminatorType.Bearer => "bearer",
                AnthropicAuthDiscriminatorType.Header => "header",
                AnthropicAuthDiscriminatorType.BedrockStaticIam => "bedrock_static_iam",
                AnthropicAuthDiscriminatorType.BedrockApiKey => "bedrock_api_key",
                AnthropicAuthDiscriminatorType.VertexServiceAccount => "vertex_service_account",
                AnthropicAuthDiscriminatorType.VertexAccessToken => "vertex_access_token",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicAuthDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "bearer" => AnthropicAuthDiscriminatorType.Bearer,
                "header" => AnthropicAuthDiscriminatorType.Header,
                "bedrock_static_iam" => AnthropicAuthDiscriminatorType.BedrockStaticIam,
                "bedrock_api_key" => AnthropicAuthDiscriminatorType.BedrockApiKey,
                "vertex_service_account" => AnthropicAuthDiscriminatorType.VertexServiceAccount,
                "vertex_access_token" => AnthropicAuthDiscriminatorType.VertexAccessToken,
                _ => null,
            };
        }
    }
}