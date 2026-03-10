//HintName: G.Models.ApiIntegrationWebhookToolConfigInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiIntegrationWebhookToolConfigInput
    {
        /// <summary>
        /// Default Value: api_integration_webhook
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Description of when the tool should be used and what it does.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// The maximum time in seconds to wait for the tool call to complete. Must be between 5 and 120 seconds (inclusive).<br/>
        /// Default Value: 20
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_timeout_secs")]
        public int? ResponseTimeoutSecs { get; set; }

        /// <summary>
        /// If true, the user will not be able to interrupt the agent while this tool is running.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disable_interruptions")]
        public bool? DisableInterruptions { get; set; }

        /// <summary>
        /// If true, the agent will speak before the tool call.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("force_pre_tool_speech")]
        public bool? ForcePreToolSpeech { get; set; }

        /// <summary>
        /// Configuration for extracting values from tool responses and assigning them to dynamic variables
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assignments")]
        public global::System.Collections.Generic.IList<global::G.DynamicVariableAssignment>? Assignments { get; set; }

        /// <summary>
        /// Predefined tool call sound type to play during tool execution. If not specified, no tool call sound will be played.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_sound")]
        public global::G.ToolCallSoundType? ToolCallSound { get; set; }

        /// <summary>
        /// Determines when the tool call sound should play. 'auto' only plays when there's pre-tool speech, 'always' plays for every tool call.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_call_sound_behavior")]
        public global::G.ToolCallSoundBehavior? ToolCallSoundBehavior { get; set; }

        /// <summary>
        /// Controls how tool errors are processed before being shared with the agent. 'auto' determines handling based on tool type (summarized for native integrations, hide for others), 'summarized' sends an LLM-generated summary, 'passthrough' sends the raw error, 'hide' does not share the error with the agent.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_error_handling_mode")]
        public global::G.ToolErrorHandlingMode? ToolErrorHandlingMode { get; set; }

        /// <summary>
        /// Configuration for dynamic variables<br/>
        /// Example: {"dynamic_variable_placeholders":{"user_name":"John Doe"}}
        /// </summary>
        /// <example>{"dynamic_variable_placeholders":{"user_name":"John Doe"}}</example>
        [global::Newtonsoft.Json.JsonProperty("dynamic_variables")]
        public global::G.DynamicVariablesConfig? DynamicVariables { get; set; }

        /// <summary>
        /// Determines when and how the tool executes: 'immediate' executes the tool right away when requested by the LLM, 'post_tool_speech' waits for the agent to finish speaking before executing, 'async' runs the tool in the background without blocking - best for long-running operations.<br/>
        /// Default Value: immediate
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("execution_mode")]
        public global::G.ToolExecutionMode? ExecutionMode { get; set; }

        /// <summary>
        /// The version of the API integration tool<br/>
        /// Default Value: 1.0.0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_version")]
        public string? ToolVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_integration_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApiIntegrationId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_integration_connection_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApiIntegrationConnectionId { get; set; } = default!;

        /// <summary>
        /// User overrides applied on top of the base api_schema
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_schema_overrides")]
        public global::G.ApiIntegrationWebhookOverridesInput? ApiSchemaOverrides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiIntegrationWebhookToolConfigInput" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: api_integration_webhook
        /// </param>
        /// <param name="name"></param>
        /// <param name="description">
        /// Description of when the tool should be used and what it does.
        /// </param>
        /// <param name="responseTimeoutSecs">
        /// The maximum time in seconds to wait for the tool call to complete. Must be between 5 and 120 seconds (inclusive).<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="disableInterruptions">
        /// If true, the user will not be able to interrupt the agent while this tool is running.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="forcePreToolSpeech">
        /// If true, the agent will speak before the tool call.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="assignments">
        /// Configuration for extracting values from tool responses and assigning them to dynamic variables
        /// </param>
        /// <param name="toolCallSound">
        /// Predefined tool call sound type to play during tool execution. If not specified, no tool call sound will be played.
        /// </param>
        /// <param name="toolCallSoundBehavior">
        /// Determines when the tool call sound should play. 'auto' only plays when there's pre-tool speech, 'always' plays for every tool call.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="toolErrorHandlingMode">
        /// Controls how tool errors are processed before being shared with the agent. 'auto' determines handling based on tool type (summarized for native integrations, hide for others), 'summarized' sends an LLM-generated summary, 'passthrough' sends the raw error, 'hide' does not share the error with the agent.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="dynamicVariables">
        /// Configuration for dynamic variables<br/>
        /// Example: {"dynamic_variable_placeholders":{"user_name":"John Doe"}}
        /// </param>
        /// <param name="executionMode">
        /// Determines when and how the tool executes: 'immediate' executes the tool right away when requested by the LLM, 'post_tool_speech' waits for the agent to finish speaking before executing, 'async' runs the tool in the background without blocking - best for long-running operations.<br/>
        /// Default Value: immediate
        /// </param>
        /// <param name="toolVersion">
        /// The version of the API integration tool<br/>
        /// Default Value: 1.0.0
        /// </param>
        /// <param name="apiIntegrationId"></param>
        /// <param name="apiIntegrationConnectionId"></param>
        /// <param name="apiSchemaOverrides">
        /// User overrides applied on top of the base api_schema
        /// </param>
        public ApiIntegrationWebhookToolConfigInput(
            string name,
            string description,
            string apiIntegrationId,
            string apiIntegrationConnectionId,
            string? type,
            int? responseTimeoutSecs,
            bool? disableInterruptions,
            bool? forcePreToolSpeech,
            global::System.Collections.Generic.IList<global::G.DynamicVariableAssignment>? assignments,
            global::G.ToolCallSoundType? toolCallSound,
            global::G.ToolCallSoundBehavior? toolCallSoundBehavior,
            global::G.ToolErrorHandlingMode? toolErrorHandlingMode,
            global::G.DynamicVariablesConfig? dynamicVariables,
            global::G.ToolExecutionMode? executionMode,
            string? toolVersion,
            global::G.ApiIntegrationWebhookOverridesInput? apiSchemaOverrides)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ApiIntegrationId = apiIntegrationId ?? throw new global::System.ArgumentNullException(nameof(apiIntegrationId));
            this.ApiIntegrationConnectionId = apiIntegrationConnectionId ?? throw new global::System.ArgumentNullException(nameof(apiIntegrationConnectionId));
            this.Type = type;
            this.ResponseTimeoutSecs = responseTimeoutSecs;
            this.DisableInterruptions = disableInterruptions;
            this.ForcePreToolSpeech = forcePreToolSpeech;
            this.Assignments = assignments;
            this.ToolCallSound = toolCallSound;
            this.ToolCallSoundBehavior = toolCallSoundBehavior;
            this.ToolErrorHandlingMode = toolErrorHandlingMode;
            this.DynamicVariables = dynamicVariables;
            this.ExecutionMode = executionMode;
            this.ToolVersion = toolVersion;
            this.ApiSchemaOverrides = apiSchemaOverrides;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiIntegrationWebhookToolConfigInput" /> class.
        /// </summary>
        public ApiIntegrationWebhookToolConfigInput()
        {
        }
    }
}