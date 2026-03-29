//HintName: G.ISubpackageDubbingSubpackageDubbingLanguagesClient.ListSourceLanguages.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageDubbingSubpackageDubbingLanguagesClient
    {
        /// <summary>
        /// List Source Languages
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.SourceLocaleResponse>> ListSourceLanguagesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}