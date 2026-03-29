//HintName: G.IReportsClient.DeleteReportsByName.g.cs
#nullable enable

namespace G
{
    public partial interface IReportsClient
    {
        /// <summary>
        /// Delete Reports by Name
        /// </summary>
        /// <param name="reportName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteReportsByNameResponse> DeleteReportsByNameAsync(
            string reportName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}