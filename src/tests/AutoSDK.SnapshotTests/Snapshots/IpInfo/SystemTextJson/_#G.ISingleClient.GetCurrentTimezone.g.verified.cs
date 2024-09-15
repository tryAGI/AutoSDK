//HintName: G.ISingleClient.GetCurrentTimezone.g.cs
#nullable enable

namespace G
{
    public partial interface ISingleClient
    {
        /// <summary>
        /// Returns the current timezone.<br/>
        /// Returns the current timezone.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetCurrentTimezoneAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}