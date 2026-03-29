//HintName: G.Models.StoreDeleted.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response model for store deletion.
    /// </summary>
    public sealed partial class StoreDeleted
    {
        /// <summary>
        /// ID of the deleted store
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
        /// Default Value: store
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreDeleted" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the deleted store
        /// </param>
        /// <param name="deleted">
        /// Whether the deletion was successful
        /// </param>
        /// <param name="object">
        /// Type of the deleted object<br/>
        /// Default Value: store
        /// </param>
        public StoreDeleted(
            global::G.AnyOf<string, global::System.Guid?> id,
            bool deleted,
            string? @object)
        {
            this.Id = id;
            this.Deleted = deleted;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreDeleted" /> class.
        /// </summary>
        public StoreDeleted()
        {
        }
    }
}