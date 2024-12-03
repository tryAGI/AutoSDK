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
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// Name of the tag<br/>
        /// Example: v0.0.1
        /// </summary>
        /// <example>v0.0.1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tag { get; set; }

        /// <summary>
        /// Example: 940bd336248efae0f9ee5bc7b2d5c985887b16ac
        /// </summary>
        /// <example>940bd336248efae0f9ee5bc7b2d5c985887b16ac</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha { get; set; }

        /// <summary>
        /// URL for the tag<br/>
        /// Example: https://api.github.com/repositories/42/git/tags/940bd336248efae0f9ee5bc7b2d5c985887b16ac
        /// </summary>
        /// <example>https://api.github.com/repositories/42/git/tags/940bd336248efae0f9ee5bc7b2d5c985887b16ac</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Message describing the purpose of the tag<br/>
        /// Example: Initial public release
        /// </summary>
        /// <example>Initial public release</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tagger")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GitTagTagger Tagger { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GitTagObject Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verification")]
        public global::G.Verification? Verification { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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