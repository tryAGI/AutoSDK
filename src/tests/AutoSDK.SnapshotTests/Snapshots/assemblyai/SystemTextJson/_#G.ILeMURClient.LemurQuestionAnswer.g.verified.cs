//HintName: G.ILeMURClient.LemurQuestionAnswer.g.cs
#nullable enable

namespace G
{
    public partial interface ILeMURClient
    {
        /// <summary>
        /// Ask questions using LeMUR<br/>
        /// Question &amp; Answer allows you to ask free-form questions about a single transcript or a group of transcripts.<br/>
        /// The questions can be any whose answers you find useful, such as judging whether a caller is likely to become a customer or whether all items on a meeting's agenda were covered.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LemurQuestionAnswerResponse> LemurQuestionAnswerAsync(
            global::G.LemurQuestionAnswerParams request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Ask questions using LeMUR<br/>
        /// Question &amp; Answer allows you to ask free-form questions about a single transcript or a group of transcripts.<br/>
        /// The questions can be any whose answers you find useful, such as judging whether a caller is likely to become a customer or whether all items on a meeting's agenda were covered.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.LemurQuestionAnswerResponse> LemurQuestionAnswerAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}