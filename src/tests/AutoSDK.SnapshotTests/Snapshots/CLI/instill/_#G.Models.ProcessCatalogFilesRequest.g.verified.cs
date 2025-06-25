//HintName: G.Models.ProcessCatalogFilesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProcessCatalogFilesRequest
    {
        /// <summary>
        /// The file uid.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileUids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> FileUids { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessCatalogFilesRequest" /> class.
        /// </summary>
        /// <param name="fileUids">
        /// The file uid.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProcessCatalogFilesRequest(
            global::System.Collections.Generic.IList<string> fileUids)
        {
            this.FileUids = fileUids ?? throw new global::System.ArgumentNullException(nameof(fileUids));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessCatalogFilesRequest" /> class.
        /// </summary>
        public ProcessCatalogFilesRequest()
        {
        }
    }
}