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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Whether the deletion was successful<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Type of the deleted object<br/>
        /// Default Value: store.file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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