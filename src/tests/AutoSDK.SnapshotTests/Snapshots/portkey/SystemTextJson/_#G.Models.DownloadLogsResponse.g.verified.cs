//HintName: G.Models.DownloadLogsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DownloadLogsResponse
    {
        /// <summary>
        /// A pre-signed URL for downloading the exported logs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signed_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SignedUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadLogsResponse" /> class.
        /// </summary>
        /// <param name="signedUrl">
        /// A pre-signed URL for downloading the exported logs
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DownloadLogsResponse(
            string signedUrl)
        {
            this.SignedUrl = signedUrl ?? throw new global::System.ArgumentNullException(nameof(signedUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadLogsResponse" /> class.
        /// </summary>
        public DownloadLogsResponse()
        {
        }
    }
}