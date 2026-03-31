//HintName: G.ILemurClient.Summary.g.cs
#nullable enable

namespace G
{
    public partial interface ILemurClient
    {
        /// <summary>
        /// Summarize a transcript using LeMUR<br/>
        /// Custom Summary allows you to distill a piece of audio into a few impactful sentences.<br/>
        /// You can give the model context to obtain more targeted results while outputting the results in a variety of formats described in human language.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LemurSummaryResponse> SummaryAsync(

            global::G.LemurSummaryParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Summarize a transcript using LeMUR<br/>
        /// Custom Summary allows you to distill a piece of audio into a few impactful sentences.<br/>
        /// You can give the model context to obtain more targeted results while outputting the results in a variety of formats described in human language.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.LemurSummaryResponse> SummaryAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}