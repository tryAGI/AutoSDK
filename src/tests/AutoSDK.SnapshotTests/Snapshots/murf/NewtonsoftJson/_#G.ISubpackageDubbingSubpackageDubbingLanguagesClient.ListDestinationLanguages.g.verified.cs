//HintName: G.ISubpackageDubbingSubpackageDubbingLanguagesClient.ListDestinationLanguages.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageDubbingSubpackageDubbingLanguagesClient
    {
        /// <summary>
        /// List Destination Languages
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.LocaleResponse>> ListDestinationLanguagesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}