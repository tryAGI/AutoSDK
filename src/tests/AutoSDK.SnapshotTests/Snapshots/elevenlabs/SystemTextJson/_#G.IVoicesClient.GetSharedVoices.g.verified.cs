//HintName: G.IVoicesClient.GetSharedVoices.g.cs
#nullable enable

namespace G
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Get Voices<br/>
        /// Retrieves a list of shared voices.
        /// </summary>
        /// <param name="pageSize">
        /// How many shared voices to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="category">
        /// Voice category used for filtering<br/>
        /// Example: professional
        /// </param>
        /// <param name="gender">
        /// Gender used for filtering<br/>
        /// Example: male
        /// </param>
        /// <param name="age">
        /// Age used for filtering<br/>
        /// Example: young
        /// </param>
        /// <param name="accent">
        /// Accent used for filtering<br/>
        /// Example: american
        /// </param>
        /// <param name="language">
        /// Language used for filtering<br/>
        /// Example: en
        /// </param>
        /// <param name="locale">
        /// Locale used for filtering<br/>
        /// Example: en-US
        /// </param>
        /// <param name="search">
        /// Search term used for filtering<br/>
        /// Example: tiktok
        /// </param>
        /// <param name="useCases">
        /// Use-case used for filtering<br/>
        /// Example: audiobook
        /// </param>
        /// <param name="descriptives">
        /// Search term used for filtering<br/>
        /// Example: tiktok
        /// </param>
        /// <param name="featured">
        /// Filter featured voices<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="minNoticePeriodDays">
        /// Filter voices with a minimum notice period of the given number of days.<br/>
        /// Example: 30
        /// </param>
        /// <param name="readerAppEnabled">
        /// Filter voices that are enabled for the reader app<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="ownerId">
        /// Filter voices by public owner ID<br/>
        /// Example: 7c9fab611d9a0e1fb2e7448a0c294a8804efc2bcc324b0a366a5d5232b7d1532
        /// </param>
        /// <param name="sort">
        /// Sort criteria<br/>
        /// Example: created_date
        /// </param>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetLibraryVoicesResponseModel> GetSharedVoicesAsync(
            int? pageSize = default,
            global::G.GetVoicesV1SharedVoicesGetCategory? category = default,
            string? gender = default,
            string? age = default,
            string? accent = default,
            string? language = default,
            string? locale = default,
            string? search = default,
            global::System.Collections.Generic.IList<string>? useCases = default,
            global::System.Collections.Generic.IList<string>? descriptives = default,
            bool? featured = default,
            int? minNoticePeriodDays = default,
            bool? readerAppEnabled = default,
            string? ownerId = default,
            string? sort = default,
            int? page = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}