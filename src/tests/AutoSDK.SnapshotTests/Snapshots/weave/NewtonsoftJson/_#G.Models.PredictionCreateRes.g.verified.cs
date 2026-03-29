//HintName: G.Models.PredictionCreateRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PredictionCreateRes
    {
        /// <summary>
        /// The prediction ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prediction_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string PredictionId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionCreateRes" /> class.
        /// </summary>
        /// <param name="predictionId">
        /// The prediction ID
        /// </param>
        public PredictionCreateRes(
            string predictionId)
        {
            this.PredictionId = predictionId ?? throw new global::System.ArgumentNullException(nameof(predictionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionCreateRes" /> class.
        /// </summary>
        public PredictionCreateRes()
        {
        }
    }
}