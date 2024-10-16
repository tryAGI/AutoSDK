//HintName: G.IVoicesClient.GetSharedVoices.g.cs
#nullable enable

namespace G
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Get Voices<br/>
        /// Gets a list of shared voices.
        /// </summary>
        /// <param name="pageSize">
        /// How many shared voices to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="category">
        /// voice category used for filtering
        /// </param>
        /// <param name="gender">
        /// gender used for filtering
        /// </param>
        /// <param name="age">
        /// age used for filtering
        /// </param>
        /// <param name="accent">
        /// accent used for filtering
        /// </param>
        /// <param name="language">
        /// language used for filtering
        /// </param>
        /// <param name="search">
        /// search term used for filtering
        /// </param>
        /// <param name="useCases">
        /// use-case used for filtering
        /// </param>
        /// <param name="descriptives">
        /// search term used for filtering
        /// </param>
        /// <param name="featured">
        /// Filter featured voices<br/>
        /// Default Value: false
        /// </param>
        /// <param name="readerAppEnabled">
        /// Filter voices that are enabled for the reader app<br/>
        /// Default Value: false
        /// </param>
        /// <param name="ownerId">
        /// Filter voices by public owner ID
        /// </param>
        /// <param name="sort">
        /// sort criteria
        /// </param>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetLibraryVoicesResponseModel> GetSharedVoicesAsync(
            int? pageSize = 30,
            string? category = default,
            string? gender = default,
            string? age = default,
            string? accent = default,
            string? language = default,
            string? search = default,
            global::System.Collections.Generic.IList<string>? useCases = default,
            global::System.Collections.Generic.IList<string>? descriptives = default,
            bool? featured = false,
            bool? readerAppEnabled = false,
            string? ownerId = default,
            string? sort = default,
            int? page = 0,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}