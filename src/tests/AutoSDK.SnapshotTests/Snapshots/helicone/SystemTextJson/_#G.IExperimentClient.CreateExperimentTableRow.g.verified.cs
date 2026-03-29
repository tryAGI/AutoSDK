//HintName: G.IExperimentClient.CreateExperimentTableRow.g.cs
#nullable enable

namespace G
{
    public partial interface IExperimentClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="experimentTableId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultNullString> CreateExperimentTableRowAsync(
            string experimentTableId,

            global::G.CreateExperimentTableRowRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="experimentTableId"></param>
        /// <param name="inputs">
        /// Construct a type with a set of properties K of type T
        /// </param>
        /// <param name="sourceRequest"></param>
        /// <param name="promptVersionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultNullString> CreateExperimentTableRowAsync(
            string experimentTableId,
            string promptVersionId,
            global::System.Collections.Generic.Dictionary<string, string>? inputs = default,
            string? sourceRequest = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}