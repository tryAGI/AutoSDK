//HintName: G.Models.TextTo3DTask.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextTo3DTask
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// text-to-3d-preview or text-to-3d-refine
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_urls")]
        public global::G.ModelUrls? ModelUrls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("art_style")]
        public string? ArtStyle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("texture_prompt")]
        public string? TexturePrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("texture_image_url")]
        public string? TextureImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thumbnail_url")]
        public string? ThumbnailUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("progress")]
        public int? Progress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.TaskStatusJsonConverter))]
        public global::G.TaskStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("texture_urls")]
        public global::System.Collections.Generic.IList<global::G.TextureUrlSet>? TextureUrls { get; set; }

        /// <summary>
        /// Milliseconds since epoch
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at")]
        public long? StartedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finished_at")]
        public long? FinishedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at")]
        public long? ExpiresAt { get; set; }

        /// <summary>
        /// Queue position when PENDING
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preceding_tasks")]
        public int? PrecedingTasks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task_error")]
        public global::G.TaskError? TaskError { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextTo3DTask" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type">
        /// text-to-3d-preview or text-to-3d-refine
        /// </param>
        /// <param name="modelUrls"></param>
        /// <param name="prompt"></param>
        /// <param name="artStyle"></param>
        /// <param name="texturePrompt"></param>
        /// <param name="textureImageUrl"></param>
        /// <param name="thumbnailUrl"></param>
        /// <param name="progress"></param>
        /// <param name="status"></param>
        /// <param name="textureUrls"></param>
        /// <param name="startedAt">
        /// Milliseconds since epoch
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="finishedAt"></param>
        /// <param name="expiresAt"></param>
        /// <param name="precedingTasks">
        /// Queue position when PENDING
        /// </param>
        /// <param name="taskError"></param>
        public TextTo3DTask(
            string? id,
            string? type,
            global::G.ModelUrls? modelUrls,
            string? prompt,
            string? artStyle,
            string? texturePrompt,
            string? textureImageUrl,
            string? thumbnailUrl,
            int? progress,
            global::G.TaskStatus? status,
            global::System.Collections.Generic.IList<global::G.TextureUrlSet>? textureUrls,
            long? startedAt,
            long? createdAt,
            long? finishedAt,
            long? expiresAt,
            int? precedingTasks,
            global::G.TaskError? taskError)
        {
            this.Id = id;
            this.Type = type;
            this.ModelUrls = modelUrls;
            this.Prompt = prompt;
            this.ArtStyle = artStyle;
            this.TexturePrompt = texturePrompt;
            this.TextureImageUrl = textureImageUrl;
            this.ThumbnailUrl = thumbnailUrl;
            this.Progress = progress;
            this.Status = status;
            this.TextureUrls = textureUrls;
            this.StartedAt = startedAt;
            this.CreatedAt = createdAt;
            this.FinishedAt = finishedAt;
            this.ExpiresAt = expiresAt;
            this.PrecedingTasks = precedingTasks;
            this.TaskError = taskError;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextTo3DTask" /> class.
        /// </summary>
        public TextTo3DTask()
        {
        }
    }
}