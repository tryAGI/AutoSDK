//HintName: G.IAsnClient.GetAsn.g.cs
#nullable enable

namespace G
{
    public partial interface IAsnClient
    {
        /// <summary>
        /// Returns information about an ASN, such as the assigned prefixes, related domain, and more.<br/>
        /// Returns information about an AS.
        /// </summary>
        /// <param name="asn"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AsnResponse> GetAsnAsync(
            int asn,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}