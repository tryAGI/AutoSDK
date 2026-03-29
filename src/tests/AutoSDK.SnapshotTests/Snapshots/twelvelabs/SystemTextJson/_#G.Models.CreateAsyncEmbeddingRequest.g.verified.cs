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
        [global::System.Text.Json.Serialization.JsonPropertyName("input_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateAsyncEmbeddingRequestInputTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateAsyncEmbeddingRequestInputType InputType { get; set; }

        /// <summary>
        /// The model you wish to use. Only `"marengo3.0"` is supported.<br/>
        /// Default Value: marengo3.0
        /// </summary>
        /// <default>global::G.CreateAsyncEmbeddingRequestModelName.Marengo30</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateAsyncEmbeddingRequestModelNameJsonConverter))]
        public global::G.CreateAsyncEmbeddingRequestModelName ModelName { get; set; } = global::G.CreateAsyncEmbeddingRequestModelName.Marengo30;

        /// <summary>
        /// This field is required if the `input_type` parameter is `audio`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::G.AudioInputRequest? Audio { get; set; }

        /// <summary>
        /// This field is required if the `input_type` parameter is `video`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video")]
        public global::G.VideoInputRequest? Video { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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