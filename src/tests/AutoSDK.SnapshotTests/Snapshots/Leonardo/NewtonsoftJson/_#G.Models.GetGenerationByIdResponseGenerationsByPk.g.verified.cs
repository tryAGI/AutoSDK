﻿//HintName: G.Models.GetGenerationByIdResponseGenerationsByPk.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// columns and relationships of "generations"
    /// </summary>
    public sealed partial class GetGenerationByIdResponseGenerationsByPk
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generated_images")]
        public global::System.Collections.Generic.IList<global::G.GetGenerationByIdResponseGenerationsByPkGeneratedImage>? GeneratedImages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generation_elements")]
        public global::System.Collections.Generic.IList<global::G.GetGenerationByIdResponseGenerationsByPkGenerationElement>? GenerationElements { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("guidanceScale")]
        public double? GuidanceScale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("imageHeight")]
        public int? ImageHeight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("imageWidth")]
        public int? ImageWidth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inferenceSteps")]
        public int? InferenceSteps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("initStrength")]
        public double? InitStrength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modelId")]
        public string? ModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("negativePrompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// If photoReal feature was used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("photoReal")]
        public bool? PhotoReal { get; set; }

        /// <summary>
        /// Depth of field of photoReal used. 0.55 is low, 0.5 is medium, and 0.45 is high. Default is 0.55.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("photoRealStrength")]
        public double? PhotoRealStrength { get; set; }

        /// <summary>
        /// The style to generate images with. When photoReal is enabled, refer to the Guide section for a full list. When alchemy is disabled, use LEONARDO or NONE. When alchemy is enabled, use ANIME, CREATIVE, DYNAMIC, ENVIRONMENT, GENERAL, ILLUSTRATION, PHOTOGRAPHY, RAYTRACED, RENDER_3D, SKETCH_BW, SKETCH_COLOR, or NONE.<br/>
        /// Default Value: DYNAMIC
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presetStyle")]
        public global::G.SdGenerationStyle? PresetStyle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// If prompt magic was used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptMagic")]
        public bool? PromptMagic { get; set; }

        /// <summary>
        /// Strength of prompt magic used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptMagicStrength")]
        public double? PromptMagicStrength { get; set; }

        /// <summary>
        /// Version of prompt magic used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptMagicVersion")]
        public string? PromptMagicVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("public")]
        public bool? Public { get; set; }

        /// <summary>
        /// The scheduler to generate images with. Defaults to EULER_DISCRETE if not specified.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scheduler")]
        public global::G.SdGenerationSchedulers? Scheduler { get; set; }

        /// <summary>
        /// The base version of stable diffusion to use if not using a custom model. v1_5 is 1.5, v2 is 2.1, if not specified it will default to v1_5. Also includes SDXL and SDXL Lightning models
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sdVersion")]
        public global::G.SdVersions? SdVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// The status of the current task.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.JobStatus? Status { get; set; }

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
        public static global::G.GetGenerationByIdResponseGenerationsByPk? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.GetGenerationByIdResponseGenerationsByPk>(
                json,
                jsonSerializerOptions);
        }

    }
}