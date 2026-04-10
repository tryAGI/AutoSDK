//HintName: G.IInstructionsClient.Delete.g.cs
#nullable enable

namespace G
{
    public partial interface IInstructionsClient
    {
        /// <summary>
        /// Delete instruction<br/>
        /// Permanently delete an instruction and all its associated configuration.<br/>
        /// :::warning<br/>
        /// This action cannot be undone. Agents currently using this instruction may fail or behave unexpectedly. Update agents to use different instructions before deleting.<br/>
        /// :::
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="instructionId">
        /// The unique identifier for an instruction.<br/>
        /// Example: ins_customer_support_init
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAsync(
            string instructionId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}