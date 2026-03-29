//HintName: G.IFeedbackDefinitionsClient.FindFeedbackDefinitions.g.cs
#nullable enable

namespace G
{
    public partial interface IFeedbackDefinitionsClient
    {
        /// <summary>
        /// Find Feedback definitions<br/>
        /// Find Feedback definitions
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="name">
        /// Filter feedback definitions by name (partial match, case insensitive)
        /// </param>
        /// <param name="type"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedbackDefinitionPagePublic> FindFeedbackDefinitionsAsync(
            int? page = default,
            int? size = default,
            string? name = default,
            global::G.FindFeedbackDefinitionsType? type = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}