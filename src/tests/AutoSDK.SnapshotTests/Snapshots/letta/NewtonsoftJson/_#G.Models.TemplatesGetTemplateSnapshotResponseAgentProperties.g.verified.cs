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
        [global::Newtonsoft.Json.JsonProperty("enable_reasoner")]
        public bool? EnableReasoner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("put_inner_thoughts_in_kwargs")]
        public bool? PutInnerThoughtsInKwargs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context_window_limit")]
        public double? ContextWindowLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_tokens")]
        public double? MaxTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_reasoning_tokens")]
        public double? MaxReasoningTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_files_open")]
        public double? MaxFilesOpen { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message_buffer_autoclear")]
        public bool? MessageBufferAutoclear { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("verbosity_level")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentPropertiesVerbosityLevelJsonConverter))]
        public global::G.TemplatesGetTemplateSnapshotResponseAgentPropertiesVerbosityLevel? VerbosityLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning_effort")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentPropertiesReasoningEffortJsonConverter))]
        public global::G.TemplatesGetTemplateSnapshotResponseAgentPropertiesReasoningEffort? ReasoningEffort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("per_file_view_window_char_limit")]
        public double? PerFileViewWindowCharLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temperature")]
        public double? Temperature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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