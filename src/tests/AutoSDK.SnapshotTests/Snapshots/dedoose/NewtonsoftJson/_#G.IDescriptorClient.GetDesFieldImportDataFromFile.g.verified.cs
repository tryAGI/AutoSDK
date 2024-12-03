//HintName: G.IDescriptorClient.GetDesFieldImportDataFromFile.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// GetDesFieldImportDataFromFile<br/>
        /// GetDesFieldImportDataFromFile
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetDesFieldImportDataFromFileAsync(
            global::G.GetDesFieldImportDataFromFileRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// GetDesFieldImportDataFromFile<br/>
        /// GetDesFieldImportDataFromFile
        /// </summary>
        /// <param name="relativeFileURL"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetDesFieldImportDataFromFileAsync(
            string relativeFileURL,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}