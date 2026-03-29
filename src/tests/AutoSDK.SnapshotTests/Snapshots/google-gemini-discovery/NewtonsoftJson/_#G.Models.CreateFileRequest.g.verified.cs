//HintName: G.Models.CreateFileRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request for `CreateFile`.
    /// </summary>
    public sealed partial class CreateFileRequest
    {
        /// <summary>
        /// A file uploaded to the API. Next ID: 15
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file")]
        public global::G.File? File { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFileRequest" /> class.
        /// </summary>
        /// <param name="file">
        /// A file uploaded to the API. Next ID: 15
        /// </param>
        public CreateFileRequest(
            global::G.File? file)
        {
            this.File = file;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFileRequest" /> class.
        /// </summary>
        public CreateFileRequest()
        {
        }
    }
}