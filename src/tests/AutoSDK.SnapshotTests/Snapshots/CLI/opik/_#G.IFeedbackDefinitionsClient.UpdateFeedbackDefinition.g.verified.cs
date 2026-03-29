//HintName: G.IFeedbackDefinitionsClient.UpdateFeedbackDefinition.g.cs
#nullable enable

namespace G
{
    public partial interface IFeedbackDefinitionsClient
    {
        /// <summary>
        /// Update feedback definition by id<br/>
        /// Update feedback definition by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateFeedbackDefinitionAsync(
            global::System.Guid id,

            global::G.FeedbackUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update feedback definition by id<br/>
        /// Update feedback definition by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="description">
        /// Optional description for the feedback definition<br/>
        /// Example: This feedback definition is used to rate response quality
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateFeedbackDefinitionAsync(
            global::System.Guid id,
            string name,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}