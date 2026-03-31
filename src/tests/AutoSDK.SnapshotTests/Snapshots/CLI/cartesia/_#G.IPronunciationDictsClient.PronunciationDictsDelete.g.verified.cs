//HintName: G.IPronunciationDictsClient.PronunciationDictsDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IPronunciationDictsClient
    {
        /// <summary>
        /// Delete a pronunciation dictionary
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task PronunciationDictsDeleteAsync(
            global::G.PronunciationDictsDeleteCartesiaVersion cartesiaVersion,
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}