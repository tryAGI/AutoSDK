//HintName: G.IInferenceClient.NvidiaHardwareInferenceNvidiaV2HardwareGet.g.cs
#nullable enable

namespace G
{
    public partial interface IInferenceClient
    {
        /// <summary>
        /// Nvidia Hardware<br/>
        /// Returns available hardware and pricing for a given model.<br/>
        /// Called by NVIDIA to show users their options and redirect them<br/>
        /// based on what we support.  Only serverless options are returned.
        /// </summary>
        /// <param name="model">
        /// Model name without the publisher prefix
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.NvidiaHardwareRes> NvidiaHardwareInferenceNvidiaV2HardwareGetAsync(
            string model,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}