//HintName: G.Models.CreatePromptResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatePromptResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptVersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePromptResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="promptVersionId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatePromptResponse(
            string id,
            string promptVersionId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.PromptVersionId = promptVersionId ?? throw new global::System.ArgumentNullException(nameof(promptVersionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePromptResponse" /> class.
        /// </summary>
        public CreatePromptResponse()
        {
        }
    }
}