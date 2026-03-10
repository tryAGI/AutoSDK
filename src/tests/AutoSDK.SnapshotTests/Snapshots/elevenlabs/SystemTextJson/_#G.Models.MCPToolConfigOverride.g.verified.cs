//HintName: G.Models.MCPToolConfigOverride.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MCPToolConfigOverride
    {
        /// <summary>
        /// The name of the MCP tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        /// If set, overrides the server's force_pre_tool_speech setting for this tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force_pre_tool_speech")]
        public bool? ForcePreToolSpeech { get; set; }

        /// <summary>
        /// If set, overrides the server's disable_interruptions setting for this tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_interruptions")]
        public bool? DisableInterruptions { get; set; }

        /// <summary>
        /// If set, overrides the server's tool_call_sound setting for this tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_sound")]
        public global::G.ToolCallSoundType? ToolCallSound { get; set; }

        /// <summary>
        /// If set, overrides the server's tool_call_sound_behavior setting for this tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_sound_behavior")]
        public global::G.ToolCallSoundBehavior? ToolCallSoundBehavior { get; set; }

        /// <summary>
        /// If set, overrides the server's execution_mode setting for this tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_mode")]
        public global::G.ToolExecutionMode? ExecutionMode { get; set; }

        /// <summary>
        /// Dynamic variable assignments for this MCP tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignments")]
        public global::System.Collections.Generic.IList<global::G.DynamicVariableAssignment>? Assignments { get; set; }

        /// <summary>
        /// Mapping of json path to input override configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_overrides")]
        public object? InputOverrides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolConfigOverride" /> class.
        /// </summary>
        /// <param name="toolName">
        /// The name of the MCP tool
        /// </param>
        /// <param name="forcePreToolSpeech">
        /// If set, overrides the server's force_pre_tool_speech setting for this tool
        /// </param>
        /// <param name="disableInterruptions">
        /// If set, overrides the server's disable_interruptions setting for this tool
        /// </param>
        /// <param name="toolCallSound">
        /// If set, overrides the server's tool_call_sound setting for this tool
        /// </param>
        /// <param name="toolCallSoundBehavior">
        /// If set, overrides the server's tool_call_sound_behavior setting for this tool
        /// </param>
        /// <param name="executionMode">
        /// If set, overrides the server's execution_mode setting for this tool
        /// </param>
        /// <param name="assignments">
        /// Dynamic variable assignments for this MCP tool
        /// </param>
        /// <param name="inputOverrides">
        /// Mapping of json path to input override configuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPToolConfigOverride(
            string toolName,
            bool? forcePreToolSpeech,
            bool? disableInterruptions,
            global::G.ToolCallSoundType? toolCallSound,
            global::G.ToolCallSoundBehavior? toolCallSoundBehavior,
            global::G.ToolExecutionMode? executionMode,
            global::System.Collections.Generic.IList<global::G.DynamicVariableAssignment>? assignments,
            object? inputOverrides)
        {
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.ForcePreToolSpeech = forcePreToolSpeech;
            this.DisableInterruptions = disableInterruptions;
            this.ToolCallSound = toolCallSound;
            this.ToolCallSoundBehavior = toolCallSoundBehavior;
            this.ExecutionMode = executionMode;
            this.Assignments = assignments;
            this.InputOverrides = inputOverrides;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolConfigOverride" /> class.
        /// </summary>
        public MCPToolConfigOverride()
        {
        }
    }
}