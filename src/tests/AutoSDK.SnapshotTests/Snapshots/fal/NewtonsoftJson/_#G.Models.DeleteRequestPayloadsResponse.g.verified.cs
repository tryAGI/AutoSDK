//HintName: G.Models.DeleteRequestPayloadsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response containing the results of deleting request payloads and CDN output files
    /// </summary>
    public sealed partial class DeleteRequestPayloadsResponse
    {
        /// <summary>
        /// Array of deletion results for each CDN file associated with the request output
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cdn_delete_results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.DeleteRequestPayloadsResponseCdnDeleteResult> CdnDeleteResults { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRequestPayloadsResponse" /> class.
        /// </summary>
        /// <param name="cdnDeleteResults">
        /// Array of deletion results for each CDN file associated with the request output
        /// </param>
        public DeleteRequestPayloadsResponse(
            global::System.Collections.Generic.IList<global::G.DeleteRequestPayloadsResponseCdnDeleteResult> cdnDeleteResults)
        {
            this.CdnDeleteResults = cdnDeleteResults ?? throw new global::System.ArgumentNullException(nameof(cdnDeleteResults));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRequestPayloadsResponse" /> class.
        /// </summary>
        public DeleteRequestPayloadsResponse()
        {
        }
    }
}