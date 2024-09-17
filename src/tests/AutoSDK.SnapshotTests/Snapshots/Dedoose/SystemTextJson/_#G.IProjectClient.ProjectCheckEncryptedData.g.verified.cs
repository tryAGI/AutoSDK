//HintName: G.IProjectClient.ProjectCheckEncryptedData.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectClient
    {
        /// <summary>
        /// CheckEncryptedData.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="encryptedSymKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ProjectCheckEncryptedDataResponse> ProjectCheckEncryptedDataAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            string? encryptedSymKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}