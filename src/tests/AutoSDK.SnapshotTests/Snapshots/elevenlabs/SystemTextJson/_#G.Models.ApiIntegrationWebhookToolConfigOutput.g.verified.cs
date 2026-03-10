//HintName: G.Models.ApiIntegrationWebhookToolConfigOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiIntegrationWebhookToolConfigOutput
    {
        /// <summary>
        /// Default Value: api_integration_webhook
        /// </summary>
        /// <default>"api_integration_webhook"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "api_integration_webhook";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of when the tool should be used and what it does.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The maximum time in seconds to wait for the tool call to complete. Must be between 5 and 120 seconds (inclusive).<br/>
        /// Default Value: 20
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_timeout_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ResponseTimeoutSecs { get; set; }

        /// <summary>
        /// If true, the user will not be able to interrupt the agent while this tool is running.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_interruptions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool DisableInterruptions { get; set; }

        /// <summary>
        /// If true, the agent will speak before the tool call.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force_pre_tool_speech")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ForcePreToolSpeech { get; set; }

        /// <summary>
        /// Configuration for extracting values from tool responses and assigning them to dynamic variables
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.DynamicVariableAssignment> Assignments { get; set; }

        /// <summary>
        /// Predefined tool call sound type to play during tool execution. If not specified, no tool call sound will be played.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_sound")]
        public global::G.ToolCallSoundType? ToolCallSound { get; set; }

        /// <summary>
        /// Determines when the tool call sound should play. 'auto' only plays when there's pre-tool speech, 'always' plays for every tool call.<br/>
        /// Default Value: auto
        /// </summary>
        /// <default>global::G.ToolCallSoundBehavior.Auto</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_sound_behavior")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ToolCallSoundBehaviorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ToolCallSoundBehavior ToolCallSoundBehavior { get; set; } = global::G.ToolCallSoundBehavior.Auto;

        /// <summary>
        /// Controls how tool errors are processed before being shared with the agent. 'auto' determines handling based on tool type (summarized for native integrations, hide for others), 'summarized' sends an LLM-generated summary, 'passthrough' sends the raw error, 'hide' does not share the error with the agent.<br/>
        /// Default Value: auto
        /// </summary>
        /// <default>global::G.ToolErrorHandlingMode.Auto</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_error_handling_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ToolErrorHandlingModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ToolErrorHandlingMode ToolErrorHandlingMode { get; set; } = global::G.ToolErrorHandlingMode.Auto;

        /// <summary>
        /// Configuration for dynamic variables<br/>
        /// Example: {"dynamic_variable_placeholders":{"user_name":"John Doe"}}
        /// </summary>
        /// <example>{"dynamic_variable_placeholders":{"user_name":"John Doe"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DynamicVariablesConfig DynamicVariables { get; set; }

        /// <summary>
        /// Determines when and how the tool executes: 'immediate' executes the tool right away when requested by the LLM, 'post_tool_speech' waits for the agent to finish speaking before executing, 'async' runs the tool in the background without blocking - best for long-running operations.<br/>
        /// Default Value: immediate
        /// </summary>
        /// <default>global::G.ToolExecutionMode.Immediate</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ToolExecutionModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ToolExecutionMode ExecutionMode { get; set; } = global::G.ToolExecutionMode.Immediate;

        /// <summary>
        /// The version of the API integration tool<br/>
        /// Default Value: 1.0.0
        /// </summary>
        /// <default>"1.0.0"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolVersion { get; set; } = "1.0.0";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_integration_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiIntegrationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_integration_connection_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiIntegrationConnectionId { get; set; }

        /// <summary>
        /// User overrides applied on top of the base api_schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_schema_overrides")]
        public global::G.ApiIntegrationWebhookOverridesOutput? ApiSchemaOverrides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiIntegrationWebhookToolConfigOutput" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiIntegrationWebhookToolConfigOutput(
            string name,
            string description,
            int responseTimeoutSecs,
            bool disableInterruptions,
            bool forcePreToolSpeech,
            global::System.Collections.Generic.IList<global::G.DynamicVariableAssignment> assignments,
            global::G.ToolCallSoundBehavior toolCallSoundBehavior,
            global::G.ToolErrorHandlingMode toolErrorHandlingMode,
            global::G.DynamicVariablesConfig dynamicVariables,
            global::G.ToolExecutionMode executionMode,
            string toolVersion,
            string apiIntegrationId,
            string apiIntegrationConnectionId,
            global::G.ToolCallSoundType? toolCallSound,
            global::G.ApiIntegrationWebhookOverridesOutput? apiSchemaOverrides,
            string type = "api_integration_webhook")
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ResponseTimeoutSecs = responseTimeoutSecs;
            this.DisableInterruptions = disableInterruptions;
            this.ForcePreToolSpeech = forcePreToolSpeech;
            this.Assignments = assignments ?? throw new global::System.ArgumentNullException(nameof(assignments));
            this.ToolCallSoundBehavior = toolCallSoundBehavior;
            this.ToolErrorHandlingMode = toolErrorHandlingMode;
            this.DynamicVariables = dynamicVariables ?? throw new global::System.ArgumentNullException(nameof(dynamicVariables));
            this.ExecutionMode = executionMode;
            this.ToolVersion = toolVersion ?? throw new global::System.ArgumentNullException(nameof(toolVersion));
            this.ApiIntegrationId = apiIntegrationId ?? throw new global::System.ArgumentNullException(nameof(apiIntegrationId));
            this.ApiIntegrationConnectionId = apiIntegrationConnectionId ?? throw new global::System.ArgumentNullException(nameof(apiIntegrationConnectionId));
            this.Type = type;
            this.ToolCallSound = toolCallSound;
            this.ApiSchemaOverrides = apiSchemaOverrides;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiIntegrationWebhookToolConfigOutput" /> class.
        /// </summary>
        public ApiIntegrationWebhookToolConfigOutput()
        {
        }
    }
}