//HintName: G.IApi.DeepstartApplyPaymentDeepstartApplicationPost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Deepstart Apply
        /// </summary>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeepStartApplicationOut> DeepstartApplyPaymentDeepstartApplicationPostAsync(
            global::G.DeepStartApplicationIn request,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Deepstart Apply
        /// </summary>
        /// <param name="session"></param>
        /// <param name="id"></param>
        /// <param name="uid"></param>
        /// <param name="company"></param>
        /// <param name="ceo"></param>
        /// <param name="funding"></param>
        /// <param name="foundedOn"></param>
        /// <param name="website"></param>
        /// <param name="createdAt"></param>
        /// <param name="status">
        /// Default Value: pending
        /// </param>
        /// <param name="deal"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeepStartApplicationOut> DeepstartApplyPaymentDeepstartApplicationPostAsync(
            string company,
            string ceo,
            string funding,
            string foundedOn,
            string website,
            string? session = default,
            string? id = default,
            string? uid = default,
            int? createdAt = default,
            string? status = default,
            string? deal = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}