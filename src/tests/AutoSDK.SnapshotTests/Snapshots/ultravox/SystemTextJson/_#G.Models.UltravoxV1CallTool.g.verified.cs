//HintName: G.Models.UltravoxV1CallTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A tool as used for a particular call (omitting auth details).
    /// </summary>
    public sealed partial class UltravoxV1CallTool
    {
        /// <summary>
        /// The description of the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The parameters presented to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamicParameters")]
        public global::System.Collections.Generic.IList<global::G.UltravoxV1DynamicParameter>? DynamicParameters { get; set; }

        /// <summary>
        /// Parameters added unconditionally when the tool is invoked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("staticParameters")]
        public global::System.Collections.Generic.IList<global::G.UltravoxV1StaticParameter>? StaticParameters { get; set; }

        /// <summary>
        /// Parameters automatically set by the system.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("automaticParameters")]
        public global::System.Collections.Generic.IList<global::G.UltravoxV1AutomaticParameter>? AutomaticParameters { get; set; }

        /// <summary>
        /// The maximum amount of time the tool is allowed for execution. The conversation is frozen<br/>
        ///  while tools run, so prefer sticking to the default unless you're comfortable with that<br/>
        ///  consequence. If your tool is too slow for the default and can't be made faster, still try to<br/>
        ///  keep this timeout as low as possible.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public string? Timeout { get; set; }

        /// <summary>
        /// The tool is guaranteed to be non-mutating, repeatable, and free of side-effects. Such tools<br/>
        ///  can safely be executed speculatively, reducing their effective latency. However, the fact they<br/>
        ///  were called may not be reflected in the call history if their result ends up unused.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("precomputable")]
        public bool? Precomputable { get; set; }

        /// <summary>
        /// Details for an HTTP tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("http")]
        public global::G.UltravoxV1HttpCallToolDetails? Http { get; set; }

        /// <summary>
        /// Details for a client-implemented tool. Only body parameters are allowed<br/>
        ///  for client tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client")]
        public object? Client { get; set; }

        /// <summary>
        /// Indicates the default for how the agent should proceed after the tool is invoked.<br/>
        ///  Can be overridden by the tool implementation via the X-Ultravox-Agent-Reaction<br/>
        ///  header.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultReaction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UltravoxV1CallToolDefaultReactionJsonConverter))]
        public global::G.UltravoxV1CallToolDefaultReaction? DefaultReaction { get; set; }

        /// <summary>
        /// Static response to a tool. When this is used, this response will be returned<br/>
        ///  without waiting for the tool's response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("staticResponse")]
        public global::G.UltravoxV1StaticToolResponse? StaticResponse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CallTool" /> class.
        /// </summary>
        /// <param name="description">
        /// The description of the tool.
        /// </param>
        /// <param name="dynamicParameters">
        /// The parameters presented to the model.
        /// </param>
        /// <param name="staticParameters">
        /// Parameters added unconditionally when the tool is invoked.
        /// </param>
        /// <param name="automaticParameters">
        /// Parameters automatically set by the system.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1CallTool(
            string? description,
            global::System.Collections.Generic.IList<global::G.UltravoxV1DynamicParameter>? dynamicParameters,
            global::System.Collections.Generic.IList<global::G.UltravoxV1StaticParameter>? staticParameters,
            global::System.Collections.Generic.IList<global::G.UltravoxV1AutomaticParameter>? automaticParameters,
            string? timeout,
            bool? precomputable,
            global::G.UltravoxV1HttpCallToolDetails? http,
            object? client,
            global::G.UltravoxV1CallToolDefaultReaction? defaultReaction,
            global::G.UltravoxV1StaticToolResponse? staticResponse)
        {
            this.Description = description;
            this.DynamicParameters = dynamicParameters;
            this.StaticParameters = staticParameters;
            this.AutomaticParameters = automaticParameters;
            this.Timeout = timeout;
            this.Precomputable = precomputable;
            this.Http = http;
            this.Client = client;
            this.DefaultReaction = defaultReaction;
            this.StaticResponse = staticResponse;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CallTool" /> class.
        /// </summary>
        public UltravoxV1CallTool()
        {
        }
    }
}