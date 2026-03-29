//HintName: G.Models.IntegrationUpdateParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IntegrationUpdateParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("integration_name")]
        public string? IntegrationName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("settings")]
        public global::G.Json? Settings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationUpdateParams" /> class.
        /// </summary>
        /// <param name="integrationName"></param>
        /// <param name="settings"></param>
        /// <param name="active"></param>
        public IntegrationUpdateParams(
            string? integrationName,
            global::G.Json? settings,
            bool? active)
        {
            this.IntegrationName = integrationName;
            this.Settings = settings;
            this.Active = active;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationUpdateParams" /> class.
        /// </summary>
        public IntegrationUpdateParams()
        {
        }
    }
}