//HintName: G.IPublicClient.ReadSharedFeedbacks.g.cs
#nullable enable

namespace G
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// Read Shared Feedbacks
        /// </summary>
        /// <param name="shareToken"></param>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.FeedbackSchema>> ReadSharedFeedbacksAsync(
            global::System.Guid shareToken,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? run = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, object>? key = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? session = default,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.SourceType>, object>? source = default,
            int limit = 100,
            int offset = 0,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? user = default,
            global::G.AnyOf<bool?, object>? hasComment = default,
            global::G.AnyOf<bool?, object>? hasScore = default,
            global::G.AnyOf<global::G.FeedbackLevel?, object>? level = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}