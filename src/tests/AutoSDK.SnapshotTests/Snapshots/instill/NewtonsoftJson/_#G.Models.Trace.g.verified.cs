//HintName: G.Models.Trace.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Trace contains the execution details of a component.
    /// </summary>
    public sealed partial class Trace
    {
        /// <summary>
        /// Statuses contains an execution status per input.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("statuses")]
        public global::System.Collections.Generic.IList<global::G.TraceStatus>? Statuses { get; set; }

        /// <summary>
        /// Component inputs.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs")]
        public global::System.Collections.Generic.IList<object>? Inputs { get; set; }

        /// <summary>
        /// Component outputs.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputs")]
        public global::System.Collections.Generic.IList<object>? Outputs { get; set; }

        /// <summary>
        /// Error details.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public object? Error { get; set; }

        /// <summary>
        /// Computation time in seconds.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("computeTimeInSeconds")]
        public float? ComputeTimeInSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Trace" /> class.
        /// </summary>
        /// <param name="statuses">
        /// Statuses contains an execution status per input.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="inputs">
        /// Component inputs.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="outputs">
        /// Component outputs.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="error">
        /// Error details.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="computeTimeInSeconds">
        /// Computation time in seconds.<br/>
        /// Included only in responses
        /// </param>
        public Trace(
            global::System.Collections.Generic.IList<global::G.TraceStatus>? statuses,
            global::System.Collections.Generic.IList<object>? inputs,
            global::System.Collections.Generic.IList<object>? outputs,
            object? error,
            float? computeTimeInSeconds)
        {
            this.Statuses = statuses;
            this.Inputs = inputs;
            this.Outputs = outputs;
            this.Error = error;
            this.ComputeTimeInSeconds = computeTimeInSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Trace" /> class.
        /// </summary>
        public Trace()
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
        public static global::G.Trace? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Trace>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.Trace?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.Trace?>(serializer.Deserialize<global::G.Trace>(jsonReader));
        }

    }
}