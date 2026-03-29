//HintName: G.IApi.DeleteTestCaseDefinition.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Delete a test case definition
        /// </summary>
        /// <param name="testCaseDefinitionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteTestCaseDefinitionAsync(
            string testCaseDefinitionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}