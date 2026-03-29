//HintName: G.IExperimentClient.UpdateExperimentCell.g.cs
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
        global::System.Threading.Tasks.Task<global::G.ResultNullString> UpdateExperimentCellAsync(
            string experimentTableId,

            global::G.UpdateExperimentCellRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="experimentTableId"></param>
        /// <param name="updateInputs"></param>
        /// <param name="metadata"></param>
        /// <param name="value"></param>
        /// <param name="status"></param>
        /// <param name="cellId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultNullString> UpdateExperimentCellAsync(
            string experimentTableId,
            string cellId,
            bool? updateInputs = default,
            string? metadata = default,
            string? value = default,
            string? status = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}