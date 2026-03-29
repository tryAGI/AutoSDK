//HintName: G.Models.ModelEntity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelEntity
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ModelEntityTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ModelEntityType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CoverImage { get; set; }

        /// <summary>
        /// Default Value: full
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("train_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ModelEntityTrainModeJsonConverter))]
        public global::G.ModelEntityTrainMode? TrainMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ModelEntityStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ModelEntityState State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("samples")]
        public global::System.Collections.Generic.IList<global::G.SampleEntity>? Samples { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<string>? Languages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ModelEntityVisibilityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ModelEntityVisibility Visibility { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lock_visibility")]
        public bool? LockVisibility { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("like_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LikeCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mark_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MarkCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shared_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SharedCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TaskCount { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unliked")]
        public bool? Unliked { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("liked")]
        public bool? Liked { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("marked")]
        public bool? Marked { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AuthorEntity Author { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelEntity" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelEntity(
            string id,
            global::G.ModelEntityType type,
            string title,
            string description,
            string coverImage,
            global::G.ModelEntityState state,
            global::System.Collections.Generic.IList<string> tags,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::G.ModelEntityVisibility visibility,
            int likeCount,
            int markCount,
            int sharedCount,
            int taskCount,
            global::G.AuthorEntity author,
            global::G.ModelEntityTrainMode? trainMode,
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
        /// Initializes a new instance of the <see cref="ModelEntity" /> class.
        /// </summary>
        public ModelEntity()
        {
        }
    }
}