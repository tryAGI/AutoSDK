//HintName: G.Models.ModelsCapabilityGetResponsesContentApplicationJsonSchemaDataItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelsCapabilityGetResponsesContentApplicationJsonSchemaDataItems
    {
        /// <summary>
        /// The id of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The object type (model).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The date the model was added.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public int? Created { get; set; }

        /// <summary>
        /// The name of the organization that owns the model (from huggingface).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owned_by")]
        public string? OwnedBy { get; set; }

        /// <summary>
        /// A short description of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The max context length of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_context_length")]
        public int? MaxContextLength { get; set; }

        /// <summary>
        /// The name of the prompt format (if any) the model uses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_format")]
        public string? PromptFormat { get; set; }

        /// <summary>
        /// The available capabilities of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capabilities")]
        public global::G.ModelsCapabilityGetResponsesContentApplicationJsonSchemaDataItemsCapabilities? Capabilities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsCapabilityGetResponsesContentApplicationJsonSchemaDataItems" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the model.
        /// </param>
        /// <param name="object">
        /// The object type (model).
        /// </param>
        /// <param name="created">
        /// The date the model was added.
        /// </param>
        /// <param name="ownedBy">
        /// The name of the organization that owns the model (from huggingface).
        /// </param>
        /// <param name="description">
        /// A short description of the model.
        /// </param>
        /// <param name="maxContextLength">
        /// The max context length of the model.
        /// </param>
        /// <param name="promptFormat">
        /// The name of the prompt format (if any) the model uses.
        /// </param>
        /// <param name="capabilities">
        /// The available capabilities of the model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelsCapabilityGetResponsesContentApplicationJsonSchemaDataItems(
            string? id,
            string? @object,
            int? created,
            string? ownedBy,
            string? description,
            int? maxContextLength,
            string? promptFormat,
            global::G.ModelsCapabilityGetResponsesContentApplicationJsonSchemaDataItemsCapabilities? capabilities)
        {
            this.Id = id;
            this.Object = @object;
            this.Created = created;
            this.OwnedBy = ownedBy;
            this.Description = description;
            this.MaxContextLength = maxContextLength;
            this.PromptFormat = promptFormat;
            this.Capabilities = capabilities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsCapabilityGetResponsesContentApplicationJsonSchemaDataItems" /> class.
        /// </summary>
        public ModelsCapabilityGetResponsesContentApplicationJsonSchemaDataItems()
        {
        }
    }
}