//HintName: G.IStripeClient.GetAutoTopoffSettings.g.cs
#nullable enable

namespace G
{
    public partial interface IStripeClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoTopoffSettings> GetAutoTopoffSettingsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}