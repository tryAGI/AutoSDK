//HintName: G.IExperimentClient.CreateNewEmptyExperiment.g.cs
#nullable enable

namespace G
{
    public partial interface IExperimentClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultExperimentIdStringString> CreateNewEmptyExperimentAsync(

            global::G.CreateNewEmptyExperimentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="metadata">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultExperimentIdStringString> CreateNewEmptyExperimentAsync(
            string datasetId,
            global::System.Collections.Generic.Dictionary<string, string> metadata,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}