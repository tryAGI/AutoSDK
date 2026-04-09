//HintName: G.Models.CreateAnthropicBedrockCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAnthropicBedrockCredentialDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateAnthropicBedrockCredentialDTOProviderJsonConverter))]
        public global::G.CreateAnthropicBedrockCredentialDTOProvider Provider { get; set; }

        /// <summary>
        /// AWS region where Bedrock is configured.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("region", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateAnthropicBedrockCredentialDTORegionJsonConverter))]
        public global::G.CreateAnthropicBedrockCredentialDTORegion Region { get; set; } = default!;

        /// <summary>
        /// Authentication method - either direct IAM credentials or cross-account role assumption.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authenticationPlan", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.AWSIAMCredentialsAuthenticationPlan, global::G.AWSStsAuthenticationPlan> AuthenticationPlan { get; set; } = default!;

        /// <summary>
        /// This is the name of credential. This is just for your reference.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAnthropicBedrockCredentialDTO" /> class.
        /// </summary>
        /// <param name="region">
        /// AWS region where Bedrock is configured.
        /// </param>
        /// <param name="authenticationPlan">
        /// Authentication method - either direct IAM credentials or cross-account role assumption.
        /// </param>
        /// <param name="provider"></param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
        public CreateAnthropicBedrockCredentialDTO(
            global::G.CreateAnthropicBedrockCredentialDTORegion region,
            global::G.OneOf<global::G.AWSIAMCredentialsAuthenticationPlan, global::G.AWSStsAuthenticationPlan> authenticationPlan,
            global::G.CreateAnthropicBedrockCredentialDTOProvider provider,
            string? name)
        {
            this.Provider = provider;
            this.Region = region;
            this.AuthenticationPlan = authenticationPlan;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAnthropicBedrockCredentialDTO" /> class.
        /// </summary>
        public CreateAnthropicBedrockCredentialDTO()
        {
        }
    }
}