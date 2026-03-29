//HintName: G.Models.VideoArticle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Representation of an Article with video
    /// </summary>
    public sealed partial class VideoArticle
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type_of")]
        public string? TypeOf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cloudinary_video_url")]
        public string? CloudinaryVideoUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public long? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_duration_in_minutes")]
        public string? VideoDurationInMinutes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_source_url")]
        public string? VideoSourceUrl { get; set; }

        /// <summary>
        /// Author of the article
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::G.VideoArticleUser? User { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoArticle" /> class.
        /// </summary>
        /// <param name="typeOf"></param>
        /// <param name="id"></param>
        /// <param name="path"></param>
        /// <param name="cloudinaryVideoUrl"></param>
        /// <param name="title"></param>
        /// <param name="userId"></param>
        /// <param name="videoDurationInMinutes"></param>
        /// <param name="videoSourceUrl"></param>
        /// <param name="user">
        /// Author of the article
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoArticle(
            string? typeOf,
            long? id,
            string? path,
            string? cloudinaryVideoUrl,
            string? title,
            long? userId,
            string? videoDurationInMinutes,
            string? videoSourceUrl,
            global::G.VideoArticleUser? user)
        {
            this.TypeOf = typeOf;
            this.Id = id;
            this.Path = path;
            this.CloudinaryVideoUrl = cloudinaryVideoUrl;
            this.Title = title;
            this.UserId = userId;
            this.VideoDurationInMinutes = videoDurationInMinutes;
            this.VideoSourceUrl = videoSourceUrl;
            this.User = user;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoArticle" /> class.
        /// </summary>
        public VideoArticle()
        {
        }
    }
}