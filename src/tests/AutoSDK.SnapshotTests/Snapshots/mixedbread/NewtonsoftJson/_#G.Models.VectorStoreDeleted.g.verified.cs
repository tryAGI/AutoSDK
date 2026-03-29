//HintName: G.Models.VectorStoreDeleted.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response model for vector store deletion.
    /// </summary>
    public sealed partial class VectorStoreDeleted
    {
        /// <summary>
        /// ID of the deleted vector store
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<string, global::System.Guid?> Id { get; set; } = default!;

        /// <summary>
        /// Whether the deletion was successful
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Deleted { get; set; } = default!;

        /// <summary>
        /// Type of the deleted object<br/>
        /// Default Value: vector_store
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreDeleted" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the deleted vector store
        /// </param>
        /// <param name="deleted">
        /// Whether the deletion was successful
        /// </param>
        /// <param name="object">
        /// Type of the deleted object<br/>
        /// Default Value: vector_store
        /// </param>
        public VectorStoreDeleted(
            global::G.AnyOf<string, global::System.Guid?> id,
            bool deleted,
            string? @object)
        {
            this.Id = id;
            this.Deleted = deleted;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreDeleted" /> class.
        /// </summary>
        public VectorStoreDeleted()
        {
        }
    }
}