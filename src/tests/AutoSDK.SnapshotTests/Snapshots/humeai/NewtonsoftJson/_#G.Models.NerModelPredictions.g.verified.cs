//HintName: G.Models.NerModelPredictions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NerModelPredictions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("grouped_predictions")]
        public global::System.Collections.Generic.IList<global::G.GroupedNerPredictions>? GroupedPredictions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NerModelPredictions" /> class.
        /// </summary>
        /// <param name="groupedPredictions"></param>
        public NerModelPredictions(
            global::System.Collections.Generic.IList<global::G.GroupedNerPredictions>? groupedPredictions)
        {
            this.GroupedPredictions = groupedPredictions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NerModelPredictions" /> class.
        /// </summary>
        public NerModelPredictions()
        {
        }
    }
}