//HintName: recraft.IStyleClient.ListStyles.g.cs
#nullable enable

namespace recraft
{
    public partial interface IStyleClient
    {
        /// <summary>
        /// List Styles
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::recraft.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::recraft.ListStylesResponse> ListStylesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}