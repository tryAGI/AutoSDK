//HintName: G.ISubpackageEmbedClient.Create.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageEmbedClient
    {
        /// <summary>
        /// Create embeddings for text, image, and audio<br/>
        /// &lt;Note title="Note"&gt;<br/>
        ///   This endpoint will be deprecated in a future version. Migrate to the [Embed API v2](/v1.3/api-reference/create-embeddings-v2) for continued support and access to new features.<br/>
        /// &lt;/Note&gt;<br/>
        /// This method creates embeddings for text, image, and audio content.<br/>
        /// Ensure your media files meet the following requirements:<br/>
        /// - [Audio files](/v1.3/docs/concepts/models/marengo#audio-requirements).<br/>
        /// - [Image files](/v1.3/docs/concepts/models/marengo#image-requirements).<br/>
        /// Parameters for embeddings:<br/>
        /// - **Common parameters**:<br/>
        ///   - `model_name`: The video understanding model you want to use. Example: "marengo3.0".<br/>
        /// - **Text embeddings**:<br/>
        ///   - `text`: Text for which to create an embedding.<br/>
        /// - **Image embeddings**:<br/>
        ///   Provide one of the following:<br/>
        ///   - `image_url`: Publicly accessible URL of your image file.<br/>
        ///   - `image_file`:  Local image file.<br/>
        /// - **Audio embeddings**:<br/>
        ///   Provide one of the following:<br/>
        ///   - `audio_url`: Publicly accessible URL of your audio file.<br/>
        ///   - `audio_file`: Local audio file.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - The Marengo video understanding model generates embeddings for all modalities in the same latent space. This shared space enables any-to-any searches across different types of content.<br/>
        /// - You can create multiple types of embeddings in a single API call.<br/>
        /// - Audio embeddings combine generic sound and human speech in a single embedding. For videos with transcriptions, you can retrieve transcriptions and then [create text embeddings](/v1.3/api-reference/create-embeddings-v1/text-image-audio-embeddings/create-text-image-audio-embeddings) from these<br/>
        /// - This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EmbeddingResponse> CreateAsync(
            string xApiKey,

            global::G.CreateRequest9 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create embeddings for text, image, and audio<br/>
        /// &lt;Note title="Note"&gt;<br/>
        ///   This endpoint will be deprecated in a future version. Migrate to the [Embed API v2](/v1.3/api-reference/create-embeddings-v2) for continued support and access to new features.<br/>
        /// &lt;/Note&gt;<br/>
        /// This method creates embeddings for text, image, and audio content.<br/>
        /// Ensure your media files meet the following requirements:<br/>
        /// - [Audio files](/v1.3/docs/concepts/models/marengo#audio-requirements).<br/>
        /// - [Image files](/v1.3/docs/concepts/models/marengo#image-requirements).<br/>
        /// Parameters for embeddings:<br/>
        /// - **Common parameters**:<br/>
        ///   - `model_name`: The video understanding model you want to use. Example: "marengo3.0".<br/>
        /// - **Text embeddings**:<br/>
        ///   - `text`: Text for which to create an embedding.<br/>
        /// - **Image embeddings**:<br/>
        ///   Provide one of the following:<br/>
        ///   - `image_url`: Publicly accessible URL of your image file.<br/>
        ///   - `image_file`:  Local image file.<br/>
        /// - **Audio embeddings**:<br/>
        ///   Provide one of the following:<br/>
        ///   - `audio_url`: Publicly accessible URL of your audio file.<br/>
        ///   - `audio_file`: Local audio file.<br/>
        /// &lt;Note title="Notes"&gt;<br/>
        /// - The Marengo video understanding model generates embeddings for all modalities in the same latent space. This shared space enables any-to-any searches across different types of content.<br/>
        /// - You can create multiple types of embeddings in a single API call.<br/>
        /// - Audio embeddings combine generic sound and human speech in a single embedding. For videos with transcriptions, you can retrieve transcriptions and then [create text embeddings](/v1.3/api-reference/create-embeddings-v1/text-image-audio-embeddings/create-text-image-audio-embeddings) from these<br/>
        /// - This endpoint is rate-limited. For details, see the [Rate limits](/v1.3/docs/get-started/rate-limits) page.<br/>
        /// &lt;/Note&gt;
        /// </summary>
        /// <param name="xApiKey"></param>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EmbeddingResponse> CreateAsync(
            string xApiKey,
            string modelName,
            string? text = default,
            string? textTruncate = default,
            string? imageUrl = default,
            byte[]? imageFile = default,
            string? imageFilename = default,
            string? audioUrl = default,
            byte[]? audioFile = default,
            string? audioFilename = default,
            double? audioStartOffsetSec = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}