//HintName: G.Models.PostToolRouterSessionRequestExperimentalAssistivePromptConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Customize assistive prompt generation (e.g., timezone).
    /// </summary>
    public sealed partial class PostToolRouterSessionRequestExperimentalAssistivePromptConfig
    {
        /// <summary>
        /// IANA timezone identifier (e.g., 'America/New_York', 'Europe/London'). Used to customize the system prompt with timezone-aware instructions.<br/>
        /// Example: America/New_York
        /// </summary>
        /// <example>America/New_York</example>
        [global::Newtonsoft.Json.JsonProperty("user_timezone")]
        public string? UserTimezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestExperimentalAssistivePromptConfig" /> class.
        /// </summary>
        /// <param name="userTimezone">
        /// IANA timezone identifier (e.g., 'America/New_York', 'Europe/London'). Used to customize the system prompt with timezone-aware instructions.<br/>
        /// Example: America/New_York
        /// </param>
        public PostToolRouterSessionRequestExperimentalAssistivePromptConfig(
            string? userTimezone)
        {
            this.UserTimezone = userTimezone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestExperimentalAssistivePromptConfig" /> class.
        /// </summary>
        public PostToolRouterSessionRequestExperimentalAssistivePromptConfig()
        {
        }
    }
}