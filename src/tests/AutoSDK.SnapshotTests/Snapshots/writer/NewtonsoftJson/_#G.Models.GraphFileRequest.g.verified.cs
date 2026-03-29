//HintName: G.Models.GraphFileRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GraphFileRequest
    {
        /// <summary>
        /// The unique identifier of the file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphFileRequest" /> class.
        /// </summary>
        /// <param name="fileId">
        /// The unique identifier of the file.
        /// </param>
        public GraphFileRequest(
            string fileId)
        {
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphFileRequest" /> class.
        /// </summary>
        public GraphFileRequest()
        {
        }
    }
}