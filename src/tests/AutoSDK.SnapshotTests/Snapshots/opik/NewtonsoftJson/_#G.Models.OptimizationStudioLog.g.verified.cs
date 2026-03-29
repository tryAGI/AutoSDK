//HintName: G.Models.OptimizationStudioLog.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OptimizationStudioLog
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_modified")]
        public global::System.DateTime? LastModified { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizationStudioLog" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="lastModified"></param>
        /// <param name="expiresAt"></param>
        public OptimizationStudioLog(
            string? url,
            global::System.DateTime? lastModified,
            global::System.DateTime? expiresAt)
        {
            this.Url = url;
            this.LastModified = lastModified;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizationStudioLog" /> class.
        /// </summary>
        public OptimizationStudioLog()
        {
        }
    }
}