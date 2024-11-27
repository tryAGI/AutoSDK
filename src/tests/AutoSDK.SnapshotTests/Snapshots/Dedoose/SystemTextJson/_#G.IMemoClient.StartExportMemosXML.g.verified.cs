//HintName: G.IMemoClient.StartExportMemosXML.g.cs
#nullable enable

namespace G
{
    public partial interface IMemoClient
    {
        /// <summary>
        /// StartExportMemosXML<br/>
        /// StartExportMemosXML
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> StartExportMemosXMLAsync(
            global::G.StartExportMemosXMLRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// StartExportMemosXML<br/>
        /// StartExportMemosXML
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="memoIds"></param>
        /// <param name="codeSelection"></param>
        /// <param name="mediaSelection"></param>
        /// <param name="excerptsSelection"></param>
        /// <param name="descriptorsSelection"></param>
        /// <param name="symKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> StartExportMemosXMLAsync(
            global::System.Guid projectId,
            global::System.Collections.Generic.IList<global::System.Guid> memoIds,
            int codeSelection,
            int mediaSelection,
            int excerptsSelection,
            int descriptorsSelection,
            string symKey,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}