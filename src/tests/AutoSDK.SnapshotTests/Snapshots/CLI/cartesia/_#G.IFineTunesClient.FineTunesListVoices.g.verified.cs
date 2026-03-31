//HintName: G.IFineTunesClient.FineTunesListVoices.g.cs
#nullable enable

namespace G
{
    public partial interface IFineTunesClient
    {
        /// <summary>
        /// List all voices created from a fine-tune
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="id"></param>
        /// <param name="limit"></param>
        /// <param name="startingAfter"></param>
        /// <param name="endingBefore"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PaginatedVoices> FineTunesListVoicesAsync(
            global::G.FineTunesListVoicesCartesiaVersion cartesiaVersion,
            string id,
            int? limit = default,
            string? startingAfter = default,
            string? endingBefore = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}