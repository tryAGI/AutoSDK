//HintName: G.IMemoClient.StartImportMemosXML.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoClient
    {
        /// <summary>
        /// StartImportMemosXML<br/>
        /// StartImportMemosXML
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartImportMemosXMLAsync(
            global::G.StartImportMemosXMLRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// StartImportMemosXML<br/>
        /// StartImportMemosXML
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="fileURI"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StartImportMemosXMLAsync(
            global::System.Guid projectId,
            string fileURI,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}