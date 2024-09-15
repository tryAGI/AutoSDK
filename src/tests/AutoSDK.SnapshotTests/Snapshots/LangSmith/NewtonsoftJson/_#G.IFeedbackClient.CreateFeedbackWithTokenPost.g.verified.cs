//HintName: G.IFeedbackClient.CreateFeedbackWithTokenPost.g.cs
#nullable enable

namespace G
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// Create Feedback With Token Post<br/>
        /// Create a new feedback with a token.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateFeedbackWithTokenPostApiV1FeedbackTokensTokenPostResponse> CreateFeedbackWithTokenPostAsync(
            global::System.Guid token,
            global::G.FeedbackCreateWithTokenExtendedSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Feedback With Token Post<br/>
        /// Create a new feedback with a token.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="score"></param>
        /// <param name="value"></param>
        /// <param name="comment"></param>
        /// <param name="correction"></param>
        /// <param name="metadata"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateFeedbackWithTokenPostApiV1FeedbackTokensTokenPostResponse> CreateFeedbackWithTokenPostAsync(
            global::System.Guid token,
            global::G.AnyOf<double?, int?, bool?, object>? score = default,
            global::G.AnyOf<double?, int?, bool?, string, object>? value = default,
            global::G.AnyOf<string, object>? comment = default,
            global::G.AnyOf<global::G.FeedbackCreateWithTokenExtendedSchemaCorrection, string, object>? correction = default,
            global::G.AnyOf<global::G.FeedbackCreateWithTokenExtendedSchemaMetadata, object>? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}