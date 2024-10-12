//HintName: G.IApi.V1Answer.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Answer
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1AnswerAsync(
            global::G.AnswerBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Answer
        /// </summary>
        /// <param name="context"></param>
        /// <param name="question"></param>
        /// <param name="answerLength">
        /// An enumeration.
        /// </param>
        /// <param name="mode">
        /// An enumeration.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1AnswerAsync(
            string context,
            string question,
            global::G.AnswerLength? answerLength = default,
            global::G.Mode? mode = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}