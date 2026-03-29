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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Indicates whether the Knowledge Graph was successfully deleted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Deleted { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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