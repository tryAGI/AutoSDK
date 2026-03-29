//HintName: G.Models.BlueprintList.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BlueprintList
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Project description
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("share_id")]
        public string ShareId { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("short_url")]
        public string ShortUrl { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("task_count")]
        public string TaskCount { get; set; } = default!;

        /// <summary>
        /// Blueprint name. Must be between 3 and 50 characters long.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BlueprintList" /> class.
        /// </summary>
        /// <param name="description">
        /// Project description
        /// </param>
        /// <param name="title">
        /// Blueprint name. Must be between 3 and 50 characters long.
        /// </param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="shareId">
        /// Included only in responses
        /// </param>
        /// <param name="shortUrl">
        /// Included only in responses
        /// </param>
        /// <param name="taskCount">
        /// Included only in responses
        /// </param>
        public BlueprintList(
            string? description,
            string? title,
            global::System.DateTime createdAt = default!,
            int id = default!,
            string shareId = default!,
            string shortUrl = default!,
            string taskCount = default!)
        {
            this.CreatedAt = createdAt;
            this.Description = description;
            this.Id = id;
            this.ShareId = shareId;
            this.ShortUrl = shortUrl;
            this.TaskCount = taskCount;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlueprintList" /> class.
        /// </summary>
        public BlueprintList()
        {
        }
    }
}