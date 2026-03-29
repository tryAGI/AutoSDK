//HintName: G.Models.CreateFileResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response for `CreateFile`.
    /// </summary>
    public sealed partial class CreateFileResponse
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
        /// Initializes a new instance of the <see cref="CreateFileResponse" /> class.
        /// </summary>
        /// <param name="file">
        /// A file uploaded to the API. Next ID: 15
        /// </param>
        public CreateFileResponse(
            global::G.File? file)
        {
            this.File = file;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFileResponse" /> class.
        /// </summary>
        public CreateFileResponse()
        {
        }
    }
}