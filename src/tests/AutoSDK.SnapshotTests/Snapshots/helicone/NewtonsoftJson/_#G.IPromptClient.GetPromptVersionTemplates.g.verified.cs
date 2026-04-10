//HintName: G.IPromptClient.GetPromptVersionTemplates.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userDefinedId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultPromptVersionResultFilledString> GetPromptVersionTemplatesAsync(
            string userDefinedId,

            global::G.PromptVersiosQueryParamsCompiled request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userDefinedId"></param>
        /// <param name="filter"></param>
        /// <param name="includeExperimentVersions"></param>
        /// <param name="inputs">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultPromptVersionResultFilledString> GetPromptVersionTemplatesAsync(
            string userDefinedId,
            global::System.Collections.Generic.Dictionary<string, string> inputs,
            global::G.PromptVersionsFilterNode? filter = default,
            bool? includeExperimentVersions = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}