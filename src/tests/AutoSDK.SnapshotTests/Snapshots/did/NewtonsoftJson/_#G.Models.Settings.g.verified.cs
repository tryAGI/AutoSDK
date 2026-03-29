//HintName: G.Models.Settings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Settings
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logo")]
        public global::G.SettingsLogo? Logo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agents")]
        public global::G.SettingsAgents? Agents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agents_insights_is_enabled")]
        public bool? AgentsInsightsIsEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatars")]
        public global::G.SettingsAvatars? Avatars { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Settings" /> class.
        /// </summary>
        /// <param name="logo"></param>
        /// <param name="agents"></param>
        /// <param name="agentsInsightsIsEnabled"></param>
        /// <param name="avatars"></param>
        public Settings(
            global::G.SettingsLogo? logo,
            global::G.SettingsAgents? agents,
            bool? agentsInsightsIsEnabled,
            global::G.SettingsAvatars? avatars)
        {
            this.Logo = logo;
            this.Agents = agents;
            this.AgentsInsightsIsEnabled = agentsInsightsIsEnabled;
            this.Avatars = avatars;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Settings" /> class.
        /// </summary>
        public Settings()
        {
        }
    }
}