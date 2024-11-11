//HintName: G.Models.ClassificationMeta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Additional information to a specific classification
    /// </summary>
    public sealed partial class ClassificationMeta
    {
        /// <summary>
        /// time when this classification was started
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started")]
        public global::System.DateTime? Started { get; set; }

        /// <summary>
        /// time when this classification finished
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed")]
        public global::System.DateTime? Completed { get; set; }

        /// <summary>
        /// number of objects which were taken into consideration for classification<br/>
        /// Example: 147
        /// </summary>
        /// <example>147</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// number of objects successfully classified<br/>
        /// Example: 140
        /// </summary>
        /// <example>140</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("countSucceeded")]
        public int? CountSucceeded { get; set; }

        /// <summary>
        /// number of objects which could not be classified - see error message for details<br/>
        /// Example: 7
        /// </summary>
        /// <example>7</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("countFailed")]
        public int? CountFailed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationMeta" /> class.
        /// </summary>
        /// <param name="started">
        /// time when this classification was started
        /// </param>
        /// <param name="completed">
        /// time when this classification finished
        /// </param>
        /// <param name="count">
        /// number of objects which were taken into consideration for classification<br/>
        /// Example: 147
        /// </param>
        /// <param name="countSucceeded">
        /// number of objects successfully classified<br/>
        /// Example: 140
        /// </param>
        /// <param name="countFailed">
        /// number of objects which could not be classified - see error message for details<br/>
        /// Example: 7
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ClassificationMeta(
            global::System.DateTime? started,
            global::System.DateTime? completed,
            int? count,
            int? countSucceeded,
            int? countFailed)
        {
            this.Started = started;
            this.Completed = completed;
            this.Count = count;
            this.CountSucceeded = countSucceeded;
            this.CountFailed = countFailed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationMeta" /> class.
        /// </summary>
        public ClassificationMeta()
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
        public static global::G.ClassificationMeta? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.ClassificationMeta),
                jsonSerializerContext) as global::G.ClassificationMeta;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.ClassificationMeta? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.ClassificationMeta>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.ClassificationMeta?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.ClassificationMeta),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.ClassificationMeta;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.ClassificationMeta?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.ClassificationMeta?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}