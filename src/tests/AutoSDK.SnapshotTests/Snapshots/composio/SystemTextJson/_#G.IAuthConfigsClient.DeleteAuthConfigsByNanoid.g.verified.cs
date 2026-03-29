//HintName: G.IAuthConfigsClient.DeleteAuthConfigsByNanoid.g.cs
#nullable enable

namespace G
{
    public partial interface IAuthConfigsClient
    {
        /// <summary>
        /// Delete an authentication configuration<br/>
        /// Soft-deletes an authentication configuration by marking it as deleted in the database. This operation cannot be undone.
        /// </summary>
        /// <param name="nanoid">
        /// The unique identifier of the authentication configuration to delete
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteAuthConfigsByNanoidAsync(
            string nanoid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}