//HintName: G.Models.UltravoxV1BaseToolDefinition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The base definition of a tool that can be used during a call. Exactly one<br/>
    ///  implementation (http or client) should be set.
    /// </summary>
    public sealed partial class UltravoxV1BaseToolDefinition
    {
        /// <summary>
        /// The name of the tool, as presented to the model. Must match ^[a-zA-Z0-9_-]{1,64}$.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modelToolName")]
        public string? ModelToolName { get; set; }

        /// <summary>
        /// The description of the tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The parameters that the tool accepts.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dynamicParameters")]
        public global::System.Collections.Generic.IList<global::G.UltravoxV1DynamicParameter>? DynamicParameters { get; set; }

        /// <summary>
        /// The static parameters added when the tool is invoked.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("staticParameters")]
        public global::System.Collections.Generic.IList<global::G.UltravoxV1StaticParameter>? StaticParameters { get; set; }

        /// <summary>
        /// Additional parameters that are automatically set by the system when the tool is invoked.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("automaticParameters")]
        public global::System.Collections.Generic.IList<global::G.UltravoxV1AutomaticParameter>? AutomaticParameters { get; set; }

        /// <summary>
        /// Requirements that must be fulfilled when creating a call for the tool to be used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requirements")]
        public global::G.UltravoxV1ToolRequirements? Requirements { get; set; }

        /// <summary>
        /// The maximum amount of time the tool is allowed for execution. The conversation is frozen<br/>
        ///  while tools run, so prefer sticking to the default unless you're comfortable with that<br/>
        ///  consequence. If your tool is too slow for the default and can't be made faster, still try to<br/>
        ///  keep this timeout as low as possible.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeout")]
        public string? Timeout { get; set; }

        /// <summary>
        /// The tool is guaranteed to be non-mutating, repeatable, and free of side-effects. Such tools<br/>
        ///  can safely be executed speculatively, reducing their effective latency. However, the fact they<br/>
        ///  were called may not be reflected in the call history if their result ends up unused.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("precomputable")]
        public bool? Precomputable { get; set; }

        /// <summary>
        /// Details for an HTTP tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("http")]
        public global::G.UltravoxV1BaseHttpToolDetails? Http { get; set; }

        /// <summary>
        /// Details for a client-implemented tool. Only body parameters are allowed<br/>
        ///  for client tools.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client")]
        public object? Client { get; set; }

        /// <summary>
        /// Indicates the default for how the agent should proceed after the tool is invoked.<br/>
        ///  Can be overridden by the tool implementation via the X-Ultravox-Agent-Reaction<br/>
        ///  header.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("defaultReaction")]
        public global::G.UltravoxV1BaseToolDefinitionDefaultReaction? DefaultReaction { get; set; }

        /// <summary>
        /// Static response to a tool. When this is used, this response will be returned<br/>
        ///  without waiting for the tool's response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("staticResponse")]
        public global::G.UltravoxV1StaticToolResponse? StaticResponse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1BaseToolDefinition" /> class.
        /// </summary>
        /// <param name="modelToolName">
        /// The name of the tool, as presented to the model. Must match ^[a-zA-Z0-9_-]{1,64}$.
        /// </param>
        /// <param name="description">
        /// The description of the tool.
        /// </param>
        /// <param name="dynamicParameters">
        /// The parameters that the tool accepts.
        /// </param>
        /// <param name="staticParameters">
        /// The static parameters added when the tool is invoked.
        /// </param>
        /// <param name="automaticParameters">
        /// Additional parameters that are automatically set by the system when the tool is invoked.
        /// </param>
        /// <param name="requirements">
        /// Requirements that must be fulfilled when creating a call for the tool to be used.
        /// </param>
        /// <param name="timeout">
        /// The maximum amount of time the tool is allowed for execution. The conversation is frozen<br/>
        ///  while tools run, so prefer sticking to the default unless you're comfortable with that<br/>
        ///  consequence. If your tool is too slow for the default and can't be made faster, still try to<br/>
        ///  keep this timeout as low as possible.
        /// </param>
        /// <param name="precomputable">
        /// The tool is guaranteed to be non-mutating, repeatable, and free of side-effects. Such tools<br/>
        ///  can safely be executed speculatively, reducing their effective latency. However, the fact they<br/>
        ///  were called may not be reflected in the call history if their result ends up unused.
        /// </param>
        /// <param name="http">
        /// Details for an HTTP tool.
        /// </param>
        /// <param name="client">
        /// Details for a client-implemented tool. Only body parameters are allowed<br/>
        ///  for client tools.
        /// </param>
        /// <param name="defaultReaction">
        /// Indicates the default for how the agent should proceed after the tool is invoked.<br/>
        ///  Can be overridden by the tool implementation via the X-Ultravox-Agent-Reaction<br/>
        ///  header.
        /// </param>
        /// <param name="staticResponse">
        /// Static response to a tool. When this is used, this response will be returned<br/>
        ///  without waiting for the tool's response.
        /// </param>
        public UltravoxV1BaseToolDefinition(
            string? modelToolName,
            string? description,
            global::System.Collections.Generic.IList<global::G.UltravoxV1DynamicParameter>? dynamicParameters,
            global::System.Collections.Generic.IList<global::G.UltravoxV1StaticParameter>? staticParameters,
            global::System.Collections.Generic.IList<global::G.UltravoxV1AutomaticParameter>? automaticParameters,
            global::G.UltravoxV1ToolRequirements? requirements,
            string? timeout,
            bool? precomputable,
            global::G.UltravoxV1BaseHttpToolDetails? http,
            object? client,
            global::G.UltravoxV1BaseToolDefinitionDefaultReaction? defaultReaction,
            global::G.UltravoxV1StaticToolResponse? staticResponse)
        {
            this.ModelToolName = modelToolName;
            this.Description = description;
            this.DynamicParameters = dynamicParameters;
            this.StaticParameters = staticParameters;
            this.AutomaticParameters = automaticParameters;
            this.Requirements = requirements;
            this.Timeout = timeout;
            this.Precomputable = precomputable;
            this.Http = http;
            this.Client = client;
            this.DefaultReaction = defaultReaction;
            this.StaticResponse = staticResponse;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1BaseToolDefinition" /> class.
        /// </summary>
        public UltravoxV1BaseToolDefinition()
        {
        }
    }
}