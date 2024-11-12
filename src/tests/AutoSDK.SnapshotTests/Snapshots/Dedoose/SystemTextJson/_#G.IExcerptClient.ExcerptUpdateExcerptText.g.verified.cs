//HintName: G.IExcerptClient.ExcerptUpdateExcerptText.g.cs
#nullable enable

namespace G
{
    public partial interface IExcerptClient
    {
        /// <summary>
        /// UpdateExcerptText.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="projectIDL"></param>
        /// <param name="excerptId"></param>
        /// <param name="text"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Excerpt> ExcerptUpdateExcerptTextAsync(
            string? token = default,
            global::System.Guid? projectIDL = default,
            global::System.Guid? excerptId = default,
            string? text = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}