//HintName: G.Models.RenameNamespaceModelBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RenameNamespaceModelBody
    {
        /// <summary>
        /// The new resource ID. This will transform the resource name into<br/>
        /// `namespaces/{namespace.id}/models/{new_model_id}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newModelId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewModelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RenameNamespaceModelBody" /> class.
        /// </summary>
        /// <param name="newModelId">
        /// The new resource ID. This will transform the resource name into<br/>
        /// `namespaces/{namespace.id}/models/{new_model_id}`.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RenameNamespaceModelBody(
            string newModelId)
        {
            this.NewModelId = newModelId ?? throw new global::System.ArgumentNullException(nameof(newModelId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenameNamespaceModelBody" /> class.
        /// </summary>
        public RenameNamespaceModelBody()
        {
        }
    }
}