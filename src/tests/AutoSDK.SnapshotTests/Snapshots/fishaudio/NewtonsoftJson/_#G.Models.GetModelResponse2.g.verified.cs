//HintName: G.Models.GetModelResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetModelResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetModelResponseTypeJsonConverter))]
        public global::G.GetModelResponseType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cover_image", Required = global::Newtonsoft.Json.Required.Always)]
        public string CoverImage { get; set; } = default!;

        /// <summary>
        /// Default Value: full
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("train_mode")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetModelResponseTrainModeJsonConverter))]
        public global::G.GetModelResponseTrainMode? TrainMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetModelResponseStateJsonConverter))]
        public global::G.GetModelResponseState State { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Tags { get; set; } = default!;

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("samples")]
        public global::System.Collections.Generic.IList<global::G.SampleEntity>? Samples { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("languages")]
        public global::System.Collections.Generic.IList<string>? Languages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("visibility", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetModelResponseVisibilityJsonConverter))]
        public global::G.GetModelResponseVisibility Visibility { get; set; } = default!;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lock_visibility")]
        public bool? LockVisibility { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("like_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int LikeCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mark_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int MarkCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shared_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int SharedCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("task_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int TaskCount { get; set; } = default!;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unliked")]
        public bool? Unliked { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("liked")]
        public bool? Liked { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("marked")]
        public bool? Marked { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AuthorEntity Author { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelResponse2" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="coverImage"></param>
        /// <param name="state"></param>
        /// <param name="tags"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="visibility"></param>
        /// <param name="likeCount"></param>
        /// <param name="markCount"></param>
        /// <param name="sharedCount"></param>
        /// <param name="taskCount"></param>
        /// <param name="author"></param>
        /// <param name="trainMode">
        /// Default Value: full
        /// </param>
        /// <param name="samples">
        /// Default Value: []
        /// </param>
        /// <param name="languages">
        /// Default Value: []
        /// </param>
        /// <param name="lockVisibility">
        /// Default Value: false
        /// </param>
        /// <param name="unliked">
        /// Default Value: false
        /// </param>
        /// <param name="liked">
        /// Default Value: false
        /// </param>
        /// <param name="marked">
        /// Default Value: false
        /// </param>
        public GetModelResponse2(
            string id,
            global::G.GetModelResponseType type,
            string title,
            string description,
            string coverImage,
            global::G.GetModelResponseState state,
            global::System.Collections.Generic.IList<string> tags,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::G.GetModelResponseVisibility visibility,
            int likeCount,
            int markCount,
            int sharedCount,
            int taskCount,
            global::G.AuthorEntity author,
            global::G.GetModelResponseTrainMode? trainMode,
            global::System.Collections.Generic.IList<global::G.SampleEntity>? samples,
            global::System.Collections.Generic.IList<string>? languages,
            bool? lockVisibility,
            bool? unliked,
            bool? liked,
            bool? marked)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.CoverImage = coverImage ?? throw new global::System.ArgumentNullException(nameof(coverImage));
            this.TrainMode = trainMode;
            this.State = state;
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.Samples = samples;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Languages = languages;
            this.Visibility = visibility;
            this.LockVisibility = lockVisibility;
            this.LikeCount = likeCount;
            this.MarkCount = markCount;
            this.SharedCount = sharedCount;
            this.TaskCount = taskCount;
            this.Unliked = unliked;
            this.Liked = liked;
            this.Marked = marked;
            this.Author = author ?? throw new global::System.ArgumentNullException(nameof(author));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetModelResponse2" /> class.
        /// </summary>
        public GetModelResponse2()
        {
        }
    }
}