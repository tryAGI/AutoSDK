//HintName: G.IAbuseClient.GetAbuse.g.cs
#nullable enable

namespace G
{
    public partial interface IAbuseClient
    {
        /// <summary>
        /// Our abuse contact API returns data containing information belonging to the abuse contact of every IP address on the Internet. Fields included in this response are the abuse contact's email address, postal/ZIP code, city, state, country, name, network, and phone number.<br/>
        /// Our abuse contact API returns data containing information belonging to the abuse contact of every IP address on the Internet. Fields included in this response are the abuse contact's email address, postal/ZIP code, city, state, country, name, network, and phone number.
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AbuseResponse> GetAbuseAsync(
            string ip,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}