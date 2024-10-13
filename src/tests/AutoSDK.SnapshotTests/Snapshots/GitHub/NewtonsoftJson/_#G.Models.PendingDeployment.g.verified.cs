//HintName: G.Models.PendingDeployment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Details of a deployment that is waiting for protection rules to pass
    /// </summary>
    public sealed partial class PendingDeployment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environment", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PendingDeploymentEnvironment Environment { get; set; } = default!;

        /// <summary>
        /// The set duration of the wait timer<br/>
        /// Example: 30
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wait_timer", Required = global::Newtonsoft.Json.Required.Always)]
        public int WaitTimer { get; set; } = default!;

        /// <summary>
        /// The time that the wait timer began.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wait_timer_started_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? WaitTimerStartedAt { get; set; } = default!;

        /// <summary>
        /// Whether the currently authenticated user can approve the deployment<br/>
        /// Example: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_user_can_approve", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CurrentUserCanApprove { get; set; } = default!;

        /// <summary>
        /// The people or teams that may approve jobs that reference the environment. You can list up to six users or teams as reviewers. The reviewers must have at least read access to the repository. Only one of the required reviewers needs to approve the job for it to proceed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reviewers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PendingDeploymentReviewer> Reviewers { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


    #if NET6_0_OR_GREATER
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

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.PendingDeployment? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.PendingDeployment>(
                json,
                jsonSerializerOptions);
        }

    }
}