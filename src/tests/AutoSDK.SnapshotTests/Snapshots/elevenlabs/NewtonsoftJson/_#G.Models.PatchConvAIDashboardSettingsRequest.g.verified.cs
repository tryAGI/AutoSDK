//HintName: G.Models.PatchConvAIDashboardSettingsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchConvAIDashboardSettingsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("charts")]
        public global::System.Collections.Generic.IList<global::G.ChartsItem2>? Charts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchConvAIDashboardSettingsRequest" /> class.
        /// </summary>
        /// <param name="charts"></param>
        public PatchConvAIDashboardSettingsRequest(
            global::System.Collections.Generic.IList<global::G.ChartsItem2>? charts)
        {
            this.Charts = charts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchConvAIDashboardSettingsRequest" /> class.
        /// </summary>
        public PatchConvAIDashboardSettingsRequest()
        {
        }
    }
}