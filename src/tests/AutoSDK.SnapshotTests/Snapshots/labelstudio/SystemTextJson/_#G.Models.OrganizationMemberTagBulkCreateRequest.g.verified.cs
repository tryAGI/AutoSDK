//HintName: G.Models.OrganizationMemberTagBulkCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Serializer for bulk create of organization member tags.
    /// </summary>
    public sealed partial class OrganizationMemberTagBulkCreateRequest
    {
        /// <summary>
        /// List of tag labels to create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMemberTagBulkCreateRequest" /> class.
        /// </summary>
        /// <param name="labels">
        /// List of tag labels to create.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationMemberTagBulkCreateRequest(
            global::System.Collections.Generic.IList<string> labels)
        {
            this.Labels = labels ?? throw new global::System.ArgumentNullException(nameof(labels));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMemberTagBulkCreateRequest" /> class.
        /// </summary>
        public OrganizationMemberTagBulkCreateRequest()
        {
        }
    }
}