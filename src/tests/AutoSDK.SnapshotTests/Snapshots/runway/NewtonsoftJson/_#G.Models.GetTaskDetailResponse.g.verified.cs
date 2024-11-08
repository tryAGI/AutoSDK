//HintName: G.Models.GetTaskDetailResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTaskDetailResponse
    {
        /// <summary>
        /// Unique identifier of the task.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Current status of the task:<br/>
        /// - **PENDING**: The task is waiting in the queue.<br/>
        /// - **THROTTLED**: The task is waiting to be enqueued due to other running jobs.<br/>
        /// - **RUNNING**: The task is currently being processed.<br/>
        /// - **SUCCEEDED**: The task completed successfully.<br/>
        /// - **FAILED**: The task failed.<br/>
        /// - **CANCELLED**: The task was aborted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetTaskDetailResponseStatus Status { get; set; } = default!;

        /// <summary>
        /// Timestamp when the task was submitted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Progress of the task. Only present when the task is in **RUNNING** state.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("progress")]
        public float? Progress { get; set; }

        /// <summary>
        /// URLs to the task's output. Only present when the task is in **SUCCEEDED** state. These URLs expire within 24-48 hours; fetch the task again to get fresh URLs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output")]
        public global::System.Collections.Generic.IList<string>? Output { get; set; }

        /// <summary>
        /// Reason for the task's failure. Only present when the task is in **FAILED** state.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failure")]
        public string? Failure { get; set; }

        /// <summary>
        /// Machine-readable error code for the failure. Only present when the task is in **FAILED** state. The code follows a dot-separated structure, with the most generic part on the left and the most specific part on the right (e.g., `SAFETY.INPUT.IMAGE`).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failureCode")]
        public string? FailureCode { get; set; }

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
        public static global::G.GetTaskDetailResponse? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.GetTaskDetailResponse>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.GetTaskDetailResponse?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.GetTaskDetailResponse?>(serializer.Deserialize<global::G.GetTaskDetailResponse>(jsonReader));
        }

    }
}