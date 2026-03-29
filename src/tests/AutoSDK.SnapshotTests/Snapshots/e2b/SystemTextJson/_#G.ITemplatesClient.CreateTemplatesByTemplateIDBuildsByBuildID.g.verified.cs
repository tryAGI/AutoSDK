//HintName: G.ITemplatesClient.CreateTemplatesByTemplateIDBuildsByBuildID.g.cs
#nullable enable

namespace G
{
    public partial interface ITemplatesClient
    {
        /// <summary>
        /// Start the build
        /// </summary>
        /// <param name="templateID"></param>
        /// <param name="buildID"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task CreateTemplatesByTemplateIDBuildsByBuildIDAsync(
            string templateID,
            string buildID,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}