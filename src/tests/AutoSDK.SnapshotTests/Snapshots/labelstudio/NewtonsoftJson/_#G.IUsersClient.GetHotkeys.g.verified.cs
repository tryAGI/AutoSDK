//HintName: G.IUsersClient.GetHotkeys.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get user hotkeys<br/>
        /// Retrieve the custom hotkeys configuration for the current user.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Hotkeys> GetHotkeysAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}