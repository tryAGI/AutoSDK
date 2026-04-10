//HintName: G.IExperimentClient.CreateNewPromptVersionForExperiment.g.cs
#nullable enable

namespace G
{
    public partial interface IExperimentClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultPromptVersionResultString> CreateNewPromptVersionForExperimentAsync(
            string experimentId,

            global::G.CreateNewPromptVersionForExperimentParams request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="newHeliconeTemplate"></param>
        /// <param name="isMajorVersion"></param>
        /// <param name="metadata">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="requestExperimentId"></param>
        /// <param name="bumpForMajorPromptVersionId"></param>
        /// <param name="parentPromptVersionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultPromptVersionResultString> CreateNewPromptVersionForExperimentAsync(
            string experimentId,
            object newHeliconeTemplate,
            string parentPromptVersionId,
            bool? isMajorVersion = default,
            global::G.RecordStringAny? metadata = default,
            string? requestExperimentId = default,
            string? bumpForMajorPromptVersionId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}