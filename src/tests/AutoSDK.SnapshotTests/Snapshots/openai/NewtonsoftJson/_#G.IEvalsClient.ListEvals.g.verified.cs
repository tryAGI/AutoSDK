//HintName: G.IEvalsClient.ListEvals.g.cs
#nullable enable

namespace G
{
    public partial interface IEvalsClient
    {
        /// <summary>
        /// List evaluations for a project.
        /// </summary>
        /// <param name="after"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// Default Value: asc
        /// </param>
        /// <param name="orderBy">
        /// Default Value: created_at
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EvalList> ListEvalsAsync(
            string? after = default,
            int? limit = default,
            global::G.ListEvalsOrder? order = default,
            global::G.ListEvalsOrderBy? orderBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}