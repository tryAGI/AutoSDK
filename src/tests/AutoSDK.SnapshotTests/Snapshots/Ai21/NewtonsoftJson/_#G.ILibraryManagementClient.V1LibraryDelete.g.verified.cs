//HintName: G.ILibraryManagementClient.V1LibraryDelete.g.cs
#nullable enable

namespace G
{
    public partial interface ILibraryManagementClient
    {
        /// <summary>
        /// Delete File<br/>
        /// Delete the specified file from the library.<br/>
        /// **Restrictions**:<br/>
        /// Files in `PROCESSING` status cannot be deleted. Attempts to delete such files will result in a &lt;span style="color:red"&gt;422&lt;/span&gt; error.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="requestStartTime">
        /// Default Value: 1730898830008
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FileDeleteResponse> V1LibraryDeleteAsync(
            global::System.Guid fileId,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}