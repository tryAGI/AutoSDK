//HintName: G.Models.ToolTemplateMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolTemplateMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collectionType")]
        public string? CollectionType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collectionId")]
        public string? CollectionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collectionName")]
        public string? CollectionName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolTemplateMetadata" /> class.
        /// </summary>
        /// <param name="collectionType"></param>
        /// <param name="collectionId"></param>
        /// <param name="collectionName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolTemplateMetadata(
            string? collectionType,
            string? collectionId,
            string? collectionName)
        {
            this.CollectionType = collectionType;
            this.CollectionId = collectionId;
            this.CollectionName = collectionName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolTemplateMetadata" /> class.
        /// </summary>
        public ToolTemplateMetadata()
        {
        }
    }
}