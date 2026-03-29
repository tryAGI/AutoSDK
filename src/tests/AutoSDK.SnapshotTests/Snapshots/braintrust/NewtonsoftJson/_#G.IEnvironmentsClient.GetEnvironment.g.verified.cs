//HintName: G.IEnvironmentsClient.GetEnvironment.g.cs
#nullable enable

namespace G
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// Get environment
        /// </summary>
        /// <param name="environmentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Environment> GetEnvironmentAsync(
            global::System.Guid environmentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}