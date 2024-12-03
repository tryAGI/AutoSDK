//HintName: G.Models.ImageGenerationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The image generation request object
    /// </summary>
    public sealed partial class ImageGenerationRequest
    {
        /// <summary>
        /// The aspect ratio of the generation<br/>
        /// Default Value: 16:9<br/>
        /// Example: 16:9
        /// </summary>
        /// <example>16:9</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AspectRatioJsonConverter))]
        public global::G.AspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// The callback URL for the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_ref")]
        public global::G.ImageGenerationRequestCharacterRef? CharacterRef { get; set; }

        /// <summary>
        /// Default Value: image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ImageGenerationRequestGenerationTypeJsonConverter))]
        public global::G.ImageGenerationRequestGenerationType? GenerationType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_ref")]
        public global::System.Collections.Generic.IList<global::G.ImageRef>? ImageRef { get; set; }

        /// <summary>
        /// The image model used for the generation<br/>
        /// Default Value: photon-1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ImageModelJsonConverter))]
        public global::G.ImageModel? Model { get; set; }

        /// <summary>
        /// The modify image reference object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modify_image_ref")]
        public global::G.ModifyImageRef? ModifyImageRef { get; set; }

        /// <summary>
        /// The prompt of the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style_ref")]
        public global::System.Collections.Generic.IList<global::G.ImageRef>? StyleRef { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationRequest" /> class.
        /// </summary>
        /// <param name="aspectRatio">
        /// The aspect ratio of the generation<br/>
        /// Default Value: 16:9<br/>
        /// Example: 16:9
        /// </param>
        /// <param name="callbackUrl">
        /// The callback URL for the generation
        /// </param>
        /// <param name="characterRef"></param>
        /// <param name="generationType">
        /// Default Value: image
        /// </param>
        /// <param name="imageRef"></param>
        /// <param name="model">
        /// The image model used for the generation<br/>
        /// Default Value: photon-1
        /// </param>
        /// <param name="modifyImageRef">
        /// The modify image reference object
        /// </param>
        /// <param name="prompt">
        /// The prompt of the generation
        /// </param>
        /// <param name="styleRef"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ImageGenerationRequest(
            global::G.AspectRatio? aspectRatio,
            string? callbackUrl,
            global::G.ImageGenerationRequestCharacterRef? characterRef,
            global::G.ImageGenerationRequestGenerationType? generationType,
            global::System.Collections.Generic.IList<global::G.ImageRef>? imageRef,
            global::G.ImageModel? model,
            global::G.ModifyImageRef? modifyImageRef,
            string? prompt,
            global::System.Collections.Generic.IList<global::G.ImageRef>? styleRef)
        {
            this.AspectRatio = aspectRatio;
            this.CallbackUrl = callbackUrl;
            this.CharacterRef = characterRef;
            this.GenerationType = generationType;
            this.ImageRef = imageRef;
            this.Model = model;
            this.ModifyImageRef = modifyImageRef;
            this.Prompt = prompt;
            this.StyleRef = styleRef;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationRequest" /> class.
        /// </summary>
        public ImageGenerationRequest()
        {
        }
    }
}