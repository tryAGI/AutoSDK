//HintName: G.IVoicesClient.VoicesUpdate.g.cs
#nullable enable

namespace G
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Update Voice<br/>
        /// Update the name, description, and gender of a voice. To set the gender back to the default, set the gender to `null`. If gender is not specified, the gender will not be updated.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="id">
        /// The ID of the voice.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Voice> VoicesUpdateAsync(
            global::G.VoicesUpdateCartesiaVersion cartesiaVersion,
            string id,

            global::G.UpdateVoiceRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Voice<br/>
        /// Update the name, description, and gender of a voice. To set the gender back to the default, set the gender to `null`. If gender is not specified, the gender will not be updated.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="id">
        /// The ID of the voice.
        /// </param>
        /// <param name="name">
        /// The name of the voice.
        /// </param>
        /// <param name="description">
        /// The description of the voice.
        /// </param>
        /// <param name="gender"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Voice> VoicesUpdateAsync(
            global::G.VoicesUpdateCartesiaVersion cartesiaVersion,
            string id,
            string name,
            string description,
            global::G.GenderPresentation? gender = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}