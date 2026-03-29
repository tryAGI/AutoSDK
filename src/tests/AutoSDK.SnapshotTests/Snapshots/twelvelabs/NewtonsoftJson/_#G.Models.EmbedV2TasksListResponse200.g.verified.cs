//HintName: G.Models.EmbedV2TasksListResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbedV2TasksListResponse200
    {
        /// <summary>
        /// An array that contains up to `page_limit` embedding tasks.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::System.Collections.Generic.IList<global::G.MediaEmbeddingTask>? Data { get; set; }

        /// <summary>
        /// An object that provides information about pagination.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_info")]
        public global::G.EmbedV2TasksGetResponsesContentApplicationJsonSchemaPageInfo? PageInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedV2TasksListResponse200" /> class.
        /// </summary>
        /// <param name="data">
        /// An array that contains up to `page_limit` embedding tasks.
        /// </param>
        /// <param name="pageInfo">
        /// An object that provides information about pagination.
        /// </param>
        public EmbedV2TasksListResponse200(
            global::System.Collections.Generic.IList<global::G.MediaEmbeddingTask>? data,
            global::G.EmbedV2TasksGetResponsesContentApplicationJsonSchemaPageInfo? pageInfo)
        {
            this.Data = data;
            this.PageInfo = pageInfo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedV2TasksListResponse200" /> class.
        /// </summary>
        public EmbedV2TasksListResponse200()
        {
        }
    }
}