//HintName: G.Models.TasksListResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TasksListResponse200
    {
        /// <summary>
        /// An array that contains up to `page_limit` tasks.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::System.Collections.Generic.IList<global::G.VideoIndexingTask>? Data { get; set; }

        /// <summary>
        /// An object that provides information about pagination.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_info")]
        public global::G.TasksGetResponsesContentApplicationJsonSchemaPageInfo? PageInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksListResponse200" /> class.
        /// </summary>
        /// <param name="data">
        /// An array that contains up to `page_limit` tasks.
        /// </param>
        /// <param name="pageInfo">
        /// An object that provides information about pagination.
        /// </param>
        public TasksListResponse200(
            global::System.Collections.Generic.IList<global::G.VideoIndexingTask>? data,
            global::G.TasksGetResponsesContentApplicationJsonSchemaPageInfo? pageInfo)
        {
            this.Data = data;
            this.PageInfo = pageInfo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksListResponse200" /> class.
        /// </summary>
        public TasksListResponse200()
        {
        }
    }
}