//HintName: G.ICallsClient.AnalyzeCall.g.cs
#nullable enable

namespace G
{
    public partial interface ICallsClient
    {
        /// <summary>
        /// Analyze Call with AI<br/>
        /// Use AI to analyze a completed call's transcript and extract structured answers.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnalyzeCallResponse> AnalyzeCallAsync(
            string callId,

            global::G.AnalyzeCallRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Analyze Call with AI<br/>
        /// Use AI to analyze a completed call's transcript and extract structured answers.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="goal">
        /// Overall purpose of the call, providing context for AI analysis
        /// </param>
        /// <param name="questions">
        /// Array of question-answer pairs. Each entry is [question_text, expected_type].
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnalyzeCallResponse> AnalyzeCallAsync(
            string callId,
            string goal,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>> questions,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}