//HintName: G.Models.FinetuneDetailResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FinetuneDetailResponse
    {
        /// <summary>
        /// Details about the parameters used for finetuning
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finetune_details", Required = global::Newtonsoft.Json.Required.Always)]
        public object FinetuneDetails { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneDetailResponse" /> class.
        /// </summary>
        /// <param name="finetuneDetails">
        /// Details about the parameters used for finetuning
        /// </param>
        public FinetuneDetailResponse(
            object finetuneDetails)
        {
            this.FinetuneDetails = finetuneDetails ?? throw new global::System.ArgumentNullException(nameof(finetuneDetails));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneDetailResponse" /> class.
        /// </summary>
        public FinetuneDetailResponse()
        {
        }
    }
}