//HintName: G.IExperimentClient.CreateNewExperimentOld.g.cs
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
        global::System.Threading.Tasks.Task<global::G.ResultExperimentIdStringString> CreateNewExperimentOldAsync(

            global::G.NewExperimentParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="promptVersion"></param>
        /// <param name="model"></param>
        /// <param name="providerKeyId"></param>
        /// <param name="meta"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultExperimentIdStringString> CreateNewExperimentOldAsync(
            string datasetId,
            string promptVersion,
            string model,
            string providerKeyId,
            object? meta = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}