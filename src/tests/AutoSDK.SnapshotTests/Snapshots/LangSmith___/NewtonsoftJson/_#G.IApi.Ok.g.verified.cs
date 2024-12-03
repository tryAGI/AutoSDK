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
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> OkAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}