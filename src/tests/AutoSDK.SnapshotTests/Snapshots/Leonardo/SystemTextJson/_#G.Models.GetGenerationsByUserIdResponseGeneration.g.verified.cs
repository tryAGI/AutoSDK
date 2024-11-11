//HintName: G.Models.GetGenerationsByUserIdResponseGeneration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// columns and relationships of "generations"
    /// </summary>
    public sealed partial class GetGenerationsByUserIdResponseGeneration
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_images")]
        public global::System.Collections.Generic.IList<global::G.GetGenerationsByUserIdResponseGenerationGeneratedImage>? GeneratedImages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_elements")]
        public global::System.Collections.Generic.IList<global::G.GetGenerationsByUserIdResponseGenerationGenerationElement>? GenerationElements { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guidanceScale")]
        public double? GuidanceScale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageHeight")]
        public int? ImageHeight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageWidth")]
        public int? ImageWidth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inferenceSteps")]
        public int? InferenceSteps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initStrength")]
        public double? InitStrength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelId")]
        public string? ModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negativePrompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// If photoReal feature was used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("photoReal")]
        public bool? PhotoReal { get; set; }

        /// <summary>
        /// Depth of field of photoReal used. 0.55 is low, 0.5 is medium, and 0.45 is high. Default is 0.55.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("photoRealStrength")]
        public double? PhotoRealStrength { get; set; }

        /// <summary>
        /// The style to generate images with. When photoReal is enabled, refer to the Guide section for a full list. When alchemy is disabled, use LEONARDO or NONE. When alchemy is enabled, use ANIME, CREATIVE, DYNAMIC, ENVIRONMENT, GENERAL, ILLUSTRATION, PHOTOGRAPHY, RAYTRACED, RENDER_3D, SKETCH_BW, SKETCH_COLOR, or NONE.<br/>
        /// Default Value: DYNAMIC
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presetStyle")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SdGenerationStyleJsonConverter))]
        public global::G.SdGenerationStyle? PresetStyle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// If prompt magic was used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptMagic")]
        public bool? PromptMagic { get; set; }

        /// <summary>
        /// Strength of prompt magic used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptMagicStrength")]
        public double? PromptMagicStrength { get; set; }

        /// <summary>
        /// Version of prompt magic used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptMagicVersion")]
        public string? PromptMagicVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        public bool? Public { get; set; }

        /// <summary>
        /// The scheduler to generate images with. Defaults to EULER_DISCRETE if not specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduler")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SdGenerationSchedulersJsonConverter))]
        public global::G.SdGenerationSchedulers? Scheduler { get; set; }

        /// <summary>
        /// The base version of stable diffusion to use if not using a custom model. v1_5 is 1.5, v2 is 2.1, if not specified it will default to v1_5. Also includes SDXL and SDXL Lightning models
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sdVersion")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SdVersionsJsonConverter))]
        public global::G.SdVersions? SdVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// The status of the current task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.JobStatusJsonConverter))]
        public global::G.JobStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGenerationsByUserIdResponseGeneration" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="generatedImages"></param>
        /// <param name="generationElements"></param>
        /// <param name="guidanceScale"></param>
        /// <param name="id"></param>
        /// <param name="imageHeight"></param>
        /// <param name="imageWidth"></param>
        /// <param name="inferenceSteps"></param>
        /// <param name="initStrength"></param>
        /// <param name="modelId"></param>
        /// <param name="negativePrompt"></param>
        /// <param name="photoReal">
        /// If photoReal feature was used.
        /// </param>
        /// <param name="photoRealStrength">
        /// Depth of field of photoReal used. 0.55 is low, 0.5 is medium, and 0.45 is high. Default is 0.55.
        /// </param>
        /// <param name="presetStyle">
        /// The style to generate images with. When photoReal is enabled, refer to the Guide section for a full list. When alchemy is disabled, use LEONARDO or NONE. When alchemy is enabled, use ANIME, CREATIVE, DYNAMIC, ENVIRONMENT, GENERAL, ILLUSTRATION, PHOTOGRAPHY, RAYTRACED, RENDER_3D, SKETCH_BW, SKETCH_COLOR, or NONE.<br/>
        /// Default Value: DYNAMIC
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="promptMagic">
        /// If prompt magic was used.
        /// </param>
        /// <param name="promptMagicStrength">
        /// Strength of prompt magic used.
        /// </param>
        /// <param name="promptMagicVersion">
        /// Version of prompt magic used.
        /// </param>
        /// <param name="public"></param>
        /// <param name="scheduler">
        /// The scheduler to generate images with. Defaults to EULER_DISCRETE if not specified.
        /// </param>
        /// <param name="sdVersion">
        /// The base version of stable diffusion to use if not using a custom model. v1_5 is 1.5, v2 is 2.1, if not specified it will default to v1_5. Also includes SDXL and SDXL Lightning models
        /// </param>
        /// <param name="seed"></param>
        /// <param name="status">
        /// The status of the current task.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetGenerationsByUserIdResponseGeneration(
            string? createdAt,
            global::System.Collections.Generic.IList<global::G.GetGenerationsByUserIdResponseGenerationGeneratedImage>? generatedImages,
            global::System.Collections.Generic.IList<global::G.GetGenerationsByUserIdResponseGenerationGenerationElement>? generationElements,
            double? guidanceScale,
            string? id,
            int? imageHeight,
            int? imageWidth,
            int? inferenceSteps,
            double? initStrength,
            string? modelId,
            string? negativePrompt,
            bool? photoReal,
            double? photoRealStrength,
            global::G.SdGenerationStyle? presetStyle,
            string? prompt,
            bool? promptMagic,
            double? promptMagicStrength,
            string? promptMagicVersion,
            bool? @public,
            global::G.SdGenerationSchedulers? scheduler,
            global::G.SdVersions? sdVersion,
            int? seed,
            global::G.JobStatus? status)
        {
            this.CreatedAt = createdAt;
            this.GeneratedImages = generatedImages;
            this.GenerationElements = generationElements;
            this.GuidanceScale = guidanceScale;
            this.Id = id;
            this.ImageHeight = imageHeight;
            this.ImageWidth = imageWidth;
            this.InferenceSteps = inferenceSteps;
            this.InitStrength = initStrength;
            this.ModelId = modelId;
            this.NegativePrompt = negativePrompt;
            this.PhotoReal = photoReal;
            this.PhotoRealStrength = photoRealStrength;
            this.PresetStyle = presetStyle;
            this.Prompt = prompt;
            this.PromptMagic = promptMagic;
            this.PromptMagicStrength = promptMagicStrength;
            this.PromptMagicVersion = promptMagicVersion;
            this.Public = @public;
            this.Scheduler = scheduler;
            this.SdVersion = sdVersion;
            this.Seed = seed;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGenerationsByUserIdResponseGeneration" /> class.
        /// </summary>
        public GetGenerationsByUserIdResponseGeneration()
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
        public static global::G.GetGenerationsByUserIdResponseGeneration? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.GetGenerationsByUserIdResponseGeneration),
                jsonSerializerContext) as global::G.GetGenerationsByUserIdResponseGeneration;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.GetGenerationsByUserIdResponseGeneration? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetGenerationsByUserIdResponseGeneration>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.GetGenerationsByUserIdResponseGeneration?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.GetGenerationsByUserIdResponseGeneration),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.GetGenerationsByUserIdResponseGeneration;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.GetGenerationsByUserIdResponseGeneration?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.GetGenerationsByUserIdResponseGeneration?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}