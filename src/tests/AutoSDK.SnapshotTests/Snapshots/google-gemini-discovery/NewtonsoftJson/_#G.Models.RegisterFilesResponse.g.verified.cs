//HintName: G.Models.RegisterFilesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response for `RegisterFiles`.
    /// </summary>
    public sealed partial class RegisterFilesResponse
    {
        /// <summary>
        /// The registered files to be used when calling GenerateContent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("files")]
        public global::System.Collections.Generic.IList<global::G.File>? Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterFilesResponse" /> class.
        /// </summary>
        /// <param name="files">
        /// The registered files to be used when calling GenerateContent.
        /// </param>
        public RegisterFilesResponse(
            global::System.Collections.Generic.IList<global::G.File>? files)
        {
            this.Files = files;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterFilesResponse" /> class.
        /// </summary>
        public RegisterFilesResponse()
        {
        }
    }
}