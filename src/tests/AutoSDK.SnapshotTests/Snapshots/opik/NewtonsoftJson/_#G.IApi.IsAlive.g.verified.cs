//HintName: G.IApi.IsAlive.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task IsAliveAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}