//HintName: G.Models.CheckAnnotation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Check Annotation
    /// </summary>
    public sealed partial class CheckAnnotation
    {
        /// <summary>
        /// Example: README.md
        /// </summary>
        /// <example>README.md</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_line")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartLine { get; set; }

        /// <summary>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_line")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndLine { get; set; }

        /// <summary>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_column")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? StartColumn { get; set; }

        /// <summary>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_column")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? EndColumn { get; set; }

        /// <summary>
        /// Example: warning
        /// </summary>
        /// <example>warning</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation_level")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? AnnotationLevel { get; set; }

        /// <summary>
        /// Example: Spell Checker
        /// </summary>
        /// <example>Spell Checker</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Title { get; set; }

        /// <summary>
        /// Example: Check your spelling for 'banaas'.
        /// </summary>
        /// <example>Check your spelling for 'banaas'.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Message { get; set; }

        /// <summary>
        /// Example: Do you mean 'bananas' or 'banana'?
        /// </summary>
        /// <example>Do you mean 'bananas' or 'banana'?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? RawDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blob_href")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BlobHref { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckAnnotation" /> class.
        /// </summary>
        /// <param name="path">
        /// Example: README.md
        /// </param>
        /// <param name="startLine">
        /// Example: 2
        /// </param>
        /// <param name="endLine">
        /// Example: 2
        /// </param>
        /// <param name="startColumn">
        /// Example: 5
        /// </param>
        /// <param name="endColumn">
        /// Example: 10
        /// </param>
        /// <param name="annotationLevel">
        /// Example: warning
        /// </param>
        /// <param name="title">
        /// Example: Spell Checker
        /// </param>
        /// <param name="message">
        /// Example: Check your spelling for 'banaas'.
        /// </param>
        /// <param name="rawDetails">
        /// Example: Do you mean 'bananas' or 'banana'?
        /// </param>
        /// <param name="blobHref"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CheckAnnotation(
            string path,
            int startLine,
            int endLine,
            int? startColumn,
            int? endColumn,
            string? annotationLevel,
            string? title,
            string? message,
            string? rawDetails,
            string blobHref)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.StartLine = startLine;
            this.EndLine = endLine;
            this.StartColumn = startColumn;
            this.EndColumn = endColumn;
            this.AnnotationLevel = annotationLevel ?? throw new global::System.ArgumentNullException(nameof(annotationLevel));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.RawDetails = rawDetails ?? throw new global::System.ArgumentNullException(nameof(rawDetails));
            this.BlobHref = blobHref ?? throw new global::System.ArgumentNullException(nameof(blobHref));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckAnnotation" /> class.
        /// </summary>
        public CheckAnnotation()
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
        public static global::G.CheckAnnotation? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.CheckAnnotation),
                jsonSerializerContext) as global::G.CheckAnnotation;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.CheckAnnotation? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.CheckAnnotation>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.CheckAnnotation?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.CheckAnnotation),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.CheckAnnotation;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.CheckAnnotation?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.CheckAnnotation?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}