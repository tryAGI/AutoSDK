//HintName: G.IRangesClient.GetRanges.g.cs
#nullable enable

namespace G
{
    public partial interface IRangesClient
    {
        /// <summary>
        /// Our IP address ranges API returns a list of all of the IP addresses ranges assigned to or operated by a company, identified by the provided domain name.<br/>
        /// Returns information about a domain ranges.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RangesResponse> GetRangesAsync(
            string domain,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}