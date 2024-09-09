//HintName: G.ExportClient.ExportStartExcerptsExport.g.cs

#nullable enable

namespace G
{
    public partial class ExportClient
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ExportStartExcerptsExportAsync(
            string token,
            string projectId,
            string fileExtension,
            int exCopyMode,
            int sortMode,
            bool exRange,
            bool exCreator,
            bool exDate,
            bool desInfo,
            bool docTitle,
            bool docCreator,
            bool docDate,
            bool tagApplied,
            bool tagWeight,
            bool tagRange,
            bool memos,
            string symKeyEncrypted,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/api/v1/export/startexcerptsexport?projectId={projectId}&FileExtension={fileExtension}&ExCopyMode={exCopyMode}&SortMode={sortMode}&ExRange={exRange}&ExCreator={exCreator}&ExDate={exDate}&DesInfo={desInfo}&DocTitle={docTitle}&DocCreator={docCreator}&DocDate={docDate}&TagApplied={tagApplied}&TagWeight={tagWeight}&TagRange={tagRange}&Memos={memos}&symKeyEncrypted={symKeyEncrypted}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}