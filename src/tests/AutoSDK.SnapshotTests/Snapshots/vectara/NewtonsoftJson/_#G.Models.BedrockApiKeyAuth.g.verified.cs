//HintName: G.Models.BedrockApiKeyAuth.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// AWS Bedrock API key authentication
    /// </summary>
    public sealed partial class BedrockApiKeyAuth
    {
        /// <summary>
        /// Must be "bedrock_api_key" for Bedrock API key auth<br/>
        /// Default Value: bedrock_api_key<br/>
        /// Example: bedrock_api_key
        /// </summary>
        /// <default>"bedrock_api_key"</default>
        /// <example>bedrock_api_key</example>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// The Bedrock API key<br/>
        /// Example: AWS_BEARER_TOKEN_BEDROCK_...
        /// </summary>
        /// <example>AWS_BEARER_TOKEN_BEDROCK_...</example>
        [global::Newtonsoft.Json.JsonProperty("api_key", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApiKey { get; set; } = default!;

        /// <summary>
        /// AWS region for Bedrock<br/>
        /// Example: us-east-1
        /// </summary>
        /// <example>us-east-1</example>
        [global::Newtonsoft.Json.JsonProperty("region", Required = global::Newtonsoft.Json.Required.Always)]
        public string Region { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BedrockApiKeyAuth" /> class.
        /// </summary>
        /// <param name="type">
        /// Must be "bedrock_api_key" for Bedrock API key auth<br/>
        /// Default Value: bedrock_api_key<br/>
        /// Example: bedrock_api_key
        /// </param>
        /// <param name="apiKey">
        /// The Bedrock API key<br/>
        /// Example: AWS_BEARER_TOKEN_BEDROCK_...
        /// </param>
        /// <param name="region">
        /// AWS region for Bedrock<br/>
        /// Example: us-east-1
        /// </param>
        public BedrockApiKeyAuth(
            string type,
            string apiKey,
            string region)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BedrockApiKeyAuth" /> class.
        /// </summary>
        public BedrockApiKeyAuth()
        {
        }
    }
}