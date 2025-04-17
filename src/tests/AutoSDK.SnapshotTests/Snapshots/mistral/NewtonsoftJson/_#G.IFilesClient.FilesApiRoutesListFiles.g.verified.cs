//HintName: G.IFilesClient.FilesApiRoutesListFiles.g.cs
#nullable enable

namespace G
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// List Files<br/>
        /// Returns a list of files that belong to the user's organization.
        /// </summary>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 100
        /// </param>
        /// <param name="sampleType"></param>
        /// <param name="source"></param>
        /// <param name="search"></param>
        /// <param name="purpose"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListFilesOut> FilesApiRoutesListFilesAsync(
            int? page = default,
            int? pageSize = default,
            global::System.Collections.Generic.IList<global::G.SampleType>? sampleType = default,
            global::System.Collections.Generic.IList<global::G.Source>? source = default,
            string? search = default,
            object? purpose = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}