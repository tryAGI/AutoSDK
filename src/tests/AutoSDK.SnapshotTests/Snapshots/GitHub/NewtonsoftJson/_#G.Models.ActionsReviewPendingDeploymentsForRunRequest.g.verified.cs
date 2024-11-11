//HintName: G.Models.ActionsReviewPendingDeploymentsForRunRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsReviewPendingDeploymentsForRunRequest
    {
        /// <summary>
        /// The list of environment ids to approve or reject<br/>
        /// Example: [161171787, 161171795]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environment_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<int> EnvironmentIds { get; set; } = default!;

        /// <summary>
        /// Whether to approve or reject deployment to the specified environments.<br/>
        /// Example: approved
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ActionsReviewPendingDeploymentsForRunRequestState State { get; set; } = default!;

        /// <summary>
        /// A comment to accompany the deployment review<br/>
        /// Example: Ship it!
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comment", Required = global::Newtonsoft.Json.Required.Always)]
        public string Comment { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsReviewPendingDeploymentsForRunRequest" /> class.
        /// </summary>
        /// <param name="environmentIds">
        /// The list of environment ids to approve or reject<br/>
        /// Example: [161171787, 161171795]
        /// </param>
        /// <param name="state">
        /// Whether to approve or reject deployment to the specified environments.<br/>
        /// Example: approved
        /// </param>
        /// <param name="comment">
        /// A comment to accompany the deployment review<br/>
        /// Example: Ship it!
        /// </param>
        public ActionsReviewPendingDeploymentsForRunRequest(
            global::System.Collections.Generic.IList<int> environmentIds,
            global::G.ActionsReviewPendingDeploymentsForRunRequestState state,
            string comment)
        {
            this.EnvironmentIds = environmentIds ?? throw new global::System.ArgumentNullException(nameof(environmentIds));
            this.State = state;
            this.Comment = comment ?? throw new global::System.ArgumentNullException(nameof(comment));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsReviewPendingDeploymentsForRunRequest" /> class.
        /// </summary>
        public ActionsReviewPendingDeploymentsForRunRequest()
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
        public static global::G.ActionsReviewPendingDeploymentsForRunRequest? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ActionsReviewPendingDeploymentsForRunRequest>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.ActionsReviewPendingDeploymentsForRunRequest?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.ActionsReviewPendingDeploymentsForRunRequest?>(serializer.Deserialize<global::G.ActionsReviewPendingDeploymentsForRunRequest>(jsonReader));
        }

    }
}