//HintName: G.Models.DeleteFileResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteFileResponse
    {
        /// <summary>
        /// A unique identifier of the deleted file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Indicates whether the file was successfully deleted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Deleted { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFileResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier of the deleted file.
        /// </param>
        /// <param name="deleted">
        /// Indicates whether the file was successfully deleted.
        /// </param>
        public DeleteFileResponse(
            string id,
            bool deleted)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteFileResponse" /> class.
        /// </summary>
        public DeleteFileResponse()
        {
        }
    }
}