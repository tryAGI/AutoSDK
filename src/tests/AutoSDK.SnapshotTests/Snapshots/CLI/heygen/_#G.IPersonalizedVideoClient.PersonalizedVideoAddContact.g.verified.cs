//HintName: G.IPersonalizedVideoClient.PersonalizedVideoAddContact.g.cs
#nullable enable

namespace G
{
    public partial interface IPersonalizedVideoClient
    {
        /// <summary>
        /// personalized_video/add_contact<br/>
        /// personalized_video/add_contact
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task PersonalizedVideoAddContactAsync(
            global::G.PersonalizedVideoAddContactRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// personalized_video/add_contact<br/>
        /// personalized_video/add_contact
        /// </summary>
        /// <param name="projectId">
        /// Example: &lt;project_id&gt;
        /// </param>
        /// <param name="variablesList">
        /// Example: []
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PersonalizedVideoAddContactAsync(
            string? projectId = default,
            global::System.Collections.Generic.IList<global::G.PersonalizedVideoAddContactRequestVariablesListItem>? variablesList = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}