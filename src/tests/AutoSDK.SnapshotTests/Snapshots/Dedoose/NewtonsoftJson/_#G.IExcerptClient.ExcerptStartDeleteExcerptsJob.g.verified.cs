//HintName: G.IExcerptClient.ExcerptStartDeleteExcerptsJob.g.cs
#nullable enable

namespace G
{
    public partial interface IExcerptClient
    {
        /// <summary>
        /// StartDeleteExcerptsJob.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="currentProjectId"></param>
        /// <param name="excerptIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ExcerptStartDeleteExcerptsJobAsync(
            string? token = default,
            global::System.Guid? currentProjectId = default,
            global::System.Collections.Generic.IList<global::System.Guid>? excerptIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}