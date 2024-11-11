//HintName: G.Models.GetFinetunedModelResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response to a request to get a fine-tuned model.
    /// </summary>
    public sealed partial class GetFinetunedModelResponse
    {
        /// <summary>
        /// This resource represents a fine-tuned model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finetuned_model")]
        public global::G.FinetunedModel? FinetunedModel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFinetunedModelResponse" /> class.
        /// </summary>
        /// <param name="finetunedModel">
        /// This resource represents a fine-tuned model.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetFinetunedModelResponse(
            global::G.FinetunedModel? finetunedModel)
        {
            this.FinetunedModel = finetunedModel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFinetunedModelResponse" /> class.
        /// </summary>
        public GetFinetunedModelResponse()
        {
        }
    }
}