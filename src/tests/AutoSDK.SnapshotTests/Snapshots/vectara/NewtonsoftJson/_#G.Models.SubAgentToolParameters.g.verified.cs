//HintName: G.Models.SubAgentToolParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configurable parameters for the sub-agent tool. If not overridden, they will be required by the LLM to fill in.
    /// </summary>
    public sealed partial class SubAgentToolParameters
    {
        /// <summary>
        /// The detailed task instructions for the sub-agent to perform autonomously.<br/>
        /// Example: Review the code changes in pull request \#123 for security issues
        /// </summary>
        /// <example>Review the code changes in pull request \#123 for security issues</example>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Time to idle in minutes before the session expires.<br/>
        /// Example: 60
        /// </summary>
        /// <example>60</example>
        [global::Newtonsoft.Json.JsonProperty("session_tti_minutes")]
        public long? SessionTtiMinutes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubAgentToolParameters" /> class.
        /// </summary>
        /// <param name="message">
        /// The detailed task instructions for the sub-agent to perform autonomously.<br/>
        /// Example: Review the code changes in pull request \#123 for security issues
        /// </param>
        /// <param name="sessionTtiMinutes">
        /// Time to idle in minutes before the session expires.<br/>
        /// Example: 60
        /// </param>
        public SubAgentToolParameters(
            string? message,
            long? sessionTtiMinutes)
        {
            this.Message = message;
            this.SessionTtiMinutes = sessionTtiMinutes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubAgentToolParameters" /> class.
        /// </summary>
        public SubAgentToolParameters()
        {
        }
    }
}