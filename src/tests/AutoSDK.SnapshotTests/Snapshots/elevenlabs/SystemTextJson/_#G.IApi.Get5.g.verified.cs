//HintName: G.IApi.Get5.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Get Test Invocation<br/>
        /// Gets a test invocation by ID.
        /// </summary>
        /// <param name="testInvocationId">
        /// The id of a test invocation. This is returned when tests are run.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetTestSuiteInvocationResponseModel> Get5Async(
            string testInvocationId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}