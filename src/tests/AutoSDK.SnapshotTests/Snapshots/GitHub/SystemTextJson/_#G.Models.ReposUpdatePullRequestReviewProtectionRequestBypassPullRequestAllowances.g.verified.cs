//HintName: G.Models.ReposUpdatePullRequestReviewProtectionRequestBypassPullRequestAllowances.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Allow specific users, teams, or apps to bypass pull request requirements.
    /// </summary>
    public sealed partial class ReposUpdatePullRequestReviewProtectionRequestBypassPullRequestAllowances
    {
        /// <summary>
        /// The list of user `login`s allowed to bypass pull request requirements.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        public global::System.Collections.Generic.IList<string>? Users { get; set; }

        /// <summary>
        /// The list of team `slug`s allowed to bypass pull request requirements.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams")]
        public global::System.Collections.Generic.IList<string>? Teams { get; set; }

        /// <summary>
        /// The list of app `slug`s allowed to bypass pull request requirements.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apps")]
        public global::System.Collections.Generic.IList<string>? Apps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdatePullRequestReviewProtectionRequestBypassPullRequestAllowances" /> class.
        /// </summary>
        /// <param name="users">
        /// The list of user `login`s allowed to bypass pull request requirements.
        /// </param>
        /// <param name="teams">
        /// The list of team `slug`s allowed to bypass pull request requirements.
        /// </param>
        /// <param name="apps">
        /// The list of app `slug`s allowed to bypass pull request requirements.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ReposUpdatePullRequestReviewProtectionRequestBypassPullRequestAllowances(
            global::System.Collections.Generic.IList<string>? users,
            global::System.Collections.Generic.IList<string>? teams,
            global::System.Collections.Generic.IList<string>? apps)
        {
            this.Users = users;
            this.Teams = teams;
            this.Apps = apps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposUpdatePullRequestReviewProtectionRequestBypassPullRequestAllowances" /> class.
        /// </summary>
        public ReposUpdatePullRequestReviewProtectionRequestBypassPullRequestAllowances()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.ReposUpdatePullRequestReviewProtectionRequestBypassPullRequestAllowances? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.ReposUpdatePullRequestReviewProtectionRequestBypassPullRequestAllowances),
                jsonSerializerContext) as global::G.ReposUpdatePullRequestReviewProtectionRequestBypassPullRequestAllowances;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ReposUpdatePullRequestReviewProtectionRequestBypassPullRequestAllowances? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.ReposUpdatePullRequestReviewProtectionRequestBypassPullRequestAllowances>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.ReposUpdatePullRequestReviewProtectionRequestBypassPullRequestAllowances?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.ReposUpdatePullRequestReviewProtectionRequestBypassPullRequestAllowances),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.ReposUpdatePullRequestReviewProtectionRequestBypassPullRequestAllowances;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.ReposUpdatePullRequestReviewProtectionRequestBypassPullRequestAllowances?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.ReposUpdatePullRequestReviewProtectionRequestBypassPullRequestAllowances?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}