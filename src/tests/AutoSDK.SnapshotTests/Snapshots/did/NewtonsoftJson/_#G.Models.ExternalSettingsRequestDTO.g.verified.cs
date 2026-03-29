//HintName: G.Models.ExternalSettingsRequestDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExternalSettingsRequestDTO
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
        public global::G.ExternalSettingsRequestDTOLogo? Logo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalSettingsRequestDTO" /> class.
        /// </summary>
        /// <param name="agentsInsightsIsEnabled"></param>
        /// <param name="logo"></param>
        public ExternalSettingsRequestDTO(
            bool? agentsInsightsIsEnabled,
            global::G.ExternalSettingsRequestDTOLogo? logo)
        {
            this.AgentsInsightsIsEnabled = agentsInsightsIsEnabled;
            this.Logo = logo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalSettingsRequestDTO" /> class.
        /// </summary>
        public ExternalSettingsRequestDTO()
        {
        }
    }
}