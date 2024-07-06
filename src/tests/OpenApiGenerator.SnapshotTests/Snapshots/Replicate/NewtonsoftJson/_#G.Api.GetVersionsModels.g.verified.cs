//HintName: G.Api.GetVersionsModels.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        /// <summary>
        /// Get a model version<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s \<br/>
        ///   -H "Authorization: Bearer &lt;paste-your-token-here&gt;" \<br/>
        ///   https://api.replicate.com/v1/models/replicate/hello-world/versions/5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa<br/>
        /// ```<br/>
        /// The response will be the version object:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "id": "5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa",<br/>
        ///   "created_at": "2022-04-26T19:29:04.418669Z",<br/>
        ///   "cog_version": "0.3.0",<br/>
        ///   "openapi_schema": {...}<br/>
        /// }<br/>
        /// ```<br/>
        /// Every model describes its inputs and outputs with [OpenAPI Schema Objects](https://spec.openapis.org/oas/latest.html#schemaObject) in the `openapi_schema` property.<br/>
        /// The `openapi_schema.components.schemas.Input` property for the [replicate/hello-world](https://replicate.com/replicate/hello-world) model looks like this:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "object",<br/>
        ///   "title": "Input",<br/>
        ///   "required": [<br/>
        ///     "text"<br/>
        ///   ],<br/>
        ///   "properties": {<br/>
        ///     "text": {<br/>
        ///       "x-order": 0,<br/>
        ///       "type": "string",<br/>
        ///       "title": "Text",<br/>
        ///       "description": "Text to prefix with 'hello '"<br/>
        ///     }<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// The `openapi_schema.components.schemas.Output` property for the [replicate/hello-world](https://replicate.com/replicate/hello-world) model looks like this:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "type": "string",<br/>
        ///   "title": "Output"<br/>
        /// }<br/>
        /// ```<br/>
        /// For more details, see the docs on [Cog's supported input and output types](https://github.com/replicate/cog/blob/75b7802219e7cd4cee845e34c4c22139558615d4/docs/python.md#input-and-output-types)
        /// </summary>
        /// <param name="modelOwner"></param>
        /// <param name="modelName"></param>
        /// <param name="versionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task GetVersionsModelsAsync(
            string modelOwner,
            string modelName,
            string versionId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/models/{modelOwner}/{modelName}/versions/{versionId}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }
    }
}