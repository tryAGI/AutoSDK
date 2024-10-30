//HintName: G.IModelClient.ModelPublicServiceCreateNamespaceModel.g.cs
#nullable enable

namespace G
{
    public partial interface IModelClient
    {
        /// <summary>
        /// Create a new model<br/>
        /// Creates a new model under the parenthood of a namespace. This is an<br/>
        /// asynchronous endpoint, i.e., the server will not wait for the model to be<br/>
        /// created in order to respond. Instead, it will return a response with the<br/>
        /// necessary information to access the result and status of the creation<br/>
        /// operation.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateNamespaceModelResponse> ModelPublicServiceCreateNamespaceModelAsync(
            string namespaceId,
            global::G.Model request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a new model<br/>
        /// Creates a new model under the parenthood of a namespace. This is an<br/>
        /// asynchronous endpoint, i.e., the server will not wait for the model to be<br/>
        /// created in order to respond. Instead, it will return a response with the<br/>
        /// necessary information to access the result and status of the creation<br/>
        /// operation.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="id">
        /// Model resource ID (used in `name` as the last segment). This conforms to<br/>
        /// RFC-1034, which restricts to letters, numbers, and hyphen, with the first<br/>
        /// character a letter, the last a letter or a number, and a 63 character<br/>
        /// maximum.
        /// </param>
        /// <param name="description">
        /// Model description.
        /// </param>
        /// <param name="modelDefinition">
        /// The model definition that has been used to import the model.
        /// </param>
        /// <param name="configuration">
        /// Model configuration. This field is validated against the model<br/>
        /// specification in the model definition (i.e. the `model_spec` field in the<br/>
        /// model definition).
        /// </param>
        /// <param name="task">
        /// Model task.
        /// </param>
        /// <param name="visibility">
        /// Model visibility.
        /// </param>
        /// <param name="region">
        /// Region of choice for the particular provider to host the model.
        /// </param>
        /// <param name="hardware">
        /// Hardware of choice to serve the model.
        /// </param>
        /// <param name="readme">
        /// README holds the model documentation.
        /// </param>
        /// <param name="sourceUrl">
        /// A link to the source code of the model (e.g. to a GitHub repository).
        /// </param>
        /// <param name="documentationUrl">
        /// A link to any extra information.
        /// </param>
        /// <param name="license">
        /// License under which the model is distributed.
        /// </param>
        /// <param name="profileImage">
        /// Model profile image in base64 format.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateNamespaceModelResponse> ModelPublicServiceCreateNamespaceModelAsync(
            string namespaceId,
            string id,
            string modelDefinition,
            object configuration,
            global::G.AITask task,
            global::G.ModelVisibility visibility,
            string region,
            string hardware,
            string? description = default,
            string? readme = default,
            string? sourceUrl = default,
            string? documentationUrl = default,
            string? license = default,
            string? profileImage = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}