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
        [global::System.Text.Json.Serialization.JsonPropertyName("cdn_delete_results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.DeleteRequestPayloadsResponseCdnDeleteResult> CdnDeleteResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteRequestPayloadsResponse" /> class.
        /// </summary>
        /// <param name="cdnDeleteResults">
        /// Array of deletion results for each CDN file associated with the request output
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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