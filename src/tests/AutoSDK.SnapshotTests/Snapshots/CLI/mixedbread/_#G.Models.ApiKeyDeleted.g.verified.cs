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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Whether the API key was deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// The type of the object deleted<br/>
        /// Default Value: api_key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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