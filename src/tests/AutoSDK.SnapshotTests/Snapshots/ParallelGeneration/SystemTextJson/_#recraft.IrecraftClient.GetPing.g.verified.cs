//HintName: recraft.IrecraftClient.GetPing.g.cs
#nullable enable

namespace recraft
{
    public partial interface IrecraftClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::recraft.ApiException"></exception>
        global::System.Threading.Tasks.Task GetPingAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}