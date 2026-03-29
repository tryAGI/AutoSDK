//HintName: G.ITracesClient.GetEvaluations.g.cs
#nullable enable

namespace G
{
    public partial interface ITracesClient
    {
        /// <summary>
        /// Get span, trace, or document evaluations from a project
        /// </summary>
        /// <param name="projectName">
        /// The name of the project to get evaluations from (if omitted, evaluations will be drawn from the `default` project)
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetEvaluationsAsync(
            string? projectName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}