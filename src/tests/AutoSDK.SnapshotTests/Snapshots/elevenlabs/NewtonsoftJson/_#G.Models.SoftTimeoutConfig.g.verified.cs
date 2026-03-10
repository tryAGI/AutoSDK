//HintName: G.Models.SoftTimeoutConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for soft timeout functionality during LLM response generation.<br/>
    /// Example: {"message":"Hhmmmm...yeah.","timeout_seconds":2.0,"use_llm_generated_message":false}
    /// </summary>
    public sealed partial class SoftTimeoutConfig
    {
        /// <summary>
        /// Time in seconds before showing the predefined message while waiting for LLM response. Set to -1 to disable.<br/>
        /// Default Value: -1F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeout_seconds")]
        public double? TimeoutSeconds { get; set; }

        /// <summary>
        /// Message to show when soft timeout is reached while waiting for LLM response<br/>
        /// Default Value: Hhmmmm...yeah.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// If enabled, the soft timeout message will be generated dynamically instead of using the static message.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("use_llm_generated_message")]
        public bool? UseLlmGeneratedMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SoftTimeoutConfig" /> class.
        /// </summary>
        /// <param name="timeoutSeconds">
        /// Time in seconds before showing the predefined message while waiting for LLM response. Set to -1 to disable.<br/>
        /// Default Value: -1F
        /// </param>
        /// <param name="message">
        /// Message to show when soft timeout is reached while waiting for LLM response<br/>
        /// Default Value: Hhmmmm...yeah.
        /// </param>
        /// <param name="useLlmGeneratedMessage">
        /// If enabled, the soft timeout message will be generated dynamically instead of using the static message.<br/>
        /// Default Value: false
        /// </param>
        public SoftTimeoutConfig(
            double? timeoutSeconds,
            string? message,
            bool? useLlmGeneratedMessage)
        {
            this.TimeoutSeconds = timeoutSeconds;
            this.Message = message;
            this.UseLlmGeneratedMessage = useLlmGeneratedMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SoftTimeoutConfig" /> class.
        /// </summary>
        public SoftTimeoutConfig()
        {
        }
    }
}