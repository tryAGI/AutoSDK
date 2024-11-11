//HintName: G.Models.GistsGetResponseBlock.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GistsGetResponseBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GistsGetResponseBlock" /> class.
        /// </summary>
        /// <param name="reason"></param>
        /// <param name="createdAt"></param>
        /// <param name="htmlUrl"></param>
        public GistsGetResponseBlock(
            string? reason,
            string? createdAt,
            string? htmlUrl)
        {
            this.Reason = reason;
            this.CreatedAt = createdAt;
            this.HtmlUrl = htmlUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GistsGetResponseBlock" /> class.
        /// </summary>
        public GistsGetResponseBlock()
        {
        }
    }
}