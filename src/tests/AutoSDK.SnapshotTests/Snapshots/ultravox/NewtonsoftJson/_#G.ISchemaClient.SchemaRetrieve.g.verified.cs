//HintName: G.ISchemaClient.SchemaRetrieve.g.cs
#nullable enable

namespace G
{
    public partial interface ISchemaClient
    {
        /// <summary>
        /// OpenApi3 schema for this API. Format can be selected via content negotiation.<br/>
        /// - YAML: application/vnd.oai.openapi<br/>
        /// - JSON: application/vnd.oai.openapi+json
        /// </summary>
        /// <param name="format"></param>
        /// <param name="lang"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> SchemaRetrieveAsync(
            global::G.SchemaRetrieveFormat? format = default,
            global::G.SchemaRetrieveLang? lang = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}