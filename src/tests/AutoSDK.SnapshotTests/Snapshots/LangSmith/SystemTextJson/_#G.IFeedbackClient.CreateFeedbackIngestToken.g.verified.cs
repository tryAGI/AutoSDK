//HintName: G.IFeedbackClient.CreateFeedbackIngestToken.g.cs
#nullable enable

namespace G
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// Create Feedback Ingest Token<br/>
        /// Create a new feedback ingest token.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.FeedbackIngestTokenSchema, global::System.Collections.Generic.IList<global::G.FeedbackIngestTokenSchema>>> CreateFeedbackIngestTokenAsync(
            global::G.AnyOf<global::G.FeedbackIngestTokenCreateSchema, global::System.Collections.Generic.IList<global::G.FeedbackIngestTokenCreateSchema>> request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Feedback Ingest Token<br/>
        /// Create a new feedback ingest token.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.FeedbackIngestTokenSchema, global::System.Collections.Generic.IList<global::G.FeedbackIngestTokenSchema>>> CreateFeedbackIngestTokenAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}