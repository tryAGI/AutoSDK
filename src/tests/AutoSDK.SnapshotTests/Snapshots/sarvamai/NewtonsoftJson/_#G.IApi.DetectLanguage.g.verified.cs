//HintName: G.IApi.DetectLanguage.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Detect language and script<br/>
        /// Identifies the language and script of input text.<br/>
        /// Max 1000 characters per request.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DetectLanguageResponse> DetectLanguageAsync(

            global::G.DetectLanguageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Detect language and script<br/>
        /// Identifies the language and script of input text.<br/>
        /// Max 1000 characters per request.
        /// </summary>
        /// <param name="input">
        /// Text for language and script identification (max 1000 characters)
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DetectLanguageResponse> DetectLanguageAsync(
            string input,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}