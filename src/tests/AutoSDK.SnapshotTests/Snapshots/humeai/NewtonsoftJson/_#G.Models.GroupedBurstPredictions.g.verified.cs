//HintName: G.Models.GroupedBurstPredictions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GroupedBurstPredictions
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
        public global::System.Collections.Generic.IList<global::G.BurstPrediction>? Predictions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupedBurstPredictions" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="predictions"></param>
        public GroupedBurstPredictions(
            string? id,
            global::System.Collections.Generic.IList<global::G.BurstPrediction>? predictions)
        {
            this.Id = id;
            this.Predictions = predictions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupedBurstPredictions" /> class.
        /// </summary>
        public GroupedBurstPredictions()
        {
        }
    }
}