//HintName: G.IExperimentClient.CreateNewExperiment.g.cs
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
        global::System.Threading.Tasks.Task<global::G.ResultExperimentIdStringString> CreateNewExperimentAsync(

            global::G.CreateNewExperimentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="originalPromptVersion"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultExperimentIdStringString> CreateNewExperimentAsync(
            string originalPromptVersion,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}