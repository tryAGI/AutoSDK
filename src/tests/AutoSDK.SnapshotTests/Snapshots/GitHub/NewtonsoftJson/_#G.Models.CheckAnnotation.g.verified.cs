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
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// Example: 2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_line", Required = global::Newtonsoft.Json.Required.Always)]
        public int StartLine { get; set; } = default!;

        /// <summary>
        /// Example: 2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_line", Required = global::Newtonsoft.Json.Required.Always)]
        public int EndLine { get; set; } = default!;

        /// <summary>
        /// Example: 5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start_column", Required = global::Newtonsoft.Json.Required.Always)]
        public int? StartColumn { get; set; } = default!;

        /// <summary>
        /// Example: 10
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_column", Required = global::Newtonsoft.Json.Required.Always)]
        public int? EndColumn { get; set; } = default!;

        /// <summary>
        /// Example: warning
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotation_level", Required = global::Newtonsoft.Json.Required.Always)]
        public string? AnnotationLevel { get; set; } = default!;

        /// <summary>
        /// Example: Spell Checker
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Title { get; set; } = default!;

        /// <summary>
        /// Example: Check your spelling for 'banaas'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Message { get; set; } = default!;

        /// <summary>
        /// Example: Do you mean 'bananas' or 'banana'?
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("raw_details", Required = global::Newtonsoft.Json.Required.Always)]
        public string? RawDetails { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("blob_href", Required = global::Newtonsoft.Json.Required.Always)]
        public string BlobHref { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        public static global::G.CheckAnnotation? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CheckAnnotation>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.CheckAnnotation?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.CheckAnnotation?>(serializer.Deserialize<global::G.CheckAnnotation>(jsonReader));
        }

    }
}