﻿//HintName: G.Models.ProtectedBranchPullRequestReviewDismissalRestrictions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProtectedBranchPullRequestReviewDismissalRestrictions
    {
        /// <summary>
        /// The list of users with review dismissal access.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        public global::System.Collections.Generic.IList<global::G.SimpleUser>? Users { get; set; }

        /// <summary>
        /// The list of teams with review dismissal access.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams")]
        public global::System.Collections.Generic.IList<global::G.Team>? Teams { get; set; }

        /// <summary>
        /// The list of apps with review dismissal access.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apps")]
        public global::System.Collections.Generic.IList<global::G.Integration>? Apps { get; set; }

        /// <summary>
        /// Example: "https://api.github.com/repos/the-org/an-org-repo/branches/master/protection/dismissal_restrictions"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Example: "https://api.github.com/repos/the-org/an-org-repo/branches/master/protection/dismissal_restrictions/users"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users_url")]
        public string? UsersUrl { get; set; }

        /// <summary>
        /// Example: "https://api.github.com/repos/the-org/an-org-repo/branches/master/protection/dismissal_restrictions/teams"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams_url")]
        public string? TeamsUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


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
        public static global::G.ProtectedBranchPullRequestReviewDismissalRestrictions? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.ProtectedBranchPullRequestReviewDismissalRestrictions),
                jsonSerializerContext) as global::G.ProtectedBranchPullRequestReviewDismissalRestrictions;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ProtectedBranchPullRequestReviewDismissalRestrictions? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.ProtectedBranchPullRequestReviewDismissalRestrictions>(
                json,
                jsonSerializerOptions);
        }

    }
}