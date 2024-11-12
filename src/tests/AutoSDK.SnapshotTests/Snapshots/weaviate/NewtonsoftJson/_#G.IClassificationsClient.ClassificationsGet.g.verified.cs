//HintName: G.IClassificationsClient.ClassificationsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IClassificationsClient
    {
        /// <summary>
        /// View previously created classification<br/>
        /// Get status, results and metadata of a previously created classification
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Classification> ClassificationsGetAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}