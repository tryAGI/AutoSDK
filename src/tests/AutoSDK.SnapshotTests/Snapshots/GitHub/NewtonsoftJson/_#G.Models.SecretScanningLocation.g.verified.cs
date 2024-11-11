//HintName: G.Models.SecretScanningLocation.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SecretScanningLocation
    {
        /// <summary>
        /// The location type. Because secrets may be found in different types of resources (ie. code, comments, issues, pull requests, discussions), this field identifies the type of resource where the secret was found.<br/>
        /// Example: commit
        /// </summary>
        /// <example>commit</example>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.SecretScanningLocationType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details")]
        public global::G.OneOf<global::G.SecretScanningLocationCommit, global::G.SecretScanningLocationWikiCommit, global::G.SecretScanningLocationIssueTitle, global::G.SecretScanningLocationIssueBody, global::G.SecretScanningLocationIssueComment, global::G.SecretScanningLocationDiscussionTitle, global::G.SecretScanningLocationDiscussionBody, global::G.SecretScanningLocationDiscussionComment, global::G.SecretScanningLocationPullRequestTitle, global::G.SecretScanningLocationPullRequestBody, global::G.SecretScanningLocationPullRequestComment, global::G.SecretScanningLocationPullRequestReview, global::G.SecretScanningLocationPullRequestReviewComment>? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningLocation" /> class.
        /// </summary>
        /// <param name="type">
        /// The location type. Because secrets may be found in different types of resources (ie. code, comments, issues, pull requests, discussions), this field identifies the type of resource where the secret was found.<br/>
        /// Example: commit
        /// </param>
        /// <param name="details"></param>
        public SecretScanningLocation(
            global::G.SecretScanningLocationType? type,
            global::G.OneOf<global::G.SecretScanningLocationCommit, global::G.SecretScanningLocationWikiCommit, global::G.SecretScanningLocationIssueTitle, global::G.SecretScanningLocationIssueBody, global::G.SecretScanningLocationIssueComment, global::G.SecretScanningLocationDiscussionTitle, global::G.SecretScanningLocationDiscussionBody, global::G.SecretScanningLocationDiscussionComment, global::G.SecretScanningLocationPullRequestTitle, global::G.SecretScanningLocationPullRequestBody, global::G.SecretScanningLocationPullRequestComment, global::G.SecretScanningLocationPullRequestReview, global::G.SecretScanningLocationPullRequestReviewComment>? details)
        {
            this.Type = type;
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretScanningLocation" /> class.
        /// </summary>
        public SecretScanningLocation()
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
        public static global::G.SecretScanningLocation? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.SecretScanningLocation>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.SecretScanningLocation?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.SecretScanningLocation?>(serializer.Deserialize<global::G.SecretScanningLocation>(jsonReader));
        }

    }
}