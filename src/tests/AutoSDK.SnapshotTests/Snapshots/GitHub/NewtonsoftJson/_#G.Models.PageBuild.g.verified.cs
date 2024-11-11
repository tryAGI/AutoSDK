//HintName: G.Models.PageBuild.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Page Build
    /// </summary>
    public sealed partial class PageBuild
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PageBuildError Error { get; set; } = default!;

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pusher", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NullableSimpleUser? Pusher { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit", Required = global::Newtonsoft.Json.Required.Always)]
        public string Commit { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration", Required = global::Newtonsoft.Json.Required.Always)]
        public int Duration { get; set; } = default!;

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PageBuild" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="status"></param>
        /// <param name="error"></param>
        /// <param name="pusher">
        /// A GitHub user.
        /// </param>
        /// <param name="commit"></param>
        /// <param name="duration"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        public PageBuild(
            string url,
            string status,
            global::G.PageBuildError error,
            global::G.NullableSimpleUser? pusher,
            string commit,
            int duration,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Pusher = pusher ?? throw new global::System.ArgumentNullException(nameof(pusher));
            this.Commit = commit ?? throw new global::System.ArgumentNullException(nameof(commit));
            this.Duration = duration;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PageBuild" /> class.
        /// </summary>
        public PageBuild()
        {
        }
    }
}