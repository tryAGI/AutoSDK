//HintName: G.Models.UpdateFinetunedModelResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response to a request to update a fine-tuned model.
    /// </summary>
    public sealed partial class UpdateFinetunedModelResponse
    {
        /// <summary>
        /// Information about the fine-tuned model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finetuned_model")]
        public global::G.FinetunedModel? FinetunedModel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFinetunedModelResponse" /> class.
        /// </summary>
        /// <param name="finetunedModel">
        /// Information about the fine-tuned model.
        /// </param>
        public UpdateFinetunedModelResponse(
            global::G.FinetunedModel? finetunedModel)
        {
            this.FinetunedModel = finetunedModel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFinetunedModelResponse" /> class.
        /// </summary>
        public UpdateFinetunedModelResponse()
        {
        }
    }
}