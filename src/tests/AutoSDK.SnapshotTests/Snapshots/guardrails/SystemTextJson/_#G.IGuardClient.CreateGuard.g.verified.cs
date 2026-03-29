//HintName: G.IGuardClient.CreateGuard.g.cs
#nullable enable

namespace G
{
    public partial interface IGuardClient
    {
        /// <summary>
        /// Creates a Guard
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Guard> CreateGuardAsync(

            global::G.Guard request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a Guard
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the Guard.
        /// </param>
        /// <param name="name">
        /// The name for the Guard.
        /// </param>
        /// <param name="description">
        /// A description that concisely states the expected behaviour or purpose of the Guard.
        /// </param>
        /// <param name="validators"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Guard> CreateGuardAsync(
            string id,
            string name,
            string? description = default,
            global::System.Collections.Generic.IList<global::G.ValidatorReference>? validators = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}