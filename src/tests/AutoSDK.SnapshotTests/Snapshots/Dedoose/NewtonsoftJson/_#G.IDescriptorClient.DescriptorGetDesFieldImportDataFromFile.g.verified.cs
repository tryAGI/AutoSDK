//HintName: G.IDescriptorClient.DescriptorGetDesFieldImportDataFromFile.g.cs
#nullable enable

namespace G
{
    public partial interface IDescriptorClient
    {
        /// <summary>
        /// GetDesFieldImportDataFromFile.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="relativeFileURL"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DescriptorGetDesFieldImportDataFromFileAsync(
            string? token = default,
            string? relativeFileURL = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}