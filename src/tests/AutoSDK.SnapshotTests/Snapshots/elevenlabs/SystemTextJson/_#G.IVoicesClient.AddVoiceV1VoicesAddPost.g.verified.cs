//HintName: G.IVoicesClient.AddVoiceV1VoicesAddPost.g.cs
#nullable enable

namespace G
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Add Voice<br/>
        /// Add a new voice to your collection of voices in VoiceLab.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddVoiceResponseModel> AddVoiceV1VoicesAddPostAsync(
            global::G.BodyAddVoiceV1VoicesAddPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add Voice<br/>
        /// Add a new voice to your collection of voices in VoiceLab.
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="name">
        /// The name that identifies this voice. This will be displayed in the dropdown of the website.
        /// </param>
        /// <param name="files">
        /// A list of file paths to audio recordings intended for voice cloning
        /// </param>
        /// <param name="removeBackgroundNoise">
        /// If set will remove background noise for voice samples using our audio isolation model. If the samples do not include background noise, it can make the quality worse.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="description">
        /// How would you describe the voice?
        /// </param>
        /// <param name="labels">
        /// Serialized labels dictionary for the voice.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddVoiceResponseModel> AddVoiceV1VoicesAddPostAsync(
            string name,
            global::System.Collections.Generic.IList<byte[]> files,
            string? xiApiKey = default,
            bool? removeBackgroundNoise = false,
            string? description = default,
            string? labels = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}