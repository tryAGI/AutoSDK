//HintName: G.Models.AutoHighlightsResult2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An array of results for the Key Phrases model, if it is enabled.<br/>
    /// See [Key phrases](https://www.assemblyai.com/docs/models/key-phrases) for more information.<br/>
    /// Example: {"status":"success","results":[{"count":1,"rank":0.08,"text":"air quality alerts","timestamps":[{"start":3978,"end":5114}]},{"count":1,"rank":0.08,"text":"wide ranging air quality consequences","timestamps":[{"start":235388,"end":238694}]},{"count":1,"rank":0.07,"text":"more wildfires","timestamps":[{"start":230972,"end":232354}]},{"count":1,"rank":0.07,"text":"air pollution","timestamps":[{"start":156004,"end":156910}]},{"count":3,"rank":0.07,"text":"weather systems","timestamps":[{"start":47344,"end":47958},{"start":205268,"end":205818},{"start":211588,"end":213434}]},{"count":2,"rank":0.06,"text":"high levels","timestamps":[{"start":121128,"end":121646},{"start":155412,"end":155866}]},{"count":1,"rank":0.06,"text":"health conditions","timestamps":[{"start":152138,"end":152666}]},{"count":2,"rank":0.06,"text":"Peter de Carlo","timestamps":[{"start":18948,"end":19930},{"start":268298,"end":269194}]},{"count":1,"rank":0.06,"text":"New York City","timestamps":[{"start":125768,"end":126274}]},{"count":1,"rank":0.05,"text":"respiratory conditions","timestamps":[{"start":152964,"end":153786}]},{"count":3,"rank":0.05,"text":"New York","timestamps":[{"start":125768,"end":126034},{"start":171448,"end":171938},{"start":176008,"end":176322}]},{"count":3,"rank":0.05,"text":"climate change","timestamps":[{"start":229548,"end":230230},{"start":244576,"end":245162},{"start":263348,"end":263950}]},{"count":1,"rank":0.05,"text":"Johns Hopkins University Varsity","timestamps":[{"start":23972,"end":25490}]},{"count":1,"rank":0.05,"text":"heart conditions","timestamps":[{"start":153988,"end":154506}]},{"count":1,"rank":0.05,"text":"air quality warnings","timestamps":[{"start":12308,"end":13434}]}]}
    /// </summary>
    public sealed partial class AutoHighlightsResult2
    {
        /// <summary>
        /// Either success, or unavailable in the rare case that the model failed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AudioIntelligenceModelStatus Status { get; set; } = default!;

        /// <summary>
        /// A temporally-sequential array of Key Phrases
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AutoHighlightResult> Results { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoHighlightsResult2" /> class.
        /// </summary>
        /// <param name="status">
        /// Either success, or unavailable in the rare case that the model failed
        /// </param>
        /// <param name="results">
        /// A temporally-sequential array of Key Phrases
        /// </param>
        public AutoHighlightsResult2(
            global::G.AudioIntelligenceModelStatus status,
            global::System.Collections.Generic.IList<global::G.AutoHighlightResult> results)
        {
            this.Status = status;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoHighlightsResult2" /> class.
        /// </summary>
        public AutoHighlightsResult2()
        {
        }
    }
}