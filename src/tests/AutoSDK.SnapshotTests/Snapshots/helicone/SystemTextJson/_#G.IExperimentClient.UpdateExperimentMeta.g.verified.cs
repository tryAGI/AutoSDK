//HintName: G.IExperimentClient.UpdateExperimentMeta.g.cs
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
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.ResultErrorString, global::G.ResultSuccessUnknown>> UpdateExperimentMetaAsync(

            global::G.UpdateExperimentMetaRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="meta">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="experimentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.ResultErrorString, global::G.ResultSuccessUnknown>> UpdateExperimentMetaAsync(
            global::System.Collections.Generic.Dictionary<string, string> meta,
            string experimentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}