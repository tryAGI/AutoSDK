//HintName: G.ITrainingClient.DeleteTest.g.cs
#nullable enable

namespace G
{
    public partial interface ITrainingClient
    {
        /// <summary>
        /// DeleteTest<br/>
        /// DeleteTest
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TrainingTest> DeleteTestAsync(
            global::G.DeleteTestRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// DeleteTest<br/>
        /// DeleteTest
        /// </summary>
        /// <param name="objTest"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TrainingTest> DeleteTestAsync(
            global::G.TrainingTest objTest,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}