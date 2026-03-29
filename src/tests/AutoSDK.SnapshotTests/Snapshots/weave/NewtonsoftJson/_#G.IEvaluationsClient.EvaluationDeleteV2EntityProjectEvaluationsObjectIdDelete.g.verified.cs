//HintName: G.IEvaluationsClient.EvaluationDeleteV2EntityProjectEvaluationsObjectIdDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IEvaluationsClient
    {
        /// <summary>
        /// Evaluation Delete<br/>
        /// Delete an evaluation object.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="project"></param>
        /// <param name="objectId"></param>
        /// <param name="digests">
        /// List of digests to delete. If not provided, all digests for the evaluation will be deleted.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EvaluationDeleteRes> EvaluationDeleteV2EntityProjectEvaluationsObjectIdDeleteAsync(
            string entity,
            string project,
            string objectId,
            global::System.Collections.Generic.IList<string>? digests = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}