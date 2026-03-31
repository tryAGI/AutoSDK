//HintName: G.IPronunciationDictsClient.PronunciationDictsUpdate.g.cs
#nullable enable

namespace G
{
    public partial interface IPronunciationDictsClient
    {
        /// <summary>
        /// Update a pronunciation dictionary
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PronunciationDict> PronunciationDictsUpdateAsync(
            global::G.PronunciationDictsUpdateCartesiaVersion cartesiaVersion,
            string id,

            global::G.UpdatePronunciationDictRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a pronunciation dictionary
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="id"></param>
        /// <param name="name">
        /// New name for the pronunciation dictionary
        /// </param>
        /// <param name="items">
        /// Updated list of pronunciation mappings
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PronunciationDict> PronunciationDictsUpdateAsync(
            global::G.PronunciationDictsUpdateCartesiaVersion cartesiaVersion,
            string id,
            string? name = default,
            global::System.Collections.Generic.IList<global::G.PronunciationDictItem>? items = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}