//HintName: G.Models.LangfuseObservabilityPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LangfuseObservabilityPlan
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LangfuseObservabilityPlanProviderJsonConverter))]
        public global::G.LangfuseObservabilityPlanProvider Provider { get; set; }

        /// <summary>
        /// The name of a Langfuse prompt to link generations to. This enables tracking which prompt version was used for each generation. https://langfuse.com/docs/prompt-management/features/link-to-traces
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptName")]
        public string? PromptName { get; set; }

        /// <summary>
        /// The version number of the Langfuse prompt to link generations to. Used together with promptName to identify the exact prompt version. https://langfuse.com/docs/prompt-management/features/link-to-traces
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptVersion")]
        public double? PromptVersion { get; set; }

        /// <summary>
        /// Custom name for the Langfuse trace. Supports Liquid templates.<br/>
        /// Available variables:<br/>
        /// - {{ call.id }} - Call UUID<br/>
        /// - {{ call.type }} - 'inboundPhoneCall', 'outboundPhoneCall', 'webCall'<br/>
        /// - {{ assistant.name }} - Assistant name<br/>
        /// - {{ assistant.id }} - Assistant ID<br/>
        /// Example: "{{ assistant.name }} - {{ call.type }}"<br/>
        /// Defaults to call ID if not provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traceName")]
        public string? TraceName { get; set; }

        /// <summary>
        /// This is an array of tags to be added to the Langfuse trace. Tags allow you to categorize and filter traces. https://langfuse.com/docs/tracing-features/tags
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// This is a JSON object that will be added to the Langfuse trace. Traces can be enriched with metadata to better understand your users, application, and experiments. https://langfuse.com/docs/tracing-features/metadata<br/>
        /// By default it includes the call metadata, assistant metadata, and assistant overrides.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LangfuseObservabilityPlan" /> class.
        /// </summary>
        /// <param name="tags">
        /// This is an array of tags to be added to the Langfuse trace. Tags allow you to categorize and filter traces. https://langfuse.com/docs/tracing-features/tags
        /// </param>
        /// <param name="provider"></param>
        /// <param name="promptName">
        /// The name of a Langfuse prompt to link generations to. This enables tracking which prompt version was used for each generation. https://langfuse.com/docs/prompt-management/features/link-to-traces
        /// </param>
        /// <param name="promptVersion">
        /// The version number of the Langfuse prompt to link generations to. Used together with promptName to identify the exact prompt version. https://langfuse.com/docs/prompt-management/features/link-to-traces
        /// </param>
        /// <param name="traceName">
        /// Custom name for the Langfuse trace. Supports Liquid templates.<br/>
        /// Available variables:<br/>
        /// - {{ call.id }} - Call UUID<br/>
        /// - {{ call.type }} - 'inboundPhoneCall', 'outboundPhoneCall', 'webCall'<br/>
        /// - {{ assistant.name }} - Assistant name<br/>
        /// - {{ assistant.id }} - Assistant ID<br/>
        /// Example: "{{ assistant.name }} - {{ call.type }}"<br/>
        /// Defaults to call ID if not provided.
        /// </param>
        /// <param name="metadata">
        /// This is a JSON object that will be added to the Langfuse trace. Traces can be enriched with metadata to better understand your users, application, and experiments. https://langfuse.com/docs/tracing-features/metadata<br/>
        /// By default it includes the call metadata, assistant metadata, and assistant overrides.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LangfuseObservabilityPlan(
            global::System.Collections.Generic.IList<string> tags,
            global::G.LangfuseObservabilityPlanProvider provider,
            string? promptName,
            double? promptVersion,
            string? traceName,
            object? metadata)
        {
            this.Provider = provider;
            this.PromptName = promptName;
            this.PromptVersion = promptVersion;
            this.TraceName = traceName;
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LangfuseObservabilityPlan" /> class.
        /// </summary>
        public LangfuseObservabilityPlan()
        {
        }
    }
}