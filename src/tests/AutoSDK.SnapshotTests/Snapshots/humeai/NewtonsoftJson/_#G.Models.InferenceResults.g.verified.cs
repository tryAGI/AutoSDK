//HintName: G.Models.InferenceResults.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InferenceResults
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("predictions")]
        public global::System.Collections.Generic.IList<global::G.InferencePrediction>? Predictions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errors")]
        public global::System.Collections.Generic.IList<global::G.InferenceError>? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InferenceResults" /> class.
        /// </summary>
        /// <param name="predictions"></param>
        /// <param name="errors"></param>
        public InferenceResults(
            global::System.Collections.Generic.IList<global::G.InferencePrediction>? predictions,
            global::System.Collections.Generic.IList<global::G.InferenceError>? errors)
        {
            this.Predictions = predictions;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InferenceResults" /> class.
        /// </summary>
        public InferenceResults()
        {
        }
    }
}