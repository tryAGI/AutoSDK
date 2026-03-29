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
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_configurations")]
        public global::System.Collections.Generic.IList<global::G.WebhookConfiguration>? WebhookConfigurations { get; set; }

        /// <summary>
        /// File ID or Parse Job ID to extract from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_input_value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DocumentInputValue { get; set; }

        /// <summary>
        /// Saved extract configuration ID (mutually exclusive with configuration)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration_id")]
        public string? ConfigurationId { get; set; }

        /// <summary>
        /// Inline configuration with extract options and optional parse settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        public global::G.ExtractConfiguration? Configuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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