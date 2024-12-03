//HintName: G.Models.EndPredictionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EndPredictionResponse
    {
        /// <summary>
        /// A list that contains the single prediction that you updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Prediction> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndPredictionResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A list that contains the single prediction that you updated.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public EndPredictionResponse(
            global::System.Collections.Generic.IList<global::G.Prediction> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndPredictionResponse" /> class.
        /// </summary>
        public EndPredictionResponse()
        {
        }
    }
}