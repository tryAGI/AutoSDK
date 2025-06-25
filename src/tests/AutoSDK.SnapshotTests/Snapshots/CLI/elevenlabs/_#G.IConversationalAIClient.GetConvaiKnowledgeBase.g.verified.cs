//HintName: G.IConversationalAIClient.GetConvaiKnowledgeBase.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Get Knowledge Base List<br/>
        /// Get a list of available knowledge base documents
        /// </summary>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="pageSize">
        /// How many documents to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="search">
        /// If specified, the endpoint returns only such knowledge base documents whose names start with this string.
        /// </param>
        /// <param name="showOnlyOwnedDocuments">
        /// If set to true, the endpoint will return only documents owned by you (and not shared from somebody else).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="types">
        /// If present, the endpoint will return only documents of the given types.
        /// </param>
        /// <param name="useTypesense">
        /// If set to true, the endpoint will use typesense DB to search for the documents).<br/>
        /// Default Value: false
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetKnowledgeBaseListResponseModel> GetConvaiKnowledgeBaseAsync(
            string? cursor = default,
            int? pageSize = default,
            string? search = default,
            bool? showOnlyOwnedDocuments = default,
            global::System.Collections.Generic.IList<global::G.KnowledgeBaseDocumentType>? types = default,
            bool? useTypesense = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}