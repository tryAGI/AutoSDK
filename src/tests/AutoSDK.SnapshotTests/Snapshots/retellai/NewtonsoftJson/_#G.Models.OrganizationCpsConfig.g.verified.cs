//HintName: G.Models.OrganizationCpsConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationCpsConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("twilio")]
        public double? Twilio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("telnyx")]
        public double? Telnyx { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom")]
        public double? Custom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationCpsConfig" /> class.
        /// </summary>
        /// <param name="twilio"></param>
        /// <param name="telnyx"></param>
        /// <param name="custom"></param>
        public OrganizationCpsConfig(
            double? twilio,
            double? telnyx,
            double? custom)
        {
            this.Twilio = twilio;
            this.Telnyx = telnyx;
            this.Custom = custom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationCpsConfig" /> class.
        /// </summary>
        public OrganizationCpsConfig()
        {
        }
    }
}