//HintName: G.Models.TemplatesGetTemplateSnapshotResponseAgentProperties.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TemplatesGetTemplateSnapshotResponseAgentProperties
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_reasoner")]
        public bool? EnableReasoner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("put_inner_thoughts_in_kwargs")]
        public bool? PutInnerThoughtsInKwargs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_window_limit")]
        public double? ContextWindowLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public double? MaxTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_reasoning_tokens")]
        public double? MaxReasoningTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_files_open")]
        public double? MaxFilesOpen { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_buffer_autoclear")]
        public bool? MessageBufferAutoclear { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verbosity_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentPropertiesVerbosityLevelJsonConverter))]
        public global::G.TemplatesGetTemplateSnapshotResponseAgentPropertiesVerbosityLevel? VerbosityLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentPropertiesReasoningEffortJsonConverter))]
        public global::G.TemplatesGetTemplateSnapshotResponseAgentPropertiesReasoningEffort? ReasoningEffort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("per_file_view_window_char_limit")]
        public double? PerFileViewWindowCharLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesGetTemplateSnapshotResponseAgentProperties" /> class.
        /// </summary>
        /// <param name="enableReasoner"></param>
        /// <param name="putInnerThoughtsInKwargs"></param>
        /// <param name="contextWindowLimit"></param>
        /// <param name="maxTokens"></param>
        /// <param name="maxReasoningTokens"></param>
        /// <param name="maxFilesOpen"></param>
        /// <param name="messageBufferAutoclear"></param>
        /// <param name="verbosityLevel"></param>
        /// <param name="reasoningEffort"></param>
        /// <param name="perFileViewWindowCharLimit"></param>
        /// <param name="parallelToolCalls"></param>
        /// <param name="temperature"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplatesGetTemplateSnapshotResponseAgentProperties(
            bool? enableReasoner,
            bool? putInnerThoughtsInKwargs,
            double? contextWindowLimit,
            double? maxTokens,
            double? maxReasoningTokens,
            double? maxFilesOpen,
            bool? messageBufferAutoclear,
            global::G.TemplatesGetTemplateSnapshotResponseAgentPropertiesVerbosityLevel? verbosityLevel,
            global::G.TemplatesGetTemplateSnapshotResponseAgentPropertiesReasoningEffort? reasoningEffort,
            double? perFileViewWindowCharLimit,
            bool? parallelToolCalls,
            double? temperature)
        {
            this.EnableReasoner = enableReasoner;
            this.PutInnerThoughtsInKwargs = putInnerThoughtsInKwargs;
            this.ContextWindowLimit = contextWindowLimit;
            this.MaxTokens = maxTokens;
            this.MaxReasoningTokens = maxReasoningTokens;
            this.MaxFilesOpen = maxFilesOpen;
            this.MessageBufferAutoclear = messageBufferAutoclear;
            this.VerbosityLevel = verbosityLevel;
            this.ReasoningEffort = reasoningEffort;
            this.PerFileViewWindowCharLimit = perFileViewWindowCharLimit;
            this.ParallelToolCalls = parallelToolCalls;
            this.Temperature = temperature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesGetTemplateSnapshotResponseAgentProperties" /> class.
        /// </summary>
        public TemplatesGetTemplateSnapshotResponseAgentProperties()
        {
        }
    }
}