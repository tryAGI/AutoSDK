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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<string, global::System.Guid?> Id { get; set; }

        /// <summary>
        /// Whether the deletion was successful
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// Type of the deleted object<br/>
        /// Default Value: vector_store
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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