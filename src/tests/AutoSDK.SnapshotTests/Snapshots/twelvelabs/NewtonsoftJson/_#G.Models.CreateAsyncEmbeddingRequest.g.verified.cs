//HintName: G.Models.CreateAsyncEmbeddingRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Defines the asynchronous embedding request. The required fields vary depending on the value of the `input_type` parameter. When `input_type` is `audio`, the `audio` field is required. When `input_type` is `video`, the `video` field is required.
    /// </summary>
    public sealed partial class CreateAsyncEmbeddingRequest
    {
        /// <summary>
        /// The type of content for the embeddings.<br/>
        /// **Values**:<br/>
        /// - `audio`: Audio files<br/>
        /// - `video`: Video content
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateAsyncEmbeddingRequestInputTypeJsonConverter))]
        public global::G.CreateAsyncEmbeddingRequestInputType InputType { get; set; } = default!;

        /// <summary>
        /// The model you wish to use. Only `"marengo3.0"` is supported.<br/>
        /// Default Value: marengo3.0
        /// </summary>
        /// <default>global::G.CreateAsyncEmbeddingRequestModelName.Marengo30</default>
        [global::Newtonsoft.Json.JsonProperty("model_name")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateAsyncEmbeddingRequestModelNameJsonConverter))]
        public global::G.CreateAsyncEmbeddingRequestModelName ModelName { get; set; } = global::G.CreateAsyncEmbeddingRequestModelName.Marengo30;

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAsyncEmbeddingRequest" /> class.
        /// </summary>
        /// <param name="inputType">
        /// The type of content for the embeddings.<br/>
        /// **Values**:<br/>
        /// - `audio`: Audio files<br/>
        /// - `video`: Video content
        /// </param>
        /// <param name="audio">
        /// This field is required if the `input_type` parameter is `audio`.
        /// </param>
        /// <param name="video">
        /// This field is required if the `input_type` parameter is `video`.
        /// </param>
        /// <param name="modelName">
        /// The model you wish to use. Only `"marengo3.0"` is supported.<br/>
        /// Default Value: marengo3.0
        /// </param>
        public CreateAsyncEmbeddingRequest(
            global::G.CreateAsyncEmbeddingRequestInputType inputType,
            global::G.AudioInputRequest? audio,
            global::G.VideoInputRequest? video,
            global::G.CreateAsyncEmbeddingRequestModelName modelName = global::G.CreateAsyncEmbeddingRequestModelName.Marengo30)
        {
            this.InputType = inputType;
            this.ModelName = modelName;
            this.Audio = audio;
            this.Video = video;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAsyncEmbeddingRequest" /> class.
        /// </summary>
        public CreateAsyncEmbeddingRequest()
        {
        }
    }
}