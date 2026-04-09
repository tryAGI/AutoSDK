//HintName: G.IVoicesClient.VoicesList.g.cs
#nullable enable

namespace G
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// List Voices
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="limit"></param>
        /// <param name="startingAfter"></param>
        /// <param name="endingBefore"></param>
        /// <param name="q"></param>
        /// <param name="isOwner"></param>
        /// <param name="gender"></param>
        /// <param name="expand"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetVoicesResponse> VoicesListAsync(
            global::G.VoicesListCartesiaVersion cartesiaVersion,
            int? limit = default,
            string? startingAfter = default,
            string? endingBefore = default,
            string? q = default,
            bool? isOwner = default,
            global::G.GenderPresentation? gender = default,
            global::System.Collections.Generic.IList<global::G.VoiceExpandOptions>? expand = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}