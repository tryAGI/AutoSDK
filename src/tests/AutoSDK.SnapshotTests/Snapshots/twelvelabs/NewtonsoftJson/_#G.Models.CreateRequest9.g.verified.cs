//HintName: G.Models.CreateRequest9.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRequest9
    {
        /// <summary>
        /// The name of the model you want to use. The following models are available:<br/>
        ///   - `marengo3.0`: Enhanced model with sports intelligence and extended content support.<br/>
        ///   - `Marengo-retrieval-2.7`: **Deprecation notice**: Starting mid-March 2026, your videos will be automatically reindexed to Marengo 3.0. Marengo 2.7 will be deprecated once reindexing completes. See the [Migration guide](/v1.3/docs/get-started/migration-guide) for details.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModelName { get; set; } = default!;

        /// <summary>
        /// The text for which you wish to create an embedding.<br/>
        /// **Example**: "Man with a dog crossing the street"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Specifies how the platform handles text that exceeds token limits.<br/>
        /// **Available options by model version**:<br/>
        /// **Marengo 3.0**: This parameter is deprecated. The platform automatically truncates text exceeding 500 tokens from the end.<br/>
        /// **Marengo 2.7**: Specifies truncation method for text exceeding 77 tokens:<br/>
        /// - `start`: Removes tokens from the beginning<br/>
        /// - `end`: Removes tokens from the end (default)<br/>
        /// - `none`: Returns an error if the text is longer than the maximum token limit.<br/>
        /// **Default**: `end`<br/>
        /// Default Value: end
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_truncate")]
        public string? TextTruncate { get; set; }

        /// <summary>
        /// The publicly accessible URL of the image for which you wish to create an embedding. This parameter is required for image embeddings if `image_file` is not provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// The image file for which you wish to create an embedding as a local file. This parameter is required for image embeddings if `image_url` is not provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_file")]
        public byte[]? ImageFile { get; set; }

        /// <summary>
        /// The image file for which you wish to create an embedding as a local file. This parameter is required for image embeddings if `image_url` is not provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_filename")]
        public string? ImageFilename { get; set; }

        /// <summary>
        /// The publicly accessible URL of the audio file for which you wish to creae an embedding. This parameter is required for audio embeddings if `audio_file` is not provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_url")]
        public string? AudioUrl { get; set; }

        /// <summary>
        /// The audio file for which you wish to create an embedding as a local file. This parameter is required for audio embeddings if `audio_url` is not provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_file")]
        public byte[]? AudioFile { get; set; }

        /// <summary>
        /// The audio file for which you wish to create an embedding as a local file. This parameter is required for audio embeddings if `audio_url` is not provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_filename")]
        public string? AudioFilename { get; set; }

        /// <summary>
        /// Specifies the start time, in seconds, from which the platform generates the audio embeddings. This parameter allows you to skip the initial portion of the audio during processing.<br/>
        /// **Default**: `0`.<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_start_offset_sec")]
        public double? AudioStartOffsetSec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest9" /> class.
        /// </summary>
        /// <param name="modelName">
        /// The name of the model you want to use. The following models are available:<br/>
        ///   - `marengo3.0`: Enhanced model with sports intelligence and extended content support.<br/>
        ///   - `Marengo-retrieval-2.7`: **Deprecation notice**: Starting mid-March 2026, your videos will be automatically reindexed to Marengo 3.0. Marengo 2.7 will be deprecated once reindexing completes. See the [Migration guide](/v1.3/docs/get-started/migration-guide) for details.
        /// </param>
        /// <param name="text">
        /// The text for which you wish to create an embedding.<br/>
        /// **Example**: "Man with a dog crossing the street"
        /// </param>
        /// <param name="textTruncate">
        /// Specifies how the platform handles text that exceeds token limits.<br/>
        /// **Available options by model version**:<br/>
        /// **Marengo 3.0**: This parameter is deprecated. The platform automatically truncates text exceeding 500 tokens from the end.<br/>
        /// **Marengo 2.7**: Specifies truncation method for text exceeding 77 tokens:<br/>
        /// - `start`: Removes tokens from the beginning<br/>
        /// - `end`: Removes tokens from the end (default)<br/>
        /// - `none`: Returns an error if the text is longer than the maximum token limit.<br/>
        /// **Default**: `end`<br/>
        /// Default Value: end
        /// </param>
        /// <param name="imageUrl">
        /// The publicly accessible URL of the image for which you wish to create an embedding. This parameter is required for image embeddings if `image_file` is not provided.
        /// </param>
        /// <param name="imageFile">
        /// The image file for which you wish to create an embedding as a local file. This parameter is required for image embeddings if `image_url` is not provided.
        /// </param>
        /// <param name="imageFilename">
        /// The image file for which you wish to create an embedding as a local file. This parameter is required for image embeddings if `image_url` is not provided.
        /// </param>
        /// <param name="audioUrl">
        /// The publicly accessible URL of the audio file for which you wish to creae an embedding. This parameter is required for audio embeddings if `audio_file` is not provided.
        /// </param>
        /// <param name="audioFile">
        /// The audio file for which you wish to create an embedding as a local file. This parameter is required for audio embeddings if `audio_url` is not provided.
        /// </param>
        /// <param name="audioFilename">
        /// The audio file for which you wish to create an embedding as a local file. This parameter is required for audio embeddings if `audio_url` is not provided.
        /// </param>
        /// <param name="audioStartOffsetSec">
        /// Specifies the start time, in seconds, from which the platform generates the audio embeddings. This parameter allows you to skip the initial portion of the audio during processing.<br/>
        /// **Default**: `0`.<br/>
        /// Default Value: 0
        /// </param>
        public CreateRequest9(
            string modelName,
            string? text,
            string? textTruncate,
            string? imageUrl,
            byte[]? imageFile,
            string? imageFilename,
            string? audioUrl,
            byte[]? audioFile,
            string? audioFilename,
            double? audioStartOffsetSec)
        {
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.Text = text;
            this.TextTruncate = textTruncate;
            this.ImageUrl = imageUrl;
            this.ImageFile = imageFile;
            this.ImageFilename = imageFilename;
            this.AudioUrl = audioUrl;
            this.AudioFile = audioFile;
            this.AudioFilename = audioFilename;
            this.AudioStartOffsetSec = audioStartOffsetSec;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRequest9" /> class.
        /// </summary>
        public CreateRequest9()
        {
        }
    }
}