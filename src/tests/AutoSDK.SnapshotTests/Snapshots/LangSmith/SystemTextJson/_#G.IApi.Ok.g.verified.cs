//HintName: G.IApi.Ok.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Ok
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.OkApiV1OkGetResponse> OkAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}