//HintName: G.Models.DeleteGraphResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteGraphResponse
    {
        /// <summary>
        /// A unique identifier of the deleted Knowledge Graph.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Indicates whether the Knowledge Graph was successfully deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteGraphResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier of the deleted Knowledge Graph.
        /// </param>
        /// <param name="deleted">
        /// Indicates whether the Knowledge Graph was successfully deleted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteGraphResponse(
            global::System.Guid id,
            bool deleted)
        {
            this.Id = id;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteGraphResponse" /> class.
        /// </summary>
        public DeleteGraphResponse()
        {
        }
    }
}