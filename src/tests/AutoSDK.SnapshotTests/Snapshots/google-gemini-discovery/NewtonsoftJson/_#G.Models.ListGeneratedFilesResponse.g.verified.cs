//HintName: G.Models.ListGeneratedFilesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response for `ListGeneratedFiles`.
    /// </summary>
    public sealed partial class ListGeneratedFilesResponse
    {
        /// <summary>
        /// The list of `GeneratedFile`s.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generatedFiles")]
        public global::System.Collections.Generic.IList<global::G.GeneratedFile>? GeneratedFiles { get; set; }

        /// <summary>
        /// A token that can be sent as a `page_token` into a subsequent `ListGeneratedFiles` call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListGeneratedFilesResponse" /> class.
        /// </summary>
        /// <param name="generatedFiles">
        /// The list of `GeneratedFile`s.
        /// </param>
        /// <param name="nextPageToken">
        /// A token that can be sent as a `page_token` into a subsequent `ListGeneratedFiles` call.
        /// </param>
        public ListGeneratedFilesResponse(
            global::System.Collections.Generic.IList<global::G.GeneratedFile>? generatedFiles,
            string? nextPageToken)
        {
            this.GeneratedFiles = generatedFiles;
            this.NextPageToken = nextPageToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListGeneratedFilesResponse" /> class.
        /// </summary>
        public ListGeneratedFilesResponse()
        {
        }
    }
}