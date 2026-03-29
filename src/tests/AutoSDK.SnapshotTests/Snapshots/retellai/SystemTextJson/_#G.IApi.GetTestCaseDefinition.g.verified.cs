//HintName: G.IApi.GetTestCaseDefinition.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Get a test case definition by ID
        /// </summary>
        /// <param name="testCaseDefinitionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TestCaseDefinition> GetTestCaseDefinitionAsync(
            string testCaseDefinitionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}