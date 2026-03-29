//HintName: G.IPromptsClient.ApiPromptsUpdate.g.cs
#nullable enable

namespace G
{
    public partial interface IPromptsClient
    {
        /// <summary>
        /// ✨ Put prompt<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Overwrite a specific prompt by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ModelInterface> ApiPromptsUpdateAsync(
            string id,

            global::G.ModelInterfaceRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// ✨ Put prompt<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Overwrite a specific prompt by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="associatedProjects"></param>
        /// <param name="createdBy">
        /// User who created Dataset
        /// </param>
        /// <param name="description">
        /// Model description
        /// </param>
        /// <param name="inputFields"></param>
        /// <param name="organization"></param>
        /// <param name="outputClasses"></param>
        /// <param name="skillName">
        /// Default Value: TextClassification
        /// </param>
        /// <param name="title">
        /// Model name
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ModelInterface> ApiPromptsUpdateAsync(
            string id,
            string title,
            global::System.Collections.Generic.IList<int>? associatedProjects = default,
            global::G.UserSimpleRequest? createdBy = default,
            string? description = default,
            object? inputFields = default,
            int? organization = default,
            object? outputClasses = default,
            global::G.SkillNameEnum? skillName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}