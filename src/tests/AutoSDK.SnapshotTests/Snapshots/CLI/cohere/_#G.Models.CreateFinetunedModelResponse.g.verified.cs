//HintName: G.Models.CreateFinetunedModelResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response to request to create a fine-tuned model.
    /// </summary>
    public sealed partial class CreateFinetunedModelResponse
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
        /// Initializes a new instance of the <see cref="CreateFinetunedModelResponse" /> class.
        /// </summary>
        /// <param name="finetunedModel">
        /// This resource represents a fine-tuned model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFinetunedModelResponse(
            global::G.FinetunedModel? finetunedModel)
        {
            this.FinetunedModel = finetunedModel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFinetunedModelResponse" /> class.
        /// </summary>
        public CreateFinetunedModelResponse()
        {
        }
    }
}