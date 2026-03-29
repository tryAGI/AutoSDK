//HintName: G.IScenesClient.CancelSceneBuild.g.cs
#nullable enable

namespace G
{
    public partial interface IScenesClient
    {
        /// <summary>
        /// Cancel scene build
        /// </summary>
        /// <param name="assetID"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CancelSceneBuildAsync(
            global::System.Guid assetID,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}