//HintName: G.Models.UpdatePromptPartialResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdatePromptPartialResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_partial_version_id")]
        public global::System.Guid? PromptPartialVersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePromptPartialResponse" /> class.
        /// </summary>
        /// <param name="promptPartialVersionId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatePromptPartialResponse(
            global::System.Guid? promptPartialVersionId)
        {
            this.PromptPartialVersionId = promptPartialVersionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePromptPartialResponse" /> class.
        /// </summary>
        public UpdatePromptPartialResponse()
        {
        }
    }
}