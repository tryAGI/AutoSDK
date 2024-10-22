//HintName: G.OrgsClient.OrgsCreateOrUpdateCustomProperty.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        partial void PrepareOrgsCreateOrUpdateCustomPropertyArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref string customPropertyName,
            global::G.OrgsCreateOrUpdateCustomPropertyRequest request);
        partial void PrepareOrgsCreateOrUpdateCustomPropertyRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            string customPropertyName,
            global::G.OrgsCreateOrUpdateCustomPropertyRequest request);
        partial void ProcessOrgsCreateOrUpdateCustomPropertyResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOrgsCreateOrUpdateCustomPropertyResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create or update a custom property for an organization<br/>
        /// Creates a new or updates an existing custom property that is defined for an organization.<br/>
        /// To use this endpoint, the authenticated user must be one of:<br/>
        /// - An administrator for the organization.<br/>
        /// - A user, or a user on a team, with the fine-grained permission of `custom_properties_org_definitions_manager` in the organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="customPropertyName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CustomProperty> OrgsCreateOrUpdateCustomPropertyAsync(
            string org,
            string customPropertyName,
            global::G.OrgsCreateOrUpdateCustomPropertyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareOrgsCreateOrUpdateCustomPropertyArguments(
                httpClient: HttpClient,
                org: ref org,
                customPropertyName: ref customPropertyName,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/properties/schema/{customPropertyName}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareOrgsCreateOrUpdateCustomPropertyRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                customPropertyName: customPropertyName,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessOrgsCreateOrUpdateCustomPropertyResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessOrgsCreateOrUpdateCustomPropertyResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::G.CustomProperty.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create or update a custom property for an organization<br/>
        /// Creates a new or updates an existing custom property that is defined for an organization.<br/>
        /// To use this endpoint, the authenticated user must be one of:<br/>
        /// - An administrator for the organization.<br/>
        /// - A user, or a user on a team, with the fine-grained permission of `custom_properties_org_definitions_manager` in the organization.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="customPropertyName"></param>
        /// <param name="valueType">
        /// The type of the value for the property<br/>
        /// Example: single_select
        /// </param>
        /// <param name="required">
        /// Whether the property is required.
        /// </param>
        /// <param name="defaultValue">
        /// Default value of the property
        /// </param>
        /// <param name="description">
        /// Short description of the property
        /// </param>
        /// <param name="allowedValues">
        /// An ordered list of the allowed values of the property.<br/>
        /// The property can have up to 200 allowed values.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CustomProperty> OrgsCreateOrUpdateCustomPropertyAsync(
            string org,
            string customPropertyName,
            global::G.OrgsCreateOrUpdateCustomPropertyRequestValueType valueType,
            bool? required = default,
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>>? defaultValue = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? allowedValues = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.OrgsCreateOrUpdateCustomPropertyRequest
            {
                ValueType = valueType,
                Required = required,
                DefaultValue = defaultValue,
                Description = description,
                AllowedValues = allowedValues,
            };

            return await OrgsCreateOrUpdateCustomPropertyAsync(
                org: org,
                customPropertyName: customPropertyName,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}