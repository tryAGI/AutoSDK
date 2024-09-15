//HintName: G.IMemoClient.MemoStartImportMemosXML.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoClient
    {
        /// <summary>
        /// StartImportMemosXML.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="fileURI"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> MemoStartImportMemosXMLAsync(
            string? token = default,
            global::System.Guid projectId = default,
            string? fileURI = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}