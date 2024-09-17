//HintName: G.ICreditClient.GetRemainingCredit.g.cs
#nullable enable

namespace G
{
    public partial interface ICreditClient
    {
        /// <summary>
        /// Get the remaining Instill Credit<br/>
        /// This endpoint returns the remaining [Instill Credit](https://www.instill.tech/docs/vdp/credit) of a given user or<br/>
        /// organization. The requested credit owner must be either the authenticated<br/>
        /// user or an organization they belong to.<br/>
        /// On Instill Core, this endpoint will return a 404 Not Found status.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetRemainingCreditResponse> GetRemainingCreditAsync(
            string namespaceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}