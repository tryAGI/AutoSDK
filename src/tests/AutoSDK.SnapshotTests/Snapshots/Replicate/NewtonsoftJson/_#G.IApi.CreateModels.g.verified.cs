//HintName: G.IApi.CreateModels.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Create a model<br/>
        /// Create a model.<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s -X POST \<br/>
        ///   -H "Authorization: Bearer &lt;paste-your-token-here&gt;" \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -d '{"owner": "alice", "name": "my-model", "description": "An example model", "visibility": "public", "hardware": "cpu"}' \<br/>
        ///   https://api.replicate.com/v1/models<br/>
        /// ```<br/>
        /// The response will be a model object in the following format:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "url": "https://replicate.com/alice/my-model",<br/>
        ///   "owner": "alice",<br/>
        ///   "name": "my-model",<br/>
        ///   "description": "An example model",<br/>
        ///   "visibility": "public",<br/>
        ///   "github_url": null,<br/>
        ///   "paper_url": null,<br/>
        ///   "license_url": null,<br/>
        ///   "run_count": 0,<br/>
        ///   "cover_image_url": null,<br/>
        ///   "default_example": null,<br/>
        ///   "latest_version": null,<br/>
        /// }<br/>
        /// ```<br/>
        /// Note that there is a limit of 1,000 models per account. For most purposes, we recommend using a single model and pushing new [versions](https://replicate.com/docs/how-does-replicate-work#versions) of the model as you make changes to it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateModelsAsync(
            global::G.ModelsCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a model<br/>
        /// Create a model.<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s -X POST \<br/>
        ///   -H "Authorization: Bearer &lt;paste-your-token-here&gt;" \<br/>
        ///   -H 'Content-Type: application/json' \<br/>
        ///   -d '{"owner": "alice", "name": "my-model", "description": "An example model", "visibility": "public", "hardware": "cpu"}' \<br/>
        ///   https://api.replicate.com/v1/models<br/>
        /// ```<br/>
        /// The response will be a model object in the following format:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "url": "https://replicate.com/alice/my-model",<br/>
        ///   "owner": "alice",<br/>
        ///   "name": "my-model",<br/>
        ///   "description": "An example model",<br/>
        ///   "visibility": "public",<br/>
        ///   "github_url": null,<br/>
        ///   "paper_url": null,<br/>
        ///   "license_url": null,<br/>
        ///   "run_count": 0,<br/>
        ///   "cover_image_url": null,<br/>
        ///   "default_example": null,<br/>
        ///   "latest_version": null,<br/>
        /// }<br/>
        /// ```<br/>
        /// Note that there is a limit of 1,000 models per account. For most purposes, we recommend using a single model and pushing new [versions](https://replicate.com/docs/how-does-replicate-work#versions) of the model as you make changes to it.
        /// </summary>
        /// <param name="coverImageUrl">
        /// A URL for the model's cover image. This should be an image file.
        /// </param>
        /// <param name="description">
        /// A description of the model.
        /// </param>
        /// <param name="githubUrl">
        /// A URL for the model's source code on GitHub.
        /// </param>
        /// <param name="hardware">
        /// The SKU for the hardware used to run the model. Possible values can be retrieved from the `hardware.list` endpoint.
        /// </param>
        /// <param name="licenseUrl">
        /// A URL for the model's license.
        /// </param>
        /// <param name="name">
        /// The name of the model. This must be unique among all models owned by the user or organization.
        /// </param>
        /// <param name="owner">
        /// The name of the user or organization that will own the model. This must be the same as the user or organization that is making the API request. In other words, the API token used in the request must belong to this user or organization.
        /// </param>
        /// <param name="paperUrl">
        /// A URL for the model's paper.
        /// </param>
        /// <param name="visibility">
        /// Whether the model should be public or private. A public model can be viewed and run by anyone, whereas a private model can be viewed and run only by the user or organization members that own the model.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateModelsAsync(
            string hardware,
            string name,
            string owner,
            global::G.ModelsCreateRequestVisibility visibility,
            string? coverImageUrl = default,
            string? description = default,
            string? githubUrl = default,
            string? licenseUrl = default,
            string? paperUrl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}