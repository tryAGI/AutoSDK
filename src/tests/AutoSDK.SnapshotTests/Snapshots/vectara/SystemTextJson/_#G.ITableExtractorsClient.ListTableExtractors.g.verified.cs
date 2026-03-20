//HintName: G.ITableExtractorsClient.ListTableExtractors.g.cs
#nullable enable

namespace G
{
    public partial interface ITableExtractorsClient
    {
        /// <summary>
        /// List supported table extractors<br/>
        /// Table extractors are used to extract tabular data from documents during indexing.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListTableExtractorsResponse> ListTableExtractorsAsync(
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}