//HintName: G.ILabelsClient.Create.g.cs
#nullable enable

namespace G
{
    public partial interface ILabelsClient
    {
        /// <summary>
        /// Create label links<br/>
        /// Create label links to link new custom labels to your project labeling configuration.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LabelLink> CreateAsync(

            global::G.LabelLinkRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create label links<br/>
        /// Create label links to link new custom labels to your project labeling configuration.
        /// </summary>
        /// <param name="fromName">
        /// Tag name
        /// </param>
        /// <param name="label"></param>
        /// <param name="project"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.LabelLink> CreateAsync(
            string fromName,
            int label,
            int project,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}