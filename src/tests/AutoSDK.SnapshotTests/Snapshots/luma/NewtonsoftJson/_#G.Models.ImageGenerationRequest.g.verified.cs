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
        /// Default Value: image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generation_type")]
        public global::G.ImageGenerationRequestGenerationType? GenerationType { get; set; }

        /// <summary>
        /// The model used for the generation<br/>
        /// Default Value: photon-1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public global::G.ImageModel? Model { get; set; }

        /// <summary>
        /// The prompt of the generation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// The aspect ratio of the generation<br/>
        /// Default Value: 16:9<br/>
        /// Example: 16:9
        /// </summary>
        /// <example>16:9</example>
        [global::Newtonsoft.Json.JsonProperty("aspect_ratio")]
        public global::G.AspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// The callback URL for the generation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_ref")]
        public global::System.Collections.Generic.IList<global::G.ImageRef>? ImageRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("style_ref")]
        public global::System.Collections.Generic.IList<global::G.ImageRef>? StyleRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("character_ref")]
        public global::G.ImageGenerationRequestCharacterRef? CharacterRef { get; set; }

        /// <summary>
        /// The modify image reference object
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modify_image_ref")]
        public global::G.ModifyImageRef? ModifyImageRef { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationRequest" /> class.
        /// </summary>
        /// <param name="generationType">
        /// Default Value: image
        /// </param>
        /// <param name="model">
        /// The model used for the generation<br/>
        /// Default Value: photon-1
        /// </param>
        /// <param name="prompt">
        /// The prompt of the generation
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of the generation<br/>
        /// Default Value: 16:9<br/>
        /// Example: 16:9
        /// </param>
        /// <param name="callbackUrl">
        /// The callback URL for the generation
        /// </param>
        /// <param name="imageRef"></param>
        /// <param name="styleRef"></param>
        /// <param name="characterRef"></param>
        /// <param name="modifyImageRef">
        /// The modify image reference object
        /// </param>
        public ImageGenerationRequest(
            global::G.ImageGenerationRequestGenerationType? generationType,
            global::G.ImageModel? model,
            string? prompt,
            global::G.AspectRatio? aspectRatio,
            string? callbackUrl,
            global::System.Collections.Generic.IList<global::G.ImageRef>? imageRef,
            global::System.Collections.Generic.IList<global::G.ImageRef>? styleRef,
            global::G.ImageGenerationRequestCharacterRef? characterRef,
            global::G.ModifyImageRef? modifyImageRef)
        {
            this.GenerationType = generationType;
            this.Model = model;
            this.Prompt = prompt;
            this.AspectRatio = aspectRatio;
            this.CallbackUrl = callbackUrl;
            this.ImageRef = imageRef;
            this.StyleRef = styleRef;
            this.CharacterRef = characterRef;
            this.ModifyImageRef = modifyImageRef;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationRequest" /> class.
        /// </summary>
        public ImageGenerationRequest()
        {
        }
    }
}