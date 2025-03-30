//HintName: G.IStudioClient.CreateStudioProjectsByProjectIdContent.g.cs
#nullable enable

namespace G
{
    public partial interface IStudioClient
    {
        /// <summary>
        /// Update Studio Project Content<br/>
        /// Updates Studio project content.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the Studio project.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EditProjectResponseModel> CreateStudioProjectsByProjectIdContentAsync(
            string projectId,
            global::G.BodyUpdateStudioProjectContentV1StudioProjectsProjectIdContentPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Studio Project Content<br/>
        /// Updates Studio project content.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the Studio project.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="fromUrl">
        /// An optional URL from which we will extract content to initialize the Studio project. If this is set, 'from_url' must be null. If neither 'from_url' or 'from_document' are provided we will initialize the Studio project as blank.<br/>
        /// Example: https://blog.elevenlabs.io/the_first_ai_that_can_laugh/
        /// </param>
        /// <param name="fromDocument">
        /// An optional .epub, .pdf, .txt or similar file can be provided. If provided, we will initialize the Studio project with its content. If this is set, 'from_url' must be null.  If neither 'from_url' or 'from_document' are provided we will initialize the Studio project as blank.
        /// </param>
        /// <param name="fromDocumentname">
        /// An optional .epub, .pdf, .txt or similar file can be provided. If provided, we will initialize the Studio project with its content. If this is set, 'from_url' must be null.  If neither 'from_url' or 'from_document' are provided we will initialize the Studio project as blank.
        /// </param>
        /// <param name="autoConvert">
        /// Whether to auto convert the Studio project to audio or not.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EditProjectResponseModel> CreateStudioProjectsByProjectIdContentAsync(
            string projectId,
            string? xiApiKey = default,
            string? fromUrl = default,
            byte[]? fromDocument = default,
            string? fromDocumentname = default,
            bool? autoConvert = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}