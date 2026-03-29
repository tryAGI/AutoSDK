//HintName: G.Models.RenameVideoRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RenameVideoRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VideoName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RenameVideoRequest" /> class.
        /// </summary>
        /// <param name="videoName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RenameVideoRequest(
            string videoName)
        {
            this.VideoName = videoName ?? throw new global::System.ArgumentNullException(nameof(videoName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenameVideoRequest" /> class.
        /// </summary>
        public RenameVideoRequest()
        {
        }
    }
}