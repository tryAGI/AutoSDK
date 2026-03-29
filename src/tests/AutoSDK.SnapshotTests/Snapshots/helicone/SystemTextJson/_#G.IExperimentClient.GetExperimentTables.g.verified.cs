//HintName: G.IExperimentClient.GetExperimentTables.g.cs
#nullable enable

namespace G
{
    public partial interface IExperimentClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultExperimentTableSimplifiedArrayString> GetExperimentTablesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}