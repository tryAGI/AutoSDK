//HintName: G.Models.ApiKeyDeleted.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response model for deleting an API key.
    /// </summary>
    public sealed partial class ApiKeyDeleted
    {
        /// <summary>
        /// The ID of the deleted API key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Whether the API key was deleted
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Deleted { get; set; } = default!;

        /// <summary>
        /// The type of the object deleted<br/>
        /// Default Value: api_key
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyDeleted" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the deleted API key
        /// </param>
        /// <param name="deleted">
        /// Whether the API key was deleted
        /// </param>
        /// <param name="object">
        /// The type of the object deleted<br/>
        /// Default Value: api_key
        /// </param>
        public ApiKeyDeleted(
            string id,
            bool deleted,
            string? @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Deleted = deleted;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyDeleted" /> class.
        /// </summary>
        public ApiKeyDeleted()
        {
        }
    }
}