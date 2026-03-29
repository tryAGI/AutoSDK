//HintName: G.Models.StoreFileDeleted.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response model for file deletion.
    /// </summary>
    public sealed partial class StoreFileDeleted
    {
        /// <summary>
        /// ID of the deleted file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Whether the deletion was successful<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Type of the deleted object<br/>
        /// Default Value: store.file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreFileDeleted" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the deleted file
        /// </param>
        /// <param name="deleted">
        /// Whether the deletion was successful<br/>
        /// Default Value: true
        /// </param>
        /// <param name="object">
        /// Type of the deleted object<br/>
        /// Default Value: store.file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoreFileDeleted(
            string id,
            bool? deleted,
            string? @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Deleted = deleted;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreFileDeleted" /> class.
        /// </summary>
        public StoreFileDeleted()
        {
        }
    }
}