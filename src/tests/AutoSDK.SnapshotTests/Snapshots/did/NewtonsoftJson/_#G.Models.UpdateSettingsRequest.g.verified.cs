//HintName: G.Models.UpdateSettingsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateSettingsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agents_insights_is_enabled")]
        public bool? AgentsInsightsIsEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logo")]
        public global::G.UpdateSettingsRequestLogo? Logo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSettingsRequest" /> class.
        /// </summary>
        /// <param name="agentsInsightsIsEnabled"></param>
        /// <param name="logo"></param>
        public UpdateSettingsRequest(
            bool? agentsInsightsIsEnabled,
            global::G.UpdateSettingsRequestLogo? logo)
        {
            this.AgentsInsightsIsEnabled = agentsInsightsIsEnabled;
            this.Logo = logo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSettingsRequest" /> class.
        /// </summary>
        public UpdateSettingsRequest()
        {
        }
    }
}