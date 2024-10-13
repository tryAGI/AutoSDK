//HintName: G.Models.ReposCreateDeploymentStatusRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposCreateDeploymentStatusRequest
    {
        /// <summary>
        /// The state of the status. When you set a transient deployment to `inactive`, the deployment will be shown as `destroyed` in GitHub.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ReposCreateDeploymentStatusRequestState State { get; set; } = default!;

        /// <summary>
        /// The target URL to associate with this status. This URL should contain output to keep the user updated while the task is running or serve as historical information for what happened in the deployment. **Note:** It's recommended to use the `log_url` parameter, which replaces `target_url`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_url")]
        public string? TargetUrl { get; set; }

        /// <summary>
        /// The full URL of the deployment's output. This parameter replaces `target_url`. We will continue to accept `target_url` to support legacy uses, but we recommend replacing `target_url` with `log_url`. Setting `log_url` will automatically set `target_url` to the same value. Default: `""`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("log_url")]
        public string? LogUrl { get; set; }

        /// <summary>
        /// A short description of the status. The maximum description length is 140 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Name for the target deployment environment, which can be changed when setting a deploy status. For example, `production`, `staging`, or `qa`. If not defined, the environment of the previous status on the deployment will be used, if it exists. Otherwise, the environment of the deployment will be used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// Sets the URL for accessing your environment. Default: `""`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environment_url")]
        public string? EnvironmentUrl { get; set; }

        /// <summary>
        /// Adds a new `inactive` status to all prior non-transient, non-production environment deployments with the same repository and `environment` name as the created status's deployment. An `inactive` status is only added to deployments that had a `success` state. Default: `true`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auto_inactive")]
        public bool? AutoInactive { get; set; }

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
        public static global::G.ReposCreateDeploymentStatusRequest? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ReposCreateDeploymentStatusRequest>(
                json,
                jsonSerializerOptions);
        }

    }
}