//HintName: G.Models.GroupedProsodyPredictions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GroupedProsodyPredictions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("predictions")]
        public global::System.Collections.Generic.IList<global::G.ProsodyPrediction>? Predictions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupedProsodyPredictions" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="predictions"></param>
        public GroupedProsodyPredictions(
            string? id,
            global::System.Collections.Generic.IList<global::G.ProsodyPrediction>? predictions)
        {
            this.Id = id;
            this.Predictions = predictions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupedProsodyPredictions" /> class.
        /// </summary>
        public GroupedProsodyPredictions()
        {
        }
    }
}