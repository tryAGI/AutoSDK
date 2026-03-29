//HintName: G.ISubpackageTextClient.Translate.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageTextClient
    {
        /// <summary>
        /// Translate
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MurfApiTranslationResponse> TranslateAsync(

            global::G.MurfApiTranslationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Translate
        /// </summary>
        /// <param name="targetLanguage">
        /// The language code for the target translation
        /// </param>
        /// <param name="texts">
        /// List of texts to translate
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MurfApiTranslationResponse> TranslateAsync(
            string targetLanguage,
            global::System.Collections.Generic.IList<string> texts,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}