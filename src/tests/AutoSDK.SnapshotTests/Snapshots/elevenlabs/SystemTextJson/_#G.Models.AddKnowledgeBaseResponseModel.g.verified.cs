//HintName: G.Models.AddKnowledgeBaseResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddKnowledgeBaseResponseModel
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
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_injectable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PromptInjectable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddKnowledgeBaseResponseModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="promptInjectable"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddKnowledgeBaseResponseModel(
            string id,
            bool promptInjectable)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.PromptInjectable = promptInjectable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddKnowledgeBaseResponseModel" /> class.
        /// </summary>
        public AddKnowledgeBaseResponseModel()
        {
        }
    }
}