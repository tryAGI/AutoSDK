//HintName: G.Models.AgentSuccessResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Result when Agent edit completed successfully
    /// </summary>
    public sealed partial class AgentSuccessResult
    {
        /// <summary>
        /// Indicates successful completion<br/>
        /// Example: success
        /// </summary>
        /// <example>success</example>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AgentSuccessResultStatusJsonConverter))]
        public global::G.AgentSuccessResultStatus Status { get; set; }

        /// <summary>
        /// AI response describing what was done<br/>
        /// Example: I added Studio Sound to all 3 clips in your composition
        /// </summary>
        /// <example>I added Studio Sound to all 3 clips in your composition</example>
        [global::Newtonsoft.Json.JsonProperty("agent_response", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentResponse { get; set; } = default!;

        /// <summary>
        /// Whether the agent made modifications to the project<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("project_changed", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ProjectChanged { get; set; } = default!;

        /// <summary>
        /// Media minutes (in seconds) consumed by this operation<br/>
        /// Example: 34
        /// </summary>
        /// <example>34</example>
        [global::Newtonsoft.Json.JsonProperty("media_seconds_used")]
        public int? MediaSecondsUsed { get; set; }

        /// <summary>
        /// AI credits consumed by this operation<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::Newtonsoft.Json.JsonProperty("ai_credits_used")]
        public int? AiCreditsUsed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSuccessResult" /> class.
        /// </summary>
        /// <param name="agentResponse">
        /// AI response describing what was done<br/>
        /// Example: I added Studio Sound to all 3 clips in your composition
        /// </param>
        /// <param name="projectChanged">
        /// Whether the agent made modifications to the project<br/>
        /// Example: true
        /// </param>
        /// <param name="status">
        /// Indicates successful completion<br/>
        /// Example: success
        /// </param>
        /// <param name="mediaSecondsUsed">
        /// Media minutes (in seconds) consumed by this operation<br/>
        /// Example: 34
        /// </param>
        /// <param name="aiCreditsUsed">
        /// AI credits consumed by this operation<br/>
        /// Example: 5
        /// </param>
        public AgentSuccessResult(
            string agentResponse,
            bool projectChanged,
            global::G.AgentSuccessResultStatus status,
            int? mediaSecondsUsed,
            int? aiCreditsUsed)
        {
            this.Status = status;
            this.AgentResponse = agentResponse ?? throw new global::System.ArgumentNullException(nameof(agentResponse));
            this.ProjectChanged = projectChanged;
            this.MediaSecondsUsed = mediaSecondsUsed;
            this.AiCreditsUsed = aiCreditsUsed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSuccessResult" /> class.
        /// </summary>
        public AgentSuccessResult()
        {
        }
    }
}