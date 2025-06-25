//HintName: G.IApi.ListVersionsModels.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// List model versions<br/>
        /// Example cURL request:<br/>
        /// ```console<br/>
        /// curl -s \<br/>
        ///   -H "Authorization: Bearer $REPLICATE_API_TOKEN" \<br/>
        ///   https://api.replicate.com/v1/models/replicate/hello-world/versions<br/>
        /// ```<br/>
        /// The response will be a JSON array of model version objects, sorted with the most recent version first:<br/>
        /// ```json<br/>
        /// {<br/>
        ///   "next": null,<br/>
        ///   "previous": null,<br/>
        ///   "results": [<br/>
        ///     {<br/>
        ///       "id": "5c7d5dc6dd8bf75c1acaa8565735e7986bc5b66206b55cca93cb72c9bf15ccaa",<br/>
        ///       "created_at": "2022-04-26T19:29:04.418669Z",<br/>
        ///       "cog_version": "0.3.0",<br/>
        ///       "openapi_schema": {...}<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }<br/>
        /// ```
        /// </summary>
        /// <param name="modelOwner"></param>
        /// <param name="modelName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ListVersionsModelsAsync(
            string modelOwner,
            string modelName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}