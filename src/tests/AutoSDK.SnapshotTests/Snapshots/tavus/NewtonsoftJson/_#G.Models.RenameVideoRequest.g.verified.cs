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
        [global::Newtonsoft.Json.JsonProperty("video_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string VideoName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RenameVideoRequest" /> class.
        /// </summary>
        /// <param name="videoName"></param>
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