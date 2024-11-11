//HintName: G.Models.ProtectedBranchPullRequestReviewBypassPullRequestAllowances.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Allow specific users, teams, or apps to bypass pull request requirements.
    /// </summary>
    public sealed partial class ProtectedBranchPullRequestReviewBypassPullRequestAllowances
    {
        /// <summary>
        /// The list of users allowed to bypass pull request requirements.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("users")]
        public global::System.Collections.Generic.IList<global::G.SimpleUser>? Users { get; set; }

        /// <summary>
        /// The list of teams allowed to bypass pull request requirements.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("teams")]
        public global::System.Collections.Generic.IList<global::G.Team>? Teams { get; set; }

        /// <summary>
        /// The list of apps allowed to bypass pull request requirements.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apps")]
        public global::System.Collections.Generic.IList<global::G.Integration>? Apps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectedBranchPullRequestReviewBypassPullRequestAllowances" /> class.
        /// </summary>
        /// <param name="users">
        /// The list of users allowed to bypass pull request requirements.
        /// </param>
        /// <param name="teams">
        /// The list of teams allowed to bypass pull request requirements.
        /// </param>
        /// <param name="apps">
        /// The list of apps allowed to bypass pull request requirements.
        /// </param>
        public ProtectedBranchPullRequestReviewBypassPullRequestAllowances(
            global::System.Collections.Generic.IList<global::G.SimpleUser>? users,
            global::System.Collections.Generic.IList<global::G.Team>? teams,
            global::System.Collections.Generic.IList<global::G.Integration>? apps)
        {
            this.Users = users;
            this.Teams = teams;
            this.Apps = apps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectedBranchPullRequestReviewBypassPullRequestAllowances" /> class.
        /// </summary>
        public ProtectedBranchPullRequestReviewBypassPullRequestAllowances()
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
        public static global::G.ProtectedBranchPullRequestReviewBypassPullRequestAllowances? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ProtectedBranchPullRequestReviewBypassPullRequestAllowances>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.ProtectedBranchPullRequestReviewBypassPullRequestAllowances?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.ProtectedBranchPullRequestReviewBypassPullRequestAllowances?>(serializer.Deserialize<global::G.ProtectedBranchPullRequestReviewBypassPullRequestAllowances>(jsonReader));
        }

    }
}