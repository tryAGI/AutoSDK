//HintName: G.OrgsClient.OrgsCreateOrUpdateCustomProperty.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        /// <summary>
        /// Create or update a custom property for an organization
        /// </summary>
        /// <param name="org"></param>
        /// <param name="customPropertyName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<OrgCustomProperty> OrgsCreateOrUpdateCustomPropertyAsync(
            string org,
            string customPropertyName,
            OrgsCreateOrUpdateCustomPropertyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/orgs/{org}/properties/schema/{customPropertyName}", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<OrgCustomProperty?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create or update a custom property for an organization
        /// </summary>
        /// <param name="org"></param>
        /// <param name="customPropertyName"></param>
        /// <param name="valueType"></param>
        /// <param name="required"></param>
        /// <param name="defaultValue"></param>
        /// <param name="description"></param>
        /// <param name="allowedValues"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<OrgCustomProperty> OrgsCreateOrUpdateCustomPropertyAsync(
            string org,
            string customPropertyName,
            OrgsCreateOrUpdateCustomPropertyRequestValueType valueType,
            bool required = default,
            global::System.OneOf<string?, global::System.Collections.Generic.IList<string?>?>? defaultValue = default,
            string? description = default,
            global::System.Collections.Generic.IList<string?>? allowedValues = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new OrgsCreateOrUpdateCustomPropertyRequest
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
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}