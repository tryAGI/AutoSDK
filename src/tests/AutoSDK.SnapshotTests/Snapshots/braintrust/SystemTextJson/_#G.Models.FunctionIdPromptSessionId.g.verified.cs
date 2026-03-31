//HintName: G.Models.FunctionIdPromptSessionId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Prompt session id
    /// </summary>
    public sealed partial class FunctionIdPromptSessionId
    {
        /// <summary>
        /// The ID of the prompt session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptSessionId { get; set; }

        /// <summary>
        /// The ID of the function in the prompt session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_session_function_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptSessionFunctionId { get; set; }

        /// <summary>
        /// The version of the function
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionIdPromptSessionId" /> class.
        /// </summary>
        /// <param name="promptSessionId">
        /// The ID of the prompt session
        /// </param>
        /// <param name="promptSessionFunctionId">
        /// The ID of the function in the prompt session
        /// </param>
        /// <param name="version">
        /// The version of the function
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionIdPromptSessionId(
            string promptSessionId,
            string promptSessionFunctionId,
            string? version)
        {
            this.PromptSessionId = promptSessionId ?? throw new global::System.ArgumentNullException(nameof(promptSessionId));
            this.PromptSessionFunctionId = promptSessionFunctionId ?? throw new global::System.ArgumentNullException(nameof(promptSessionFunctionId));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionIdPromptSessionId" /> class.
        /// </summary>
        public FunctionIdPromptSessionId()
        {
        }
    }
}