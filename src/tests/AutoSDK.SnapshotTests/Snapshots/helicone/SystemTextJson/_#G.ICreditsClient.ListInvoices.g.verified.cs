//HintName: G.ICreditsClient.ListInvoices.g.cs
#nullable enable

namespace G
{
    public partial interface ICreditsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultPTBInvoiceArrayString> ListInvoicesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}