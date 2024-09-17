//HintName: G.IFeedbackClient.ReadFeedbacks.g.cs
#nullable enable

namespace G
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// Read Feedbacks<br/>
        /// List all Feedback by query params.
        /// </summary>
        /// <param name="run"></param>
        /// <param name="key"></param>
        /// <param name="session"></param>
        /// <param name="source"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="user"></param>
        /// <param name="hasComment"></param>
        /// <param name="hasScore"></param>
        /// <param name="level"></param>
        /// <param name="maxCreatedAt"></param>
        /// <param name="minCreatedAt"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.FeedbackSchema>> ReadFeedbacksAsync(
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? run = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, object>? key = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? session = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.SourceType>, object>? source = default,
            int? limit = 100,
            int? offset = 0,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? user = default,
            global::G.AnyOf<bool?, object>? hasComment = default,
            global::G.AnyOf<bool?, object>? hasScore = default,
            global::G.AnyOf<global::G.FeedbackLevel?, object>? level = default,
            global::G.AnyOf<global::System.DateTime?, object>? maxCreatedAt = default,
            global::G.AnyOf<global::System.DateTime?, object>? minCreatedAt = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}