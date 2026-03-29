//HintName: G.Models.ExtractV2JobCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to create an extraction job. Provide configuration_id or inline configuration.
    /// </summary>
    public sealed partial class ExtractV2JobCreate
    {
        /// <summary>
        /// Outbound webhook endpoints to notify on job status changes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook_configurations")]
        public global::System.Collections.Generic.IList<global::G.WebhookConfiguration>? WebhookConfigurations { get; set; }

        /// <summary>
        /// File ID or Parse Job ID to extract from
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document_input_value", Required = global::Newtonsoft.Json.Required.Always)]
        public string DocumentInputValue { get; set; } = default!;

        /// <summary>
        /// Saved extract configuration ID (mutually exclusive with configuration)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("configuration_id")]
        public string? ConfigurationId { get; set; }

        /// <summary>
        /// Inline configuration with extract options and optional parse settings
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("configuration")]
        public global::G.ExtractConfiguration? Configuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractV2JobCreate" /> class.
        /// </summary>
        /// <param name="documentInputValue">
        /// File ID or Parse Job ID to extract from
        /// </param>
        /// <param name="webhookConfigurations">
        /// Outbound webhook endpoints to notify on job status changes
        /// </param>
        /// <param name="configurationId">
        /// Saved extract configuration ID (mutually exclusive with configuration)
        /// </param>
        /// <param name="configuration">
        /// Inline configuration with extract options and optional parse settings
        /// </param>
        public ExtractV2JobCreate(
            string documentInputValue,
            global::System.Collections.Generic.IList<global::G.WebhookConfiguration>? webhookConfigurations,
            string? configurationId,
            global::G.ExtractConfiguration? configuration)
        {
            this.WebhookConfigurations = webhookConfigurations;
            this.DocumentInputValue = documentInputValue ?? throw new global::System.ArgumentNullException(nameof(documentInputValue));
            this.ConfigurationId = configurationId;
            this.Configuration = configuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractV2JobCreate" /> class.
        /// </summary>
        public ExtractV2JobCreate()
        {
        }
    }
}