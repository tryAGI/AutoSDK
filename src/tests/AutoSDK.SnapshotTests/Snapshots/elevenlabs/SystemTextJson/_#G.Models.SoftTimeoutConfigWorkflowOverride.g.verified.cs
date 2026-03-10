//HintName: G.Models.SoftTimeoutConfigWorkflowOverride.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"message":"Hhmmmm...yeah.","timeout_seconds":-1.0,"use_llm_generated_message":false}
    /// </summary>
    public sealed partial class SoftTimeoutConfigWorkflowOverride
    {
        /// <summary>
        /// Time in seconds before showing the predefined message while waiting for LLM response. Set to -1 to disable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_seconds")]
        public double? TimeoutSeconds { get; set; }

        /// <summary>
        /// Message to show when soft timeout is reached while waiting for LLM response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// If enabled, the soft timeout message will be generated dynamically instead of using the static message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_llm_generated_message")]
        public bool? UseLlmGeneratedMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SoftTimeoutConfigWorkflowOverride" /> class.
        /// </summary>
        /// <param name="timeoutSeconds">
        /// Time in seconds before showing the predefined message while waiting for LLM response. Set to -1 to disable.
        /// </param>
        /// <param name="message">
        /// Message to show when soft timeout is reached while waiting for LLM response
        /// </param>
        /// <param name="useLlmGeneratedMessage">
        /// If enabled, the soft timeout message will be generated dynamically instead of using the static message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SoftTimeoutConfigWorkflowOverride(
            double? timeoutSeconds,
            string? message,
            bool? useLlmGeneratedMessage)
        {
            this.TimeoutSeconds = timeoutSeconds;
            this.Message = message;
            this.UseLlmGeneratedMessage = useLlmGeneratedMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SoftTimeoutConfigWorkflowOverride" /> class.
        /// </summary>
        public SoftTimeoutConfigWorkflowOverride()
        {
        }
    }
}