//HintName: G.IExperimentClient.GetExperimentsOld.g.cs
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
        global::System.Threading.Tasks.Task<global::G.ResultExperimentArrayString> GetExperimentsOldAsync(

            global::G.GetExperimentsOldRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="include"></param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultExperimentArrayString> GetExperimentsOldAsync(
            global::G.ExperimentFilterNode filter,
            global::G.IncludeExperimentKeys? include = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}