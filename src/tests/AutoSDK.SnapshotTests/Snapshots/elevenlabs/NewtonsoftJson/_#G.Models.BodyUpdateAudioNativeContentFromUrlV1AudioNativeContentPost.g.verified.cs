//HintName: G.Models.BodyUpdateAudioNativeContentFromUrlV1AudioNativeContentPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUpdateAudioNativeContentFromUrlV1AudioNativeContentPost
    {
        /// <summary>
        /// URL of the page to extract content from.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Author used in the player and inserted at the start of the uploaded article. If not provided, the default author set in the Player settings is used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author")]
        public string? Author { get; set; }

        /// <summary>
        /// Title used in the player and inserted at the top of the uploaded article. If not provided, the default title set in the Player settings is used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateAudioNativeContentFromUrlV1AudioNativeContentPost" /> class.
        /// </summary>
        /// <param name="url">
        /// URL of the page to extract content from.
        /// </param>
        /// <param name="author">
        /// Author used in the player and inserted at the start of the uploaded article. If not provided, the default author set in the Player settings is used.
        /// </param>
        /// <param name="title">
        /// Title used in the player and inserted at the top of the uploaded article. If not provided, the default title set in the Player settings is used.
        /// </param>
        public BodyUpdateAudioNativeContentFromUrlV1AudioNativeContentPost(
            string url,
            string? author,
            string? title)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Author = author;
            this.Title = title;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateAudioNativeContentFromUrlV1AudioNativeContentPost" /> class.
        /// </summary>
        public BodyUpdateAudioNativeContentFromUrlV1AudioNativeContentPost()
        {
        }
    }
}