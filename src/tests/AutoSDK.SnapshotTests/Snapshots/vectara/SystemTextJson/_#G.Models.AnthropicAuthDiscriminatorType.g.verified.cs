//HintName: G.Models.AnthropicAuthDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicAuthDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Bearer,
        /// <summary>
        /// 
        /// </summary>
        BedrockApiKey,
        /// <summary>
        /// 
        /// </summary>
        BedrockStaticIam,
        /// <summary>
        /// 
        /// </summary>
        Header,
        /// <summary>
        /// 
        /// </summary>
        VertexAccessToken,
        /// <summary>
        /// 
        /// </summary>
        VertexServiceAccount,
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
                AnthropicAuthDiscriminatorType.BedrockApiKey => "bedrock_api_key",
                AnthropicAuthDiscriminatorType.BedrockStaticIam => "bedrock_static_iam",
                AnthropicAuthDiscriminatorType.Header => "header",
                AnthropicAuthDiscriminatorType.VertexAccessToken => "vertex_access_token",
                AnthropicAuthDiscriminatorType.VertexServiceAccount => "vertex_service_account",
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
                "bedrock_api_key" => AnthropicAuthDiscriminatorType.BedrockApiKey,
                "bedrock_static_iam" => AnthropicAuthDiscriminatorType.BedrockStaticIam,
                "header" => AnthropicAuthDiscriminatorType.Header,
                "vertex_access_token" => AnthropicAuthDiscriminatorType.VertexAccessToken,
                "vertex_service_account" => AnthropicAuthDiscriminatorType.VertexServiceAccount,
                _ => null,
            };
        }
    }
}