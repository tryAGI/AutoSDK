//HintName: G.Models.DeleteFinetuneInputs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteFinetuneInputs
    {
        /// <summary>
        /// ID of the fine-tuned model you want to delete.<br/>
        /// Example: my-finetune
        /// </summary>
        /// <example>my-finetune</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("finetune_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FinetuneId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFinetuneInputs" /> class.
        /// </summary>
        /// <param name="finetuneId">
        /// ID of the fine-tuned model you want to delete.<br/>
        /// Example: my-finetune
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteFinetuneInputs(
            string finetuneId)
        {
            this.FinetuneId = finetuneId ?? throw new global::System.ArgumentNullException(nameof(finetuneId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFinetuneInputs" /> class.
        /// </summary>
        public DeleteFinetuneInputs()
        {
        }
    }
}