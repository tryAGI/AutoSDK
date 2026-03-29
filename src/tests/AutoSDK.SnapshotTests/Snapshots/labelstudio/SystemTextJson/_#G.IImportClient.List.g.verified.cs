//HintName: G.IImportClient.List.g.cs
#nullable enable

namespace G
{
    public partial interface IImportClient
    {
        /// <summary>
        /// Get files list<br/>
        ///         Retrieve the list of uploaded files used to create labeling tasks for a specific project.<br/>
        ///         
        /// </summary>
        /// <param name="all"></param>
        /// <param name="id"></param>
        /// <param name="ids"></param>
        /// <param name="ordering"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.FileUpload>> ListAsync(
            int id,
            bool? all = default,
            global::System.Collections.Generic.IList<string>? ids = default,
            string? ordering = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}