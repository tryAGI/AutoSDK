//HintName: G.IUserClient.UpdateUserLanguage.g.cs
#nullable enable

namespace G
{
    public partial interface IUserClient
    {
        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateUserLanguageAsync(
            global::G.UserForUpdateLanguageRequestDto request,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="id"></param>
        /// <param name="language"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateUserLanguageAsync(
            string? currentCulture = default,
            long? id = default,
            string? language = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}