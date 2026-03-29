//HintName: G.Models.PromptBlueprint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptBlueprint
    {
        /// <summary>
        /// The prompt template. Either a CompletionPrompt (type: 'completion') or ChatPrompt (type: 'chat').
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_template", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PromptTemplate5 PromptTemplate { get; set; } = default!;

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_message")]
        public string? CommitMessage { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.Metadata? Metadata { get; set; }

        /// <summary>
        /// Name of the custom provider base URL configuration.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_base_url_name")]
        public string? ProviderBaseUrlName { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("report_id")]
        public int? ReportId { get; set; }

        /// <summary>
        /// Name of the inference client to use.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inference_client_name")]
        public string? InferenceClientName { get; set; }

        /// <summary>
        /// ID of the provider configuration to use.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_id")]
        public int? ProviderId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptBlueprint" /> class.
        /// </summary>
        /// <param name="promptTemplate">
        /// The prompt template. Either a CompletionPrompt (type: 'completion') or ChatPrompt (type: 'chat').
        /// </param>
        /// <param name="commitMessage">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="metadata">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="providerBaseUrlName">
        /// Name of the custom provider base URL configuration.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="reportId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="inferenceClientName">
        /// Name of the inference client to use.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="providerId">
        /// ID of the provider configuration to use.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        public PromptBlueprint(
            global::G.PromptTemplate5 promptTemplate,
            string? commitMessage,
            global::G.Metadata? metadata,
            string? providerBaseUrlName,
            int? reportId,
            string? inferenceClientName,
            int? providerId)
        {
            this.PromptTemplate = promptTemplate;
            this.CommitMessage = commitMessage;
            this.Metadata = metadata;
            this.ProviderBaseUrlName = providerBaseUrlName;
            this.ReportId = reportId;
            this.InferenceClientName = inferenceClientName;
            this.ProviderId = providerId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptBlueprint" /> class.
        /// </summary>
        public PromptBlueprint()
        {
        }
    }
}