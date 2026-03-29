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
        [global::Newtonsoft.Json.JsonProperty("finetune_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FinetuneId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFinetuneInputs" /> class.
        /// </summary>
        /// <param name="finetuneId">
        /// ID of the fine-tuned model you want to delete.<br/>
        /// Example: my-finetune
        /// </param>
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