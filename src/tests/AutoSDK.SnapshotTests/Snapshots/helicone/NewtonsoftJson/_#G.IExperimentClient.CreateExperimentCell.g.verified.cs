//HintName: G.IExperimentClient.CreateExperimentCell.g.cs
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
        global::System.Threading.Tasks.Task<global::G.ResultNullString> CreateExperimentCellAsync(
            string experimentTableId,

            global::G.CreateExperimentCellRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="experimentTableId"></param>
        /// <param name="value"></param>
        /// <param name="rowIndex"></param>
        /// <param name="columnId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultNullString> CreateExperimentCellAsync(
            string experimentTableId,
            double rowIndex,
            string columnId,
            string? value = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}