//HintName: G.IIntegrationClient.GetIntegration.g.cs
#nullable enable

namespace G
{
    public partial interface IIntegrationClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="integrationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultIntegrationString> GetIntegrationAsync(
            string integrationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}