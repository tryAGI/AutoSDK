//HintName: G.OrganizationsClient.Update3.g.cs

#nullable enable

namespace G
{
    public partial class OrganizationsClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_Update3SecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_Update3SecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_Update3SecurityRequirement0,
            };
        partial void PrepareUpdate3Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int id,
            global::G.PatchedOrganizationMemberCreateUpdateRequest request);
        partial void PrepareUpdate3Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int id,
            global::G.PatchedOrganizationMemberCreateUpdateRequest request);
        partial void ProcessUpdate3Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdate3ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// ✨ Update organization member/role<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Update organization membership or role for a specific user ID.<br/>
        /// **User Rotation Best Practices for API Usage**<br/>
        /// To maintain compliance with our licensing terms and ensure optimal performance of HumanSignal's APIs, please consider the following guidelines when managing user assignments:<br/>
        /// * **Maintain a 7-Day Minimum Assignment**: Once a licensed seat is assigned to a user, maintain that assignment for at least seven consecutive days before rotating it to another user.<br/>
        /// * **Automate, Monitor, and Log Rotations**: Implement automated scheduling and logging mechanisms to track the timing of user rotations. This helps ensure that rotations adhere to the seven-day minimum period.<br/>
        /// * **Adhere to API Update Frequency and Wait Periods**: When updating user assignments via our APIs, follow the recommended frequency and wait period guidelines provided in the HumanSignal API documentation. Avoid sending rapid, successive requests that might overload the endpoint. Instead, incorporate appropriate delays between calls as specified in the documentation.<br/>
        /// * **Avoid Overloading the API Endpoint**: Design your integration to batch or schedule updates where possible, and implement backoff strategies if the API indicates rate limiting. This helps prevent service disruptions and ensures a smooth operation.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.LseOrganizationMemberList> Update3Async(
            int id,

            global::G.PatchedOrganizationMemberCreateUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdate3Arguments(
                httpClient: HttpClient,
                id: ref id,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_Update3SecurityRequirements,
                operationName: "Update3Async");

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/api/organizations/{id}/memberships",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
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
            PrepareUpdate3Request(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                id: id,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUpdate3Response(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessUpdate3ResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.LseOrganizationMemberList.FromJson(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::G.LseOrganizationMemberList.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// ✨ Update organization member/role<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Update organization membership or role for a specific user ID.<br/>
        /// **User Rotation Best Practices for API Usage**<br/>
        /// To maintain compliance with our licensing terms and ensure optimal performance of HumanSignal's APIs, please consider the following guidelines when managing user assignments:<br/>
        /// * **Maintain a 7-Day Minimum Assignment**: Once a licensed seat is assigned to a user, maintain that assignment for at least seven consecutive days before rotating it to another user.<br/>
        /// * **Automate, Monitor, and Log Rotations**: Implement automated scheduling and logging mechanisms to track the timing of user rotations. This helps ensure that rotations adhere to the seven-day minimum period.<br/>
        /// * **Adhere to API Update Frequency and Wait Periods**: When updating user assignments via our APIs, follow the recommended frequency and wait period guidelines provided in the HumanSignal API documentation. Avoid sending rapid, successive requests that might overload the endpoint. Instead, incorporate appropriate delays between calls as specified in the documentation.<br/>
        /// * **Avoid Overloading the API Endpoint**: Design your integration to batch or schedule updates where possible, and implement backoff strategies if the API indicates rate limiting. This helps prevent service disruptions and ensures a smooth operation.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="role">
        /// Organization role<br/>
        /// * `OW` - Owner<br/>
        /// * `AD` - Administrator<br/>
        /// * `MA` - Manager<br/>
        /// * `RE` - Reviewer<br/>
        /// * `AN` - Annotator<br/>
        /// * `DI` - Deactivated<br/>
        /// * `NO` - Not Activated
        /// </param>
        /// <param name="userId">
        /// Member
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.LseOrganizationMemberList> Update3Async(
            int id,
            global::G.Role9e7Enum? role = default,
            int? userId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.PatchedOrganizationMemberCreateUpdateRequest
            {
                Role = role,
                UserId = userId,
            };

            return await Update3Async(
                id: id,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}