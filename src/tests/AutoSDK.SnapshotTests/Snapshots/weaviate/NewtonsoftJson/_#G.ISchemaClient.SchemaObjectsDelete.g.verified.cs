//HintName: G.ISchemaClient.SchemaObjectsDelete.g.cs
#nullable enable

namespace G
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// Remove a collection (and its data).<br/>
        /// Remove a collection from the schema. This will also delete all the objects in the collection.
        /// </summary>
        /// <param name="className"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task SchemaObjectsDeleteAsync(
            string className,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}