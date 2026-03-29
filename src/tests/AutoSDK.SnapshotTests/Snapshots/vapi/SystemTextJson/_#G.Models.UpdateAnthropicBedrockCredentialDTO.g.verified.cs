//HintName: G.Models.UpdateAnthropicBedrockCredentialDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAnthropicBedrockCredentialDTO
    {
        /// <summary>
        /// AWS region where Bedrock is configured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UpdateAnthropicBedrockCredentialDTORegionJsonConverter))]
        public global::G.UpdateAnthropicBedrockCredentialDTORegion? Region { get; set; }

        /// <summary>
        /// Authentication method - either direct IAM credentials or cross-account role assumption.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authenticationPlan")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.AWSIAMCredentialsAuthenticationPlan, global::G.AWSStsAuthenticationPlan>))]
        public global::G.OneOf<global::G.AWSIAMCredentialsAuthenticationPlan, global::G.AWSStsAuthenticationPlan>? AuthenticationPlan { get; set; }

        /// <summary>
        /// This is the name of credential. This is just for your reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAnthropicBedrockCredentialDTO" /> class.
        /// </summary>
        /// <param name="region">
        /// AWS region where Bedrock is configured.
        /// </param>
        /// <param name="authenticationPlan">
        /// Authentication method - either direct IAM credentials or cross-account role assumption.
        /// </param>
        /// <param name="name">
        /// This is the name of credential. This is just for your reference.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAnthropicBedrockCredentialDTO(
            global::G.UpdateAnthropicBedrockCredentialDTORegion? region,
            global::G.OneOf<global::G.AWSIAMCredentialsAuthenticationPlan, global::G.AWSStsAuthenticationPlan>? authenticationPlan,
            string? name)
        {
            this.Region = region;
            this.AuthenticationPlan = authenticationPlan;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAnthropicBedrockCredentialDTO" /> class.
        /// </summary>
        public UpdateAnthropicBedrockCredentialDTO()
        {
        }
    }
}