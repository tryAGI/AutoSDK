//HintName: G.Models.ProcessCatalogFilesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProcessCatalogFilesResponse
    {
        /// <summary>
        /// The file uid.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("files", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.File> Files { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessCatalogFilesResponse" /> class.
        /// </summary>
        /// <param name="files">
        /// The file uid.
        /// </param>
        public ProcessCatalogFilesResponse(
            global::System.Collections.Generic.IList<global::G.File> files)
        {
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessCatalogFilesResponse" /> class.
        /// </summary>
        public ProcessCatalogFilesResponse()
        {
        }
    }
}