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
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PendingDeploymentEnvironment Environment { get; set; }

        /// <summary>
        /// The set duration of the wait timer<br/>
        /// Example: 30
        /// </summary>
        /// <example>30</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("wait_timer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WaitTimer { get; set; }

        /// <summary>
        /// The time that the wait timer began.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wait_timer_started_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? WaitTimerStartedAt { get; set; }

        /// <summary>
        /// Whether the currently authenticated user can approve the deployment<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_user_can_approve")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CurrentUserCanApprove { get; set; }

        /// <summary>
        /// The people or teams that may approve jobs that reference the environment. You can list up to six users or teams as reviewers. The reviewers must have at least read access to the repository. Only one of the required reviewers needs to approve the job for it to proceed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reviewers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.PendingDeploymentReviewer> Reviewers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PendingDeployment" /> class.
        /// </summary>
        /// <param name="environment"></param>
        /// <param name="waitTimer">
        /// The set duration of the wait timer<br/>
        /// Example: 30
        /// </param>
        /// <param name="waitTimerStartedAt">
        /// The time that the wait timer began.
        /// </param>
        /// <param name="currentUserCanApprove">
        /// Whether the currently authenticated user can approve the deployment<br/>
        /// Example: true
        /// </param>
        /// <param name="reviewers">
        /// The people or teams that may approve jobs that reference the environment. You can list up to six users or teams as reviewers. The reviewers must have at least read access to the repository. Only one of the required reviewers needs to approve the job for it to proceed.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PendingDeployment(
            global::G.PendingDeploymentEnvironment environment,
            int waitTimer,
            global::System.DateTime? waitTimerStartedAt,
            bool currentUserCanApprove,
            global::System.Collections.Generic.IList<global::G.PendingDeploymentReviewer> reviewers)
        {
            this.Environment = environment ?? throw new global::System.ArgumentNullException(nameof(environment));
            this.WaitTimer = waitTimer;
            this.WaitTimerStartedAt = waitTimerStartedAt;
            this.CurrentUserCanApprove = currentUserCanApprove;
            this.Reviewers = reviewers ?? throw new global::System.ArgumentNullException(nameof(reviewers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PendingDeployment" /> class.
        /// </summary>
        public PendingDeployment()
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
        public static global::G.PendingDeployment? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.PendingDeployment),
                jsonSerializerContext) as global::G.PendingDeployment;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.PendingDeployment? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.PendingDeployment>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.PendingDeployment?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.PendingDeployment),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.PendingDeployment;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.PendingDeployment?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.PendingDeployment?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}