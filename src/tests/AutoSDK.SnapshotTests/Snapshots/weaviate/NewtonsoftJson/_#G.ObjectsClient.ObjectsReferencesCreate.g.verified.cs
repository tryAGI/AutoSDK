//HintName: G.ObjectsClient.ObjectsReferencesCreate.g.cs

#nullable enable

namespace G
{
    public partial class ObjectsClient
    {
        partial void PrepareObjectsReferencesCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid id,
            ref string propertyName,
            ref string? tenant,
            global::G.SingleRef request);
        partial void PrepareObjectsReferencesCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid id,
            string propertyName,
            string? tenant,
            global::G.SingleRef request);
        partial void ProcessObjectsReferencesCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Add a cross-reference.<br/>
        /// Add a cross-reference.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="propertyName"></param>
        /// <param name="tenant"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task ObjectsReferencesCreateAsync(
            global::System.Guid id,
            string propertyName,
            global::G.SingleRef request,
            string? tenant = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareObjectsReferencesCreateArguments(
                httpClient: HttpClient,
                id: ref id,
                propertyName: ref propertyName,
                tenant: ref tenant,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/objects/{id}/references/{propertyName}",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("tenant", tenant) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareObjectsReferencesCreateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                id: id,
                propertyName: propertyName,
                tenant: tenant,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessObjectsReferencesCreateResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::G.ApiException(
                    message: __response.ReasonPhrase ?? string.Empty,
                    innerException: __ex,
                    statusCode: __response.StatusCode)
                {
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
        }

        /// <summary>
        /// Add a cross-reference.<br/>
        /// Add a cross-reference.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="propertyName"></param>
        /// <param name="tenant"></param>
        /// <param name="class">
        /// If using a concept reference (rather than a direct reference), specify the desired class name here
        /// </param>
        /// <param name="schema">
        /// Names and values of an individual property. A returned response may also contain additional metadata, such as from classification or feature projection.
        /// </param>
        /// <param name="beacon">
        /// If using a direct reference, specify the URI to point to the cross-ref here. Should be in the form of weaviate://localhost/&lt;uuid&gt; for the example of a local cross-ref to an object
        /// </param>
        /// <param name="href">
        /// If using a direct reference, this read-only fields provides a link to the referenced resource. If 'origin' is globally configured, an absolute URI is shown - a relative URI otherwise.
        /// </param>
        /// <param name="classification">
        /// This meta field contains additional info about the classified reference property
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task ObjectsReferencesCreateAsync(
            global::System.Guid id,
            string propertyName,
            string? tenant = default,
            string? @class = default,
            object? schema = default,
            string? beacon = default,
            string? href = default,
            global::G.ReferenceMetaClassification? classification = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.SingleRef
            {
                Class = @class,
                Schema = schema,
                Beacon = beacon,
                Href = href,
                Classification = classification,
            };

            await ObjectsReferencesCreateAsync(
                id: id,
                propertyName: propertyName,
                tenant: tenant,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}