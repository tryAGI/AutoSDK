//HintName: G.IExperimentsClient.GetExperimentCSV.g.cs
#nullable enable

namespace G
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Download experiment runs as a CSV file
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetExperimentCSVAsync(
            string experimentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}