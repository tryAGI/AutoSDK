//HintName: G.IIntegrationClient.CreateIntegration.g.cs
#nullable enable

namespace G
{
    public partial interface IIntegrationClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultIdStringString> CreateIntegrationAsync(

            global::G.IntegrationCreateParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="integrationName"></param>
        /// <param name="settings"></param>
        /// <param name="active"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ResultIdStringString> CreateIntegrationAsync(
            string integrationName,
            global::G.Json? settings = default,
            bool? active = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}