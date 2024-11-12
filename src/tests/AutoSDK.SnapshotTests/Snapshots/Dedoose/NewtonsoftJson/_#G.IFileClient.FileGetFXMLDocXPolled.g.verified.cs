//HintName: G.IFileClient.FileGetFXMLDocXPolled.g.cs
#nullable enable

namespace G
{
    public partial interface IFileClient
    {
        /// <summary>
        /// GetFXMLDocXPolled.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="fileURL"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> FileGetFXMLDocXPolledAsync(
            string? token = default,
            global::System.Guid? projectId = default,
            string? fileURL = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}