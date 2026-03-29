//HintName: G.Models.ToolConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The Tool configuration containing parameters for specifying `Tool` use in the request.
    /// </summary>
    public sealed partial class ToolConfig
    {
        /// <summary>
        /// Configuration for specifying function calling behavior.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("functionCallingConfig")]
        public global::G.FunctionCallingConfig? FunctionCallingConfig { get; set; }

        /// <summary>
        /// Retrieval config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrievalConfig")]
        public global::G.RetrievalConfig? RetrievalConfig { get; set; }

        /// <summary>
        /// Optional. If true, the API response will include the server-side tool calls and responses within the `Content` message. This allows clients to observe the server's tool interactions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeServerSideToolInvocations")]
        public bool? IncludeServerSideToolInvocations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolConfig" /> class.
        /// </summary>
        /// <param name="functionCallingConfig">
        /// Configuration for specifying function calling behavior.
        /// </param>
        /// <param name="retrievalConfig">
        /// Retrieval config.
        /// </param>
        /// <param name="includeServerSideToolInvocations">
        /// Optional. If true, the API response will include the server-side tool calls and responses within the `Content` message. This allows clients to observe the server's tool interactions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolConfig(
            global::G.FunctionCallingConfig? functionCallingConfig,
            global::G.RetrievalConfig? retrievalConfig,
            bool? includeServerSideToolInvocations)
        {
            this.FunctionCallingConfig = functionCallingConfig;
            this.RetrievalConfig = retrievalConfig;
            this.IncludeServerSideToolInvocations = includeServerSideToolInvocations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolConfig" /> class.
        /// </summary>
        public ToolConfig()
        {
        }
    }
}