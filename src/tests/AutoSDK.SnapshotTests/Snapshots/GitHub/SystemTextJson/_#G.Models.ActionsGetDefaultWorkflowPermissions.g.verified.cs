//HintName: G.Models.ActionsGetDefaultWorkflowPermissions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsGetDefaultWorkflowPermissions
    {
        /// <summary>
        /// The default workflow permissions granted to the GITHUB_TOKEN when running workflows.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_workflow_permissions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ActionsDefaultWorkflowPermissionsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ActionsDefaultWorkflowPermissions DefaultWorkflowPermissions { get; set; }

        /// <summary>
        /// Whether GitHub Actions can approve pull requests. Enabling this can be a security risk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_approve_pull_request_reviews")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CanApprovePullRequestReviews { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

    #if NET6_0_OR_GREATER
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

        public static global::G.ActionsGetDefaultWorkflowPermissions? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.ActionsGetDefaultWorkflowPermissions),
                jsonSerializerContext) as global::G.ActionsGetDefaultWorkflowPermissions;
        }

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ActionsGetDefaultWorkflowPermissions? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.ActionsGetDefaultWorkflowPermissions>(
                json,
                jsonSerializerOptions);
        }

    }
}