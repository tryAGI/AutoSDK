//HintName: G.IConfigsClient.UpdateConfigDescription.g.cs
#nullable enable

namespace G
{
    public partial interface IConfigsClient
    {
        /// <summary>
        /// Update config version description
        /// </summary>
        /// <param name="id"></param>
        /// <param name="version"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ReturnConfig> UpdateConfigDescriptionAsync(
            string id,
            int version,

            global::G.PostedConfigVersionDescription request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update config version description
        /// </summary>
        /// <param name="id"></param>
        /// <param name="version"></param>
        /// <param name="versionDescription"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ReturnConfig> UpdateConfigDescriptionAsync(
            string id,
            int version,
            string? versionDescription = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}