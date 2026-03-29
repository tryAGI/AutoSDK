//HintName: G.Models.TasksCreateResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TasksCreateResponse200
    {
        /// <summary>
        /// A string representing the unique identifier of your video indexing task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// A string representing the unique identifier of the video associated with the specified video indexing task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_id")]
        public string? VideoId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksCreateResponse200" /> class.
        /// </summary>
        /// <param name="id">
        /// A string representing the unique identifier of your video indexing task.
        /// </param>
        /// <param name="videoId">
        /// A string representing the unique identifier of the video associated with the specified video indexing task.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TasksCreateResponse200(
            string? id,
            string? videoId)
        {
            this.Id = id;
            this.VideoId = videoId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksCreateResponse200" /> class.
        /// </summary>
        public TasksCreateResponse200()
        {
        }
    }
}