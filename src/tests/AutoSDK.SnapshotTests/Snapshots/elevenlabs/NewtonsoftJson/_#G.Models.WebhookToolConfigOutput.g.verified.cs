//HintName: G.Models.WebhookToolConfigOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A webhook tool is a tool that calls an external webhook from our server<br/>
    /// Example: {"response_timeout_secs":20,"type":"webhook"}
    /// </summary>
    public sealed partial class WebhookToolConfigOutput
    {
        /// <summary>
        /// The type of tool<br/>
        /// Default Value: webhook
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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ToolCallSoundBehaviorJsonConverter))]
        public global::G.ToolCallSoundBehavior? ToolCallSoundBehavior { get; set; }

        /// <summary>
        /// Controls how tool errors are processed before being shared with the agent. 'auto' determines handling based on tool type (summarized for native integrations, hide for others), 'summarized' sends an LLM-generated summary, 'passthrough' sends the raw error, 'hide' does not share the error with the agent.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_error_handling_mode")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ToolErrorHandlingModeJsonConverter))]
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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ToolExecutionModeJsonConverter))]
        public global::G.ToolExecutionMode? ExecutionMode { get; set; }

        /// <summary>
        /// The schema for the outgoing webhoook, including parameters and URL specification<br/>
        /// Example: {"method":"GET","path_params_schema":{"agent_id":{"type":"string"}},"query_params_schema":{"param1":{"type":"string"}},"request_body_schema":{"param1":{"type":"string"}},"request_headers":{"Authorization":"Bearer {api_key}"},"url":"https://example.com/agents/{agent_id}"}
        /// </summary>
        /// <example>{"method":"GET","path_params_schema":{"agent_id":{"type":"string"}},"query_params_schema":{"param1":{"type":"string"}},"request_body_schema":{"param1":{"type":"string"}},"request_headers":{"Authorization":"Bearer {api_key}"},"url":"https://example.com/agents/{agent_id}"}</example>
        [global::Newtonsoft.Json.JsonProperty("api_schema", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookToolApiSchemaConfigOutput ApiSchema { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookToolConfigOutput" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description">
        /// Description of when the tool should be used and what it does.
        /// </param>
        /// <param name="apiSchema">
        /// The schema for the outgoing webhoook, including parameters and URL specification<br/>
        /// Example: {"method":"GET","path_params_schema":{"agent_id":{"type":"string"}},"query_params_schema":{"param1":{"type":"string"}},"request_body_schema":{"param1":{"type":"string"}},"request_headers":{"Authorization":"Bearer {api_key}"},"url":"https://example.com/agents/{agent_id}"}
        /// </param>
        /// <param name="type">
        /// The type of tool<br/>
        /// Default Value: webhook
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
        public WebhookToolConfigOutput(
            string name,
            string description,
            global::G.WebhookToolApiSchemaConfigOutput apiSchema,
            string? type,
            int? responseTimeoutSecs,
            bool? disableInterruptions,
            bool? forcePreToolSpeech,
            global::System.Collections.Generic.IList<global::G.DynamicVariableAssignment>? assignments,
            global::G.ToolCallSoundType? toolCallSound,
            global::G.ToolCallSoundBehavior? toolCallSoundBehavior,
            global::G.ToolErrorHandlingMode? toolErrorHandlingMode,
            global::G.DynamicVariablesConfig? dynamicVariables,
            global::G.ToolExecutionMode? executionMode)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ResponseTimeoutSecs = responseTimeoutSecs;
            this.DisableInterruptions = disableInterruptions;
            this.ForcePreToolSpeech = forcePreToolSpeech;
            this.Assignments = assignments;
            this.ToolCallSound = toolCallSound;
            this.ToolCallSoundBehavior = toolCallSoundBehavior;
            this.ToolErrorHandlingMode = toolErrorHandlingMode;
            this.DynamicVariables = dynamicVariables;
            this.ExecutionMode = executionMode;
            this.ApiSchema = apiSchema ?? throw new global::System.ArgumentNullException(nameof(apiSchema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookToolConfigOutput" /> class.
        /// </summary>
        public WebhookToolConfigOutput()
        {
        }
    }
}