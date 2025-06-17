//HintName: G.Models.GetConvAIDashboardSettingsResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConvAIDashboardSettingsResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("charts")]
        public global::System.Collections.Generic.IList<global::G.ChartsItem>? Charts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConvAIDashboardSettingsResponseModel" /> class.
        /// </summary>
        /// <param name="charts"></param>
        public GetConvAIDashboardSettingsResponseModel(
            global::System.Collections.Generic.IList<global::G.ChartsItem>? charts)
        {
            this.Charts = charts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConvAIDashboardSettingsResponseModel" /> class.
        /// </summary>
        public GetConvAIDashboardSettingsResponseModel()
        {
        }
    }
}