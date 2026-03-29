//HintName: G.Models.InferenceSourcePredictResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InferenceSourcePredictResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source")]
        public global::G.Source? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results")]
        public global::G.InferenceResults? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InferenceSourcePredictResult" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="results"></param>
        public InferenceSourcePredictResult(
            global::G.Source? source,
            global::G.InferenceResults? results)
        {
            this.Source = source;
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InferenceSourcePredictResult" /> class.
        /// </summary>
        public InferenceSourcePredictResult()
        {
        }
    }
}