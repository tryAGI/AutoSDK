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
        [global::System.Text.Json.Serialization.JsonPropertyName("prediction_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PredictionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionCreateRes" /> class.
        /// </summary>
        /// <param name="predictionId">
        /// The prediction ID
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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