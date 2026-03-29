//HintName: G.ITranslationsClient.PutTranslationsByRootVideoId.g.cs
#nullable enable

namespace G
{
    public partial interface ITranslationsClient
    {
        /// <summary>
        /// Start/Update a video translation<br/>
        /// Kick off TranslateVideoWorkflow for each requested target language. Returns a unified `translations` list. Each entry includes a `startedByRequest` flag: `true` if the workflow was started by this request, `false` if it was already in progress.
        /// </summary>
        /// <param name="rootVideoId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpsertVideoTranslationsSuccessApiResponse> PutTranslationsByRootVideoIdAsync(
            global::System.Guid rootVideoId,

            global::G.UpsertVideoTranslationsApiRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start/Update a video translation<br/>
        /// Kick off TranslateVideoWorkflow for each requested target language. Returns a unified `translations` list. Each entry includes a `startedByRequest` flag: `true` if the workflow was started by this request, `false` if it was already in progress.
        /// </summary>
        /// <param name="rootVideoId"></param>
        /// <param name="targetLanguages">
        /// List of language codes to translate the video into. See https://docs.synthesia.io/docs/supported-languages for accepted values.<br/>
        /// Example: [es, fr]
        /// </param>
        /// <param name="translateScriptOnly">
        /// If true, only the script is translated without regenerating the video. Cannot be combined with autoGenerate.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="autoGenerate">
        /// Automatically generate the translated video after translation completes. Set to 'private' to generate without sharing publicly, or 'public' to generate and publish immediately.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpsertVideoTranslationsSuccessApiResponse> PutTranslationsByRootVideoIdAsync(
            global::System.Guid rootVideoId,
            global::System.Collections.Generic.IList<string> targetLanguages,
            bool? translateScriptOnly = default,
            global::G.UpsertVideoTranslationsApiRequestAutoGenerate? autoGenerate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}