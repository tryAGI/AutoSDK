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
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tag { get; set; }

        /// <summary>
        /// The tag message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The SHA of the git object this is tagging.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Object { get; set; }

        /// <summary>
        /// The type of the object we're tagging. Normally this is a `commit` but it can also be a `tree` or a `blob`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.GitCreateTagRequestTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required GitCreateTagRequestType Type { get; set; }

        /// <summary>
        /// An object with information about the individual creating the tag.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tagger")]
        public GitCreateTagRequestTagger? Tagger { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}