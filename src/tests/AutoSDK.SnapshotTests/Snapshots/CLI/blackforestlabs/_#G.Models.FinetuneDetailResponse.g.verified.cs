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
        [global::System.Text.Json.Serialization.JsonPropertyName("finetune_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object FinetuneDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FinetuneDetailResponse" /> class.
        /// </summary>
        /// <param name="finetuneDetails">
        /// Details about the parameters used for finetuning
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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