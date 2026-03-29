//HintName: G.IEvaluationsClient.EvaluationListV2EntityProjectEvaluationsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IEvaluationsClient
    {
        /// <summary>
        /// Evaluation List<br/>
        /// List evaluation objects.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> EvaluationListV2EntityProjectEvaluationsGetAsync(
            string entity,
            string project,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}