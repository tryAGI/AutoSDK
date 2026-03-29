//HintName: G.Models.DeleteTemplateTagsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteTemplateTagsRequest
    {
        /// <summary>
        /// Name of the template
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Tags to delete
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTemplateTagsRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the template
        /// </param>
        /// <param name="tags">
        /// Tags to delete
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteTemplateTagsRequest(
            string name,
            global::System.Collections.Generic.IList<string> tags)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteTemplateTagsRequest" /> class.
        /// </summary>
        public DeleteTemplateTagsRequest()
        {
        }
    }
}