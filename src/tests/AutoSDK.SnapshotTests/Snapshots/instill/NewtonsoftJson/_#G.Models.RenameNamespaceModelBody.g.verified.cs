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
        [global::Newtonsoft.Json.JsonProperty("newModelId", Required = global::Newtonsoft.Json.Required.Always)]
        public string NewModelId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RenameNamespaceModelBody" /> class.
        /// </summary>
        /// <param name="newModelId">
        /// The new resource ID. This will transform the resource name into<br/>
        /// `namespaces/{namespace.id}/models/{new_model_id}`.
        /// </param>
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