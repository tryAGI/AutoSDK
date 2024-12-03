//HintName: G.Models.GitTag.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metadata for a Git tag
    /// </summary>
    public sealed partial class GitTag
    {
        /// <summary>
        /// Example: MDM6VGFnOTQwYmQzMzYyNDhlZmFlMGY5ZWU1YmM3YjJkNWM5ODU4ODdiMTZhYw==
        /// </summary>
        /// <example>MDM6VGFnOTQwYmQzMzYyNDhlZmFlMGY5ZWU1YmM3YjJkNWM5ODU4ODdiMTZhYw==</example>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// Name of the tag<br/>
        /// Example: v0.0.1
        /// </summary>
        /// <example>v0.0.1</example>
        [global::Newtonsoft.Json.JsonProperty("tag", Required = global::Newtonsoft.Json.Required.Always)]
        public string Tag { get; set; } = default!;

        /// <summary>
        /// Example: 940bd336248efae0f9ee5bc7b2d5c985887b16ac
        /// </summary>
        /// <example>940bd336248efae0f9ee5bc7b2d5c985887b16ac</example>
        [global::Newtonsoft.Json.JsonProperty("sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sha { get; set; } = default!;

        /// <summary>
        /// URL for the tag<br/>
        /// Example: https://api.github.com/repositories/42/git/tags/940bd336248efae0f9ee5bc7b2d5c985887b16ac
        /// </summary>
        /// <example>https://api.github.com/repositories/42/git/tags/940bd336248efae0f9ee5bc7b2d5c985887b16ac</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Message describing the purpose of the tag<br/>
        /// Example: Initial public release
        /// </summary>
        /// <example>Initial public release</example>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tagger", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GitTagTagger Tagger { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GitTagObject Object { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("verification")]
        public global::G.Verification? Verification { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GitTag" /> class.
        /// </summary>
        /// <param name="nodeId">
        /// Example: MDM6VGFnOTQwYmQzMzYyNDhlZmFlMGY5ZWU1YmM3YjJkNWM5ODU4ODdiMTZhYw==
        /// </param>
        /// <param name="tag">
        /// Name of the tag<br/>
        /// Example: v0.0.1
        /// </param>
        /// <param name="sha">
        /// Example: 940bd336248efae0f9ee5bc7b2d5c985887b16ac
        /// </param>
        /// <param name="url">
        /// URL for the tag<br/>
        /// Example: https://api.github.com/repositories/42/git/tags/940bd336248efae0f9ee5bc7b2d5c985887b16ac
        /// </param>
        /// <param name="message">
        /// Message describing the purpose of the tag<br/>
        /// Example: Initial public release
        /// </param>
        /// <param name="tagger"></param>
        /// <param name="object"></param>
        /// <param name="verification"></param>
        public GitTag(
            string nodeId,
            string tag,
            string sha,
            string url,
            string message,
            global::G.GitTagTagger tagger,
            global::G.GitTagObject @object,
            global::G.Verification? verification)
        {
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Tag = tag ?? throw new global::System.ArgumentNullException(nameof(tag));
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Tagger = tagger ?? throw new global::System.ArgumentNullException(nameof(tagger));
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.Verification = verification;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GitTag" /> class.
        /// </summary>
        public GitTag()
        {
        }
    }
}