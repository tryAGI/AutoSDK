//HintName: G.IApi.OpenGetSpaceFolder.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 查询文件夹列表<br/>
        /// {"0":{"ops":[{"insert":"工作空间中的用户可以查询工作空间中的文件夹列表。\n"},{"attributes":{"anchor":"6aa831bb","heading":"h2","lmkr":"1"},"insert":"*"},{"insert":"接口描述\n"},{"attributes":{"lmkr":"1"},"insert":"*"},{"insert":"你可以查询某个文件夹或工作空间根目录下的子文件夹列表。每次查询仅返回下一层级的文件夹信息，不包含更深层级的子文件夹。若需要获取更深层级的文件夹信息，你可以多次调用本 API，利用上一次查询返回的文件夹 ID 继续查询。\n"}],"zoneId":"0","zoneType":"Z"}}
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="folderType"></param>
        /// <param name="parentFolderId"></param>
        /// <param name="pageNum"></param>
        /// <param name="pageSize"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OpenGetSpaceFolderResponse> OpenGetSpaceFolderAsync(
            string workspaceId,
            global::G.FolderType folderType,
            string? parentFolderId = default,
            int? pageNum = default,
            int? pageSize = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}