//HintName: G.Models.ClassifyJobCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A classify job.
    /// </summary>
    public sealed partial class ClassifyJobCreate
    {
        /// <summary>
        /// The rules to classify the files
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rules", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ClassifierRule> Rules { get; set; } = default!;

        /// <summary>
        /// The classification mode to use<br/>
        /// Default Value: FAST
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mode")]
        public global::G.ClassifyMode? Mode { get; set; }

        /// <summary>
        /// The IDs of the files to classify
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> FileIds { get; set; } = default!;

        /// <summary>
        /// The configuration for the parsing job<br/>
        /// Default Value: {"lang":"en","max_pages":5}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parsing_configuration")]
        public global::G.ClassifyParsingConfiguration? ParsingConfiguration { get; set; }

        /// <summary>
        /// List of webhook configurations for notifications
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook_configurations")]
        public global::System.Collections.Generic.IList<global::G.LlamaParseWebhookConfiguration>? WebhookConfigurations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyJobCreate" /> class.
        /// </summary>
        /// <param name="rules">
        /// The rules to classify the files
        /// </param>
        /// <param name="fileIds">
        /// The IDs of the files to classify
        /// </param>
        /// <param name="mode">
        /// The classification mode to use<br/>
        /// Default Value: FAST
        /// </param>
        /// <param name="parsingConfiguration">
        /// The configuration for the parsing job<br/>
        /// Default Value: {"lang":"en","max_pages":5}
        /// </param>
        /// <param name="webhookConfigurations">
        /// List of webhook configurations for notifications
        /// </param>
        public ClassifyJobCreate(
            global::System.Collections.Generic.IList<global::G.ClassifierRule> rules,
            global::System.Collections.Generic.IList<global::System.Guid> fileIds,
            global::G.ClassifyMode? mode,
            global::G.ClassifyParsingConfiguration? parsingConfiguration,
            global::System.Collections.Generic.IList<global::G.LlamaParseWebhookConfiguration>? webhookConfigurations)
        {
            this.Rules = rules ?? throw new global::System.ArgumentNullException(nameof(rules));
            this.Mode = mode;
            this.FileIds = fileIds ?? throw new global::System.ArgumentNullException(nameof(fileIds));
            this.ParsingConfiguration = parsingConfiguration;
            this.WebhookConfigurations = webhookConfigurations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifyJobCreate" /> class.
        /// </summary>
        public ClassifyJobCreate()
        {
        }
    }
}