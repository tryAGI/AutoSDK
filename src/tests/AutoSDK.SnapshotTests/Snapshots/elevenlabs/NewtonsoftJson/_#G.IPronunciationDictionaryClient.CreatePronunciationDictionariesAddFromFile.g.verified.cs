//HintName: G.IPronunciationDictionaryClient.CreatePronunciationDictionariesAddFromFile.g.cs
#nullable enable

namespace G
{
    public partial interface IPronunciationDictionaryClient
    {
        /// <summary>
        /// Add A Pronunciation Dictionary<br/>
        /// Creates a new pronunciation dictionary from a lexicon .PLS file
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddPronunciationDictionaryResponseModel> CreatePronunciationDictionariesAddFromFileAsync(
            global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add A Pronunciation Dictionary<br/>
        /// Creates a new pronunciation dictionary from a lexicon .PLS file
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="name">
        /// The name of the pronunciation dictionary, used for identification only.
        /// </param>
        /// <param name="file">
        /// A lexicon .pls file which we will use to initialize the project with.
        /// </param>
        /// <param name="filename">
        /// A lexicon .pls file which we will use to initialize the project with.
        /// </param>
        /// <param name="description">
        /// A description of the pronunciation dictionary, used for identification only.
        /// </param>
        /// <param name="workspaceAccess">
        /// Should be one of 'editor' or 'viewer'. If not provided, defaults to no access.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AddPronunciationDictionaryResponseModel> CreatePronunciationDictionariesAddFromFileAsync(
            string name,
            string? xiApiKey = default,
            byte[]? file = default,
            string? filename = default,
            string? description = default,
            global::G.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess? workspaceAccess = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}