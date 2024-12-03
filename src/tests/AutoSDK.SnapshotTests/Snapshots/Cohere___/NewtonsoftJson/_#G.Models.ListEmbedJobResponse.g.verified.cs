//HintName: G.Models.ListEmbedJobResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListEmbedJobResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embed_jobs")]
        public global::System.Collections.Generic.IList<global::G.EmbedJob>? EmbedJobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEmbedJobResponse" /> class.
        /// </summary>
        /// <param name="embedJobs"></param>
        public ListEmbedJobResponse(
            global::System.Collections.Generic.IList<global::G.EmbedJob>? embedJobs)
        {
            this.EmbedJobs = embedJobs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListEmbedJobResponse" /> class.
        /// </summary>
        public ListEmbedJobResponse()
        {
        }
    }
}