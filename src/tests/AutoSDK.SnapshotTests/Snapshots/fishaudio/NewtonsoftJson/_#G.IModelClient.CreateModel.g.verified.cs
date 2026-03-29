//HintName: G.IModelClient.CreateModel.g.cs
#nullable enable

namespace G
{
    public partial interface IModelClient
    {
        /// <summary>
        /// Create Model
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateModelResponse> CreateModelAsync(

            global::G.CreateModelRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Model
        /// </summary>
        /// <param name="visibility">
        /// Model visibility, public will be shown in the discovery page, unlist allows anyone with the link to access, private only be visible to the creator<br/>
        /// Default Value: public
        /// </param>
        /// <param name="type">
        /// Model type, tts is for text to speech
        /// </param>
        /// <param name="title">
        /// Model title or name
        /// </param>
        /// <param name="description">
        /// Model description<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="coverImage">
        /// Model cover image, this is required if the model is public<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="coverImagename">
        /// Model cover image, this is required if the model is public<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="trainMode">
        /// Model train mode, for TTS model, fast means model instantly available after creation
        /// </param>
        /// <param name="voices">
        /// Upload voices files that will be used to tune the model
        /// </param>
        /// <param name="texts">
        /// Texts corresponding to the voices, if unspecified, ASR will be performed on the voices<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="tags">
        /// Model tags
        /// </param>
        /// <param name="enhanceAudioQuality">
        /// Enhance audio quality<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateModelResponse> CreateModelAsync(
            string title,
            global::G.AnyOf<global::System.Collections.Generic.IList<byte[]>, byte[]> voices,
            global::G.CreateModelRequestVisibility? visibility = default,
            global::G.CreateModelRequestType type = default,
            string? description = default,
            byte[]? coverImage = default,
            string? coverImagename = default,
            global::G.CreateModelRequestTrainMode trainMode = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, string, object>? texts = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, string, object>? tags = default,
            bool? enhanceAudioQuality = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}