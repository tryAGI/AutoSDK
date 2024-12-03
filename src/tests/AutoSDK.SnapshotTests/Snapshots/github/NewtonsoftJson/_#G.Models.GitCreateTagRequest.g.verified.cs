//HintName: G.Models.GitCreateTagRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GitCreateTagRequest
    {
        /// <summary>
        /// The tag's name. This is typically a version (e.g., "v0.0.1").
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tag", Required = global::Newtonsoft.Json.Required.Always)]
        public string Tag { get; set; } = default!;

        /// <summary>
        /// The tag message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// The SHA of the git object this is tagging.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object", Required = global::Newtonsoft.Json.Required.Always)]
        public string Object { get; set; } = default!;

        /// <summary>
        /// The type of the object we're tagging. Normally this is a `commit` but it can also be a `tree` or a `blob`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GitCreateTagRequestType Type { get; set; } = default!;

        /// <summary>
        /// An object with information about the individual creating the tag.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tagger")]
        public global::G.GitCreateTagRequestTagger? Tagger { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GitCreateTagRequest" /> class.
        /// </summary>
        /// <param name="tag">
        /// The tag's name. This is typically a version (e.g., "v0.0.1").
        /// </param>
        /// <param name="message">
        /// The tag message.
        /// </param>
        /// <param name="object">
        /// The SHA of the git object this is tagging.
        /// </param>
        /// <param name="type">
        /// The type of the object we're tagging. Normally this is a `commit` but it can also be a `tree` or a `blob`.
        /// </param>
        /// <param name="tagger">
        /// An object with information about the individual creating the tag.
        /// </param>
        public GitCreateTagRequest(
            string tag,
            string message,
            string @object,
            global::G.GitCreateTagRequestType type,
            global::G.GitCreateTagRequestTagger? tagger)
        {
            this.Tag = tag ?? throw new global::System.ArgumentNullException(nameof(tag));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.Type = type;
            this.Tagger = tagger;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GitCreateTagRequest" /> class.
        /// </summary>
        public GitCreateTagRequest()
        {
        }
    }
}