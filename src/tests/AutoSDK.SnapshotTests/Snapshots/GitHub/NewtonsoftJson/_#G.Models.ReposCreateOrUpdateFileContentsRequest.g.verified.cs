//HintName: G.Models.ReposCreateOrUpdateFileContentsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposCreateOrUpdateFileContentsRequest
    {
        /// <summary>
        /// The commit message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// The new file content, using Base64 encoding.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// **Required if you are updating a file**. The blob SHA of the file being replaced.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sha")]
        public string? Sha { get; set; }

        /// <summary>
        /// The branch name. Default: the repository’s default branch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("branch")]
        public string? Branch { get; set; }

        /// <summary>
        /// The person that committed the file. Default: the authenticated user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("committer")]
        public global::G.ReposCreateOrUpdateFileContentsRequestCommitter? Committer { get; set; }

        /// <summary>
        /// The author of the file. Default: The `committer` or the authenticated user if you omit `committer`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author")]
        public global::G.ReposCreateOrUpdateFileContentsRequestAuthor? Author { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


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
        public static global::G.ReposCreateOrUpdateFileContentsRequest? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ReposCreateOrUpdateFileContentsRequest>(
                json,
                jsonSerializerOptions);
        }

    }
}