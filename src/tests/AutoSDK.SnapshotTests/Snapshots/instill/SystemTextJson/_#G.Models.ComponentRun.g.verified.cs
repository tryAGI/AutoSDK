//HintName: G.Models.ComponentRun.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ComponentRun represents the execution details of a single component within a pipeline run.
    /// </summary>
    public sealed partial class ComponentRun
    {
        /// <summary>
        /// Links to the parent PipelineRun.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipelineRunUid")]
        public string? PipelineRunUid { get; set; }

        /// <summary>
        /// Unique identifier for each pipeline component.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("componentId")]
        public string? ComponentId { get; set; }

        /// <summary>
        /// Completion status of the component.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RunStatusJsonConverter))]
        public global::G.RunStatus? Status { get; set; }

        /// <summary>
        /// Time taken to execute the component in milliseconds.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalDuration")]
        public int? TotalDuration { get; set; }

        /// <summary>
        /// Time when the component started execution.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTime")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Time when the component finished execution.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completeTime")]
        public global::System.DateTime? CompleteTime { get; set; }

        /// <summary>
        /// Error message if the component failed.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Input files for the run.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputsReference")]
        public global::System.Collections.Generic.IList<global::G.FileReference>? InputsReference { get; set; }

        /// <summary>
        /// Component input parameters.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public global::System.Collections.Generic.IList<object>? Inputs { get; set; }

        /// <summary>
        /// Output files from the run.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputsReference")]
        public global::System.Collections.Generic.IList<global::G.FileReference>? OutputsReference { get; set; }

        /// <summary>
        /// Component inference outputs.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public global::System.Collections.Generic.IList<object>? Outputs { get; set; }

        /// <summary>
        /// Credits used of internal accounting metric.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creditAmount")]
        public float? CreditAmount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentRun" /> class.
        /// </summary>
        /// <param name="pipelineRunUid">
        /// Links to the parent PipelineRun.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="componentId">
        /// Unique identifier for each pipeline component.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="status">
        /// Completion status of the component.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="totalDuration">
        /// Time taken to execute the component in milliseconds.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="startTime">
        /// Time when the component started execution.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="completeTime">
        /// Time when the component finished execution.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="error">
        /// Error message if the component failed.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="inputsReference">
        /// Input files for the run.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="inputs">
        /// Component input parameters.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="outputsReference">
        /// Output files from the run.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="outputs">
        /// Component inference outputs.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="creditAmount">
        /// Credits used of internal accounting metric.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ComponentRun(
            string? pipelineRunUid,
            string? componentId,
            global::G.RunStatus? status,
            int? totalDuration,
            global::System.DateTime? startTime,
            global::System.DateTime? completeTime,
            string? error,
            global::System.Collections.Generic.IList<global::G.FileReference>? inputsReference,
            global::System.Collections.Generic.IList<object>? inputs,
            global::System.Collections.Generic.IList<global::G.FileReference>? outputsReference,
            global::System.Collections.Generic.IList<object>? outputs,
            float? creditAmount)
        {
            this.PipelineRunUid = pipelineRunUid;
            this.ComponentId = componentId;
            this.Status = status;
            this.TotalDuration = totalDuration;
            this.StartTime = startTime;
            this.CompleteTime = completeTime;
            this.Error = error;
            this.InputsReference = inputsReference;
            this.Inputs = inputs;
            this.OutputsReference = outputsReference;
            this.Outputs = outputs;
            this.CreditAmount = creditAmount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentRun" /> class.
        /// </summary>
        public ComponentRun()
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
        public static global::G.ComponentRun? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.ComponentRun),
                jsonSerializerContext) as global::G.ComponentRun;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ComponentRun? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.ComponentRun>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.ComponentRun?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.ComponentRun),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.ComponentRun;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.ComponentRun?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.ComponentRun?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}