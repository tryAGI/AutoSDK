//HintName: G.Models.SecretScanningLocationDiscussionComment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a 'discussion_comment' secret scanning location type. This location type shows that a secret was detected in a comment on a discussion.
    /// </summary>
    public sealed partial class SecretScanningLocationDiscussionComment
    {
        /// <summary>
        /// The API URL to get the discussion comment where the secret was detected.<br/>
        /// Example: https://github.com/community/community/discussions/39082#discussioncomment-4158232
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("discussion_comment_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string DiscussionCommentUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningLocationDiscussionComment" /> class.
        /// </summary>
        /// <param name="discussionCommentUrl">
        /// The API URL to get the discussion comment where the secret was detected.<br/>
        /// Example: https://github.com/community/community/discussions/39082#discussioncomment-4158232
        /// </param>
        public SecretScanningLocationDiscussionComment(
            string discussionCommentUrl)
        {
            this.DiscussionCommentUrl = discussionCommentUrl ?? throw new global::System.ArgumentNullException(nameof(discussionCommentUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningLocationDiscussionComment" /> class.
        /// </summary>
        public SecretScanningLocationDiscussionComment()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.SecretScanningLocationDiscussionComment? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.SecretScanningLocationDiscussionComment>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.SecretScanningLocationDiscussionComment?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.SecretScanningLocationDiscussionComment?>(serializer.Deserialize<global::G.SecretScanningLocationDiscussionComment>(jsonReader));
        }

    }
}