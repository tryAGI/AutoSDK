//HintName: G.Models.UltravoxV1SelectedTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A tool selected for a particular call. Exactly one of tool_id, tool_name, or<br/>
    ///  temporary_tool should be set.
    /// </summary>
    public sealed partial class UltravoxV1SelectedTool
    {
        /// <summary>
        /// The ID of an existing base tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toolId")]
        public string? ToolId { get; set; }

        /// <summary>
        /// The name of an existing base tool. The name must uniquely identify the tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toolName")]
        public string? ToolName { get; set; }

        /// <summary>
        /// A temporary tool definition, available only for this call (and subsequent<br/>
        ///  calls created using priorCallId without overriding selected tools).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("temporaryTool")]
        public global::G.UltravoxV1BaseToolDefinition? TemporaryTool { get; set; }

        /// <summary>
        /// An override for the model_tool_name. This is primarily useful when using<br/>
        ///  multiple instances of the same durable tool (presumably with different<br/>
        ///  parameter overrides.) The set of tools used within a call must have a unique<br/>
        ///  set of model names and every name must match this pattern: ^[a-zA-Z0-9_-]{1,64}$.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nameOverride")]
        public string? NameOverride { get; set; }

        /// <summary>
        /// Auth tokens used to satisfy the tool's security requirements.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authTokens")]
        public global::System.Collections.Generic.Dictionary<string, string>? AuthTokens { get; set; }

        /// <summary>
        /// Static values to use in place of dynamic parameters. Any parameter included<br/>
        ///  here will be hidden from the model and the static value will be used instead.<br/>
        ///  Some tools may require certain parameters to be overridden, but any parameter<br/>
        ///  can be overridden regardless of whether it is required to be.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameterOverrides")]
        public object? ParameterOverrides { get; set; }

        /// <summary>
        /// For internal use. Relates this tool to a stage transition definition within a call template for attribution.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transitionId")]
        public string? TransitionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1SelectedTool" /> class.
        /// </summary>
        /// <param name="toolId">
        /// The ID of an existing base tool.
        /// </param>
        /// <param name="toolName">
        /// The name of an existing base tool. The name must uniquely identify the tool.
        /// </param>
        /// <param name="temporaryTool">
        /// A temporary tool definition, available only for this call (and subsequent<br/>
        ///  calls created using priorCallId without overriding selected tools).
        /// </param>
        /// <param name="nameOverride">
        /// An override for the model_tool_name. This is primarily useful when using<br/>
        ///  multiple instances of the same durable tool (presumably with different<br/>
        ///  parameter overrides.) The set of tools used within a call must have a unique<br/>
        ///  set of model names and every name must match this pattern: ^[a-zA-Z0-9_-]{1,64}$.
        /// </param>
        /// <param name="authTokens">
        /// Auth tokens used to satisfy the tool's security requirements.
        /// </param>
        /// <param name="parameterOverrides">
        /// Static values to use in place of dynamic parameters. Any parameter included<br/>
        ///  here will be hidden from the model and the static value will be used instead.<br/>
        ///  Some tools may require certain parameters to be overridden, but any parameter<br/>
        ///  can be overridden regardless of whether it is required to be.
        /// </param>
        /// <param name="transitionId">
        /// For internal use. Relates this tool to a stage transition definition within a call template for attribution.
        /// </param>
        public UltravoxV1SelectedTool(
            string? toolId,
            string? toolName,
            global::G.UltravoxV1BaseToolDefinition? temporaryTool,
            string? nameOverride,
            global::System.Collections.Generic.Dictionary<string, string>? authTokens,
            object? parameterOverrides,
            string? transitionId)
        {
            this.ToolId = toolId;
            this.ToolName = toolName;
            this.TemporaryTool = temporaryTool;
            this.NameOverride = nameOverride;
            this.AuthTokens = authTokens;
            this.ParameterOverrides = parameterOverrides;
            this.TransitionId = transitionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1SelectedTool" /> class.
        /// </summary>
        public UltravoxV1SelectedTool()
        {
        }
    }
}