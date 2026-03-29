//HintName: G.IFineTunesClient.FineTunesList.g.cs
#nullable enable

namespace G
{
    public partial interface IFineTunesClient
    {
        /// <summary>
        /// Paginated list of all fine-tunes for the authenticated user
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="limit"></param>
        /// <param name="startingAfter"></param>
        /// <param name="endingBefore"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PaginatedFineTunes> FineTunesListAsync(
            global::G.FineTunesListCartesiaVersion cartesiaVersion,
            int? limit = default,
            string? startingAfter = default,
            string? endingBefore = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}