//HintName: G.Models.GetArtifactResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetArtifactResponse
    {
        /// <summary>
        /// Temporary 15-minute presigned S3 URL for downloading the artifact<br/>
        /// Example: https://cloud-agent-artifacts.s3.us-east-1.amazonaws.com/...
        /// </summary>
        /// <example>https://cloud-agent-artifacts.s3.us-east-1.amazonaws.com/...</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// When the presigned download URL expires<br/>
        /// Example: 2026-03-04T22:30:00.000Z
        /// </summary>
        /// <example>2026-03-04T22:30:00.000Z</example>
        [global::Newtonsoft.Json.JsonProperty("expiresAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime ExpiresAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetArtifactResponse" /> class.
        /// </summary>
        /// <param name="url">
        /// Temporary 15-minute presigned S3 URL for downloading the artifact<br/>
        /// Example: https://cloud-agent-artifacts.s3.us-east-1.amazonaws.com/...
        /// </param>
        /// <param name="expiresAt">
        /// When the presigned download URL expires<br/>
        /// Example: 2026-03-04T22:30:00.000Z
        /// </param>
        public GetArtifactResponse(
            string url,
            global::System.DateTime expiresAt)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetArtifactResponse" /> class.
        /// </summary>
        public GetArtifactResponse()
        {
        }
    }
}