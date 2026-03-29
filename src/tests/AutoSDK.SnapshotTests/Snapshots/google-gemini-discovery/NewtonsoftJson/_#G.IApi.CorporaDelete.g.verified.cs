//HintName: G.IApi.CorporaDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Deletes a `Corpus`.
        /// </summary>
        /// <param name="force"></param>
        /// <param name="corporaId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Empty> CorporaDeleteAsync(
            string corporaId,
            bool? force = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}