//HintName: G.Models.TaskResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("videos")]
        public global::System.Collections.Generic.IList<global::G.VideoResult>? Videos { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<global::G.ImageResult>? Images { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskResult" /> class.
        /// </summary>
        /// <param name="videos"></param>
        /// <param name="images"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskResult(
            global::System.Collections.Generic.IList<global::G.VideoResult>? videos,
            global::System.Collections.Generic.IList<global::G.ImageResult>? images)
        {
            this.Videos = videos;
            this.Images = images;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskResult" /> class.
        /// </summary>
        public TaskResult()
        {
        }
    }
}