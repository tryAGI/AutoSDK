//HintName: G.Models.DownloadResultResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DownloadResultResponse
    {
        /// <summary>
        /// The ID of the job
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The URL to download the result file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("download_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string DownloadUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadResultResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the job
        /// </param>
        /// <param name="downloadUrl">
        /// The URL to download the result file
        /// </param>
        public DownloadResultResponse(
            string id,
            string downloadUrl)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.DownloadUrl = downloadUrl ?? throw new global::System.ArgumentNullException(nameof(downloadUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadResultResponse" /> class.
        /// </summary>
        public DownloadResultResponse()
        {
        }
    }
}