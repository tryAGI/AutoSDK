//HintName: G.IPvcVoicesClient.CreateVoicesPvc.g.cs
#nullable enable

namespace G
{
    public partial interface IPvcVoicesClient
    {
        /// <summary>
        /// Create Pvc Voice<br/>
        /// Creates a new PVC voice with metadata but no samples
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddVoiceResponseModel> CreateVoicesPvcAsync(
            global::G.BodyCreatePVCVoiceV1VoicesPvcPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Pvc Voice<br/>
        /// Creates a new PVC voice with metadata but no samples
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="name">
        /// The name that identifies this voice. This will be displayed in the dropdown of the website.<br/>
        /// Example: John Smith
        /// </param>
        /// <param name="language">
        /// Language used in the samples.<br/>
        /// Example: en
        /// </param>
        /// <param name="description">
        /// Description to use for the created voice.<br/>
        /// Example: An old American male voice with a slight hoarseness in his throat. Perfect for news.
        /// </param>
        /// <param name="labels">
        /// Serialized labels dictionary for the voice.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddVoiceResponseModel> CreateVoicesPvcAsync(
            string name,
            string language,
            string? xiApiKey = default,
            string? description = default,
            global::System.Collections.Generic.Dictionary<string, string>? labels = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}