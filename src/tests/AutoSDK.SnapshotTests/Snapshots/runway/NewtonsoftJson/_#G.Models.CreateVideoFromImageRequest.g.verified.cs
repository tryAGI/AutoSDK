//HintName: G.Models.CreateVideoFromImageRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVideoFromImageRequest
    {
        /// <summary>
        /// HTTPS URL of an image (JPEG, PNG, WebP, max 16MB).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptImage", Required = global::Newtonsoft.Json.Required.Always)]
        public string PromptImage { get; set; } = default!;

        /// <summary>
        /// The model variant to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public global::G.CreateVideoFromImageRequestModel Model { get; set; }

        /// <summary>
        /// Seed value for generating consistent results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// A detailed description of the output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptText")]
        public string? PromptText { get; set; }

        /// <summary>
        /// Add a Runway watermark to the output.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("watermark")]
        public bool? Watermark { get; set; }

        /// <summary>
        /// Duration of the video in seconds.<br/>
        /// Default Value: 10
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// Aspect ratio of the video.<br/>
        /// Default Value: 16:9
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ratio")]
        public global::G.CreateVideoFromImageRequestRatio? Ratio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoFromImageRequest" /> class.
        /// </summary>
        /// <param name="promptImage">
        /// HTTPS URL of an image (JPEG, PNG, WebP, max 16MB).
        /// </param>
        /// <param name="model">
        /// The model variant to use.
        /// </param>
        /// <param name="seed">
        /// Seed value for generating consistent results.
        /// </param>
        /// <param name="promptText">
        /// A detailed description of the output.
        /// </param>
        /// <param name="watermark">
        /// Add a Runway watermark to the output.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="duration">
        /// Duration of the video in seconds.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="ratio">
        /// Aspect ratio of the video.<br/>
        /// Default Value: 16:9
        /// </param>
        public CreateVideoFromImageRequest(
            string promptImage,
            global::G.CreateVideoFromImageRequestModel model,
            int? seed,
            string? promptText,
            bool? watermark,
            int? duration,
            global::G.CreateVideoFromImageRequestRatio? ratio)
        {
            this.PromptImage = promptImage ?? throw new global::System.ArgumentNullException(nameof(promptImage));
            this.Model = model;
            this.Seed = seed;
            this.PromptText = promptText;
            this.Watermark = watermark;
            this.Duration = duration;
            this.Ratio = ratio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoFromImageRequest" /> class.
        /// </summary>
        public CreateVideoFromImageRequest()
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
        public static global::G.CreateVideoFromImageRequest? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CreateVideoFromImageRequest>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.CreateVideoFromImageRequest?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.CreateVideoFromImageRequest?>(serializer.Deserialize<global::G.CreateVideoFromImageRequest>(jsonReader));
        }

    }
}