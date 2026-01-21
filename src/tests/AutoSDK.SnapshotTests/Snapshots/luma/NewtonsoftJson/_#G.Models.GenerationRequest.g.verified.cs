//HintName: G.Models.GenerationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The generation request object
    /// </summary>
    public sealed partial class GenerationRequest
    {
        /// <summary>
        /// Default Value: video
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generation_type")]
        public global::G.GenerationRequestGenerationType? GenerationType { get; set; }

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
        /// Whether to loop the video
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("loop")]
        public bool? Loop { get; set; }

        /// <summary>
        /// The keyframes of the generation<br/>
        /// Example: {"frame0":{"type":"image","url":"https://example.com/image.jpg"},"frame1":{"type":"generation","id":"123e4567-e89b-12d3-a456-426614174000"}}
        /// </summary>
        /// <example>{"frame0":{"type":"image","url":"https://example.com/image.jpg"},"frame1":{"type":"generation","id":"123e4567-e89b-12d3-a456-426614174000"}}</example>
        [global::Newtonsoft.Json.JsonProperty("keyframes")]
        public global::G.Keyframes? Keyframes { get; set; }

        /// <summary>
        /// The callback URL of the generation, a POST request with Generation object will be sent to the callback URL when the generation is dreaming, completed, or failed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationRequest" /> class.
        /// </summary>
        /// <param name="generationType">
        /// Default Value: video
        /// </param>
        /// <param name="prompt">
        /// The prompt of the generation
        /// </param>
        /// <param name="aspectRatio">
        /// The aspect ratio of the generation<br/>
        /// Default Value: 16:9<br/>
        /// Example: 16:9
        /// </param>
        /// <param name="loop">
        /// Whether to loop the video
        /// </param>
        /// <param name="keyframes">
        /// The keyframes of the generation<br/>
        /// Example: {"frame0":{"type":"image","url":"https://example.com/image.jpg"},"frame1":{"type":"generation","id":"123e4567-e89b-12d3-a456-426614174000"}}
        /// </param>
        /// <param name="callbackUrl">
        /// The callback URL of the generation, a POST request with Generation object will be sent to the callback URL when the generation is dreaming, completed, or failed
        /// </param>
        public GenerationRequest(
            global::G.GenerationRequestGenerationType? generationType,
            string? prompt,
            global::G.AspectRatio? aspectRatio,
            bool? loop,
            global::G.Keyframes? keyframes,
            string? callbackUrl)
        {
            this.GenerationType = generationType;
            this.Prompt = prompt;
            this.AspectRatio = aspectRatio;
            this.Loop = loop;
            this.Keyframes = keyframes;
            this.CallbackUrl = callbackUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationRequest" /> class.
        /// </summary>
        public GenerationRequest()
        {
        }
    }
}