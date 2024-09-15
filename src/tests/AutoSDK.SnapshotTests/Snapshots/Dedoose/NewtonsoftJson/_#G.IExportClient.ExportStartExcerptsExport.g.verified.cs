//HintName: G.IExportClient.ExportStartExcerptsExport.g.cs
#nullable enable

namespace G
{
    public partial interface IExportClient
    {
        /// <summary>
        /// StartExcerptsExport.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectId"></param>
        /// <param name="fileExtension"></param>
        /// <param name="exCopyMode"></param>
        /// <param name="sortMode"></param>
        /// <param name="exRange"></param>
        /// <param name="exCreator"></param>
        /// <param name="exDate"></param>
        /// <param name="desInfo"></param>
        /// <param name="docTitle"></param>
        /// <param name="docCreator"></param>
        /// <param name="docDate"></param>
        /// <param name="tagApplied"></param>
        /// <param name="tagWeight"></param>
        /// <param name="tagRange"></param>
        /// <param name="memos"></param>
        /// <param name="symKeyEncrypted"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ExportStartExcerptsExportAsync(
            global::System.Collections.Generic.IList<global::System.Guid> request,
            string? token = default,
            global::System.Guid projectId = default,
            string? fileExtension = default,
            int exCopyMode = default,
            int sortMode = default,
            bool exRange = default,
            bool exCreator = default,
            bool exDate = default,
            bool desInfo = default,
            bool docTitle = default,
            bool docCreator = default,
            bool docDate = default,
            bool tagApplied = default,
            bool tagWeight = default,
            bool tagRange = default,
            bool memos = default,
            string? symKeyEncrypted = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}