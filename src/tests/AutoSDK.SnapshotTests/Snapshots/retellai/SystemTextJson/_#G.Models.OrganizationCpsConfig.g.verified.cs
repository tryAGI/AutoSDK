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
        [global::System.Text.Json.Serialization.JsonPropertyName("twilio")]
        public double? Twilio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("telnyx")]
        public double? Telnyx { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom")]
        public double? Custom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationCpsConfig" /> class.
        /// </summary>
        /// <param name="twilio"></param>
        /// <param name="telnyx"></param>
        /// <param name="custom"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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