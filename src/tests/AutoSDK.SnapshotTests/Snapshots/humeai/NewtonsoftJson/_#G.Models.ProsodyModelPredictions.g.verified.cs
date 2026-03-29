//HintName: G.Models.ProsodyModelPredictions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProsodyModelPredictions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("grouped_predictions")]
        public global::System.Collections.Generic.IList<global::G.GroupedProsodyPredictions>? GroupedPredictions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProsodyModelPredictions" /> class.
        /// </summary>
        /// <param name="groupedPredictions"></param>
        public ProsodyModelPredictions(
            global::System.Collections.Generic.IList<global::G.GroupedProsodyPredictions>? groupedPredictions)
        {
            this.GroupedPredictions = groupedPredictions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProsodyModelPredictions" /> class.
        /// </summary>
        public ProsodyModelPredictions()
        {
        }
    }
}