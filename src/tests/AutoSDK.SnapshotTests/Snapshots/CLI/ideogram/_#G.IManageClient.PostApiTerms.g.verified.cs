//HintName: G.IManageClient.PostApiTerms.g.cs
#nullable enable

namespace G
{
    public partial interface IManageClient
    {
        /// <summary>
        /// Accept terms
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task PostApiTermsAsync(
            global::G.PostApiTermsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Accept terms
        /// </summary>
        /// <param name="termsId">
        /// The ID of the terms which are being accepted.<br/>
        /// Example: TOS_2024_04_20
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PostApiTermsAsync(
            string termsId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}