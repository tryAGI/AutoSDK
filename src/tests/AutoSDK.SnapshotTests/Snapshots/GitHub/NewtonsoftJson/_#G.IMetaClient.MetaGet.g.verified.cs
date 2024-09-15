//HintName: G.IMetaClient.MetaGet.g.cs
#nullable enable

namespace G
{
    public partial interface IMetaClient
    {
        /// <summary>
        /// Get GitHub meta information<br/>
        /// Returns meta information about GitHub, including a list of GitHub's IP addresses. For more information, see "[About GitHub's IP addresses](https://docs.github.com/articles/about-github-s-ip-addresses/)."<br/>
        /// The API's response also includes a list of GitHub's domain names.<br/>
        /// The values shown in the documentation's response are example values. You must always query the API directly to get the latest values.<br/>
        /// **Note:** This endpoint returns both IPv4 and IPv6 addresses. However, not all features support IPv6. You should refer to the specific documentation for each feature to determine if IPv6 is supported.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ApiOverview> MetaGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}