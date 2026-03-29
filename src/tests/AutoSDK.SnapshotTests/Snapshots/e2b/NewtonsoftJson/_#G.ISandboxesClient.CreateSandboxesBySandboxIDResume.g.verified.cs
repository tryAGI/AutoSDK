//HintName: G.ISandboxesClient.CreateSandboxesBySandboxIDResume.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Resume the sandbox
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.Sandbox> CreateSandboxesBySandboxIDResumeAsync(
            string sandboxID,

            global::G.ResumedSandbox request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Resume the sandbox
        /// </summary>
        /// <param name="sandboxID"></param>
        /// <param name="timeout">
        /// Time to live for the sandbox in seconds.<br/>
        /// Default Value: 15
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.Sandbox> CreateSandboxesBySandboxIDResumeAsync(
            string sandboxID,
            int? timeout = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}