//HintName: G.Models.EmbedTasksCreateResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbedTasksCreateResponse200
    {
        /// <summary>
        /// The unique identifier of the video embedding task. You can use the identifier to:<br/>
        /// - Retrieve the status of your task by invoking the [`GET`](/v1.3/api-reference/create-embeddings-v1/video-embeddings/retrieve-video-embedding-task-status) method of the `/embed/tasks/{task_id}/status` endpoint.<br/>
        /// - Retrieve the embedding by invoking the  [`GET`](/v1.3/api-reference/create-embeddings-v1/video-embeddings/retrieve-video-embeddings) method of the `/embed/tasks/{task_id}` endpoint.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedTasksCreateResponse200" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the video embedding task. You can use the identifier to:<br/>
        /// - Retrieve the status of your task by invoking the [`GET`](/v1.3/api-reference/create-embeddings-v1/video-embeddings/retrieve-video-embedding-task-status) method of the `/embed/tasks/{task_id}/status` endpoint.<br/>
        /// - Retrieve the embedding by invoking the  [`GET`](/v1.3/api-reference/create-embeddings-v1/video-embeddings/retrieve-video-embeddings) method of the `/embed/tasks/{task_id}` endpoint.
        /// </param>
        public EmbedTasksCreateResponse200(
            string? id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedTasksCreateResponse200" /> class.
        /// </summary>
        public EmbedTasksCreateResponse200()
        {
        }
    }
}