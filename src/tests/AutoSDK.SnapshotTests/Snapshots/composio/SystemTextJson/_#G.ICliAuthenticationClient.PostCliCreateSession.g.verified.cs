//HintName: G.ICliAuthenticationClient.PostCliCreateSession.g.cs
#nullable enable

namespace G
{
    public partial interface ICliAuthenticationClient
    {
        /// <summary>
        /// Create a new CLI session with auth code<br/>
        /// Generates a new CLI session with a random 6-character code. This endpoint is the first step in the CLI authentication flow, creating a session that can later be linked to a user account. The generated code is displayed to the user in the CLI and should be entered in the web interface to complete authentication. Optionally accepts a scope ('project' or 'user') and a source string.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostCliCreateSessionResponse> PostCliCreateSessionAsync(

            global::G.PostCliCreateSessionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new CLI session with auth code<br/>
        /// Generates a new CLI session with a random 6-character code. This endpoint is the first step in the CLI authentication flow, creating a session that can later be linked to a user account. The generated code is displayed to the user in the CLI and should be entered in the web interface to complete authentication. Optionally accepts a scope ('project' or 'user') and a source string.
        /// </summary>
        /// <param name="scope">
        /// Key scope. 'project' (default) returns a project-level API key; 'user' returns a user-level API key valid across projects.<br/>
        /// Default Value: project
        /// </param>
        /// <param name="source">
        /// Free-form string describing the source, e.g. 'Johns MacBook (darwin, v1.2.3)'
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostCliCreateSessionResponse> PostCliCreateSessionAsync(
            global::G.PostCliCreateSessionRequestScope? scope = default,
            string? source = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}