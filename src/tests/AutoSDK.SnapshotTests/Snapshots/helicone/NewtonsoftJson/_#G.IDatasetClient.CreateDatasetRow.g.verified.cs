//HintName: G.IDatasetClient.CreateDatasetRow.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="promptVersionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultStringString> CreateDatasetRowAsync(
            string datasetId,
            string promptVersionId,

            global::G.CreateDatasetRowRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="promptVersionId"></param>
        /// <param name="sourceRequest"></param>
        /// <param name="inputs">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultStringString> CreateDatasetRowAsync(
            string datasetId,
            string promptVersionId,
            global::System.Collections.Generic.Dictionary<string, string> inputs,
            string? sourceRequest = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}