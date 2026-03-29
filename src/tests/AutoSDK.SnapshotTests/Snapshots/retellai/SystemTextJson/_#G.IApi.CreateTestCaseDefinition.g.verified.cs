//HintName: G.IApi.CreateTestCaseDefinition.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Create a new test case definition
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TestCaseDefinition> CreateTestCaseDefinitionAsync(

            global::G.AllOf<global::G.TestCaseDefinitionInput, object> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new test case definition
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TestCaseDefinition> CreateTestCaseDefinitionAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}