//HintName: G.Models.CreateEmbeddingsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Defines the embedding request. The required fields vary depending on the the value of the `input_type` parameter. For example, when `input_type` is `text`, the `text` field becomes mandatory.
    /// </summary>
    public sealed partial class CreateEmbeddingsRequest
    {
        /// <summary>
        /// The type of content for the embeddings.<br/>
        /// **Values**:<br/>
        /// - `audio`: Creates embeddings for an audio file<br/>
        /// - `video`: Creates embeddings for a video file<br/>
        /// - `image`: Creates embeddings for an image file<br/>
        /// - `text`: Creates embeddings for text input<br/>
        /// - `text_image`: Creates embeddings for text and an image<br/>
        /// - `multi_input`: Creates a single embedding from up to 10 images. You can optionally include text to provide context. To reference specific images in your text, use placeholders in the following format: `&lt;@name&gt;`, where `name` matches the `name` field of a media source
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateEmbeddingsRequestInputTypeJsonConverter))]
        public global::G.CreateEmbeddingsRequestInputType InputType { get; set; } = default!;

        /// <summary>
        /// The video understanding model to use. Only "marengo3.0" is supported.<br/>
        /// Default Value: marengo3.0
        /// </summary>
        /// <default>global::G.CreateEmbeddingsRequestModelName.Marengo30</default>
        [global::Newtonsoft.Json.JsonProperty("model_name")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateEmbeddingsRequestModelNameJsonConverter))]
        public global::G.CreateEmbeddingsRequestModelName ModelName { get; set; } = global::G.CreateEmbeddingsRequestModelName.Marengo30;

        /// <summary>
        /// This field is required if the `input_type` parameter is `text`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public global::G.TextInputRequest? Text { get; set; }

        /// <summary>
        /// This field is required if the  `input_type` parameter is `image`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image")]
        public global::G.ImageInputRequest? Image { get; set; }

        /// <summary>
        /// This field is required if the `input_type` parameter is `text_image`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_image")]
        public global::G.TextImageInputRequest? TextImage { get; set; }

        /// <summary>
        /// This field is required if the `input_type` parameter is `audio`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio")]
        public global::G.AudioInputRequest? Audio { get; set; }

        /// <summary>
        /// This field is required if the `input_type` parameter is `video`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video")]
        public global::G.VideoInputRequest? Video { get; set; }

        /// <summary>
        /// This field is required if the `input_type` parameter is `multi_input`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("multi_input")]
        public global::G.MultiInputRequest? MultiInput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmbeddingsRequest" /> class.
        /// </summary>
        /// <param name="inputType">
        /// The type of content for the embeddings.<br/>
        /// **Values**:<br/>
        /// - `audio`: Creates embeddings for an audio file<br/>
        /// - `video`: Creates embeddings for a video file<br/>
        /// - `image`: Creates embeddings for an image file<br/>
        /// - `text`: Creates embeddings for text input<br/>
        /// - `text_image`: Creates embeddings for text and an image<br/>
        /// - `multi_input`: Creates a single embedding from up to 10 images. You can optionally include text to provide context. To reference specific images in your text, use placeholders in the following format: `&lt;@name&gt;`, where `name` matches the `name` field of a media source
        /// </param>
        /// <param name="text">
        /// This field is required if the `input_type` parameter is `text`.
        /// </param>
        /// <param name="image">
        /// This field is required if the  `input_type` parameter is `image`.
        /// </param>
        /// <param name="textImage">
        /// This field is required if the `input_type` parameter is `text_image`.
        /// </param>
        /// <param name="audio">
        /// This field is required if the `input_type` parameter is `audio`.
        /// </param>
        /// <param name="video">
        /// This field is required if the `input_type` parameter is `video`.
        /// </param>
        /// <param name="multiInput">
        /// This field is required if the `input_type` parameter is `multi_input`.
        /// </param>
        /// <param name="modelName">
        /// The video understanding model to use. Only "marengo3.0" is supported.<br/>
        /// Default Value: marengo3.0
        /// </param>
        public CreateEmbeddingsRequest(
            global::G.CreateEmbeddingsRequestInputType inputType,
            global::G.TextInputRequest? text,
            global::G.ImageInputRequest? image,
            global::G.TextImageInputRequest? textImage,
            global::G.AudioInputRequest? audio,
            global::G.VideoInputRequest? video,
            global::G.MultiInputRequest? multiInput,
            global::G.CreateEmbeddingsRequestModelName modelName = global::G.CreateEmbeddingsRequestModelName.Marengo30)
        {
            this.InputType = inputType;
            this.ModelName = modelName;
            this.Text = text;
            this.Image = image;
            this.TextImage = textImage;
            this.Audio = audio;
            this.Video = video;
            this.MultiInput = multiInput;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmbeddingsRequest" /> class.
        /// </summary>
        public CreateEmbeddingsRequest()
        {
        }
    }
}