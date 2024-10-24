//HintName: G.IDomainsClient.GetDomains.g.cs
#nullable enable

namespace G
{
    public partial interface IDomainsClient
    {
        /// <summary>
        /// Our Hosted Domains, or Reverse IP API returns a list of all of the domains hosted on the provided IP address.<br/>
        /// Returns a list of all of the domains hosted on the provided IP address.
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="page"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DomainsResponse> GetDomainsAsync(
            string ip,
            int? page = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}