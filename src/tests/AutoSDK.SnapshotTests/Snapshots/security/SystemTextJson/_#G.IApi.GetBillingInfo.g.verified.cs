//HintName: G.IApi.GetBillingInfo.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Gets the account billing info
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task GetBillingInfoAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}