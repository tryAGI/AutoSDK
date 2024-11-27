//HintName: G.OrgsClient.OrgsListPendingInvitations.g.cs

#nullable enable

namespace G
{
    public partial class OrgsClient
    {
        partial void PrepareOrgsListPendingInvitationsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string org,
            ref int? perPage,
            ref int? page,
            ref global::G.OrgsListPendingInvitationsRole? role,
            ref global::G.OrgsListPendingInvitationsInvitationSource? invitationSource);
        partial void PrepareOrgsListPendingInvitationsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string org,
            int? perPage,
            int? page,
            global::G.OrgsListPendingInvitationsRole? role,
            global::G.OrgsListPendingInvitationsInvitationSource? invitationSource);
        partial void ProcessOrgsListPendingInvitationsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOrgsListPendingInvitationsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List pending organization invitations<br/>
        /// The return hash contains a `role` field which refers to the Organization<br/>
        /// Invitation role and will be one of the following values: `direct_member`, `admin`,<br/>
        /// `billing_manager`, or `hiring_manager`. If the invitee is not a GitHub<br/>
        /// member, the `login` field in the return hash will be `null`.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="role">
        /// Default Value: all
        /// </param>
        /// <param name="invitationSource">
        /// Default Value: all
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.OrganizationInvitation>> OrgsListPendingInvitationsAsync(
            string org,
            int? perPage = default,
            int? page = default,
            global::G.OrgsListPendingInvitationsRole? role = default,
            global::G.OrgsListPendingInvitationsInvitationSource? invitationSource = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareOrgsListPendingInvitationsArguments(
                httpClient: HttpClient,
                org: ref org,
                perPage: ref perPage,
                page: ref page,
                role: ref role,
                invitationSource: ref invitationSource);

            var roleValue = role switch
            {
                global::G.OrgsListPendingInvitationsRole.All => "all",
                global::G.OrgsListPendingInvitationsRole.Admin => "admin",
                global::G.OrgsListPendingInvitationsRole.DirectMember => "direct_member",
                global::G.OrgsListPendingInvitationsRole.BillingManager => "billing_manager",
                global::G.OrgsListPendingInvitationsRole.HiringManager => "hiring_manager",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var invitationSourceValue = invitationSource switch
            {
                global::G.OrgsListPendingInvitationsInvitationSource.All => "all",
                global::G.OrgsListPendingInvitationsInvitationSource.Member => "member",
                global::G.OrgsListPendingInvitationsInvitationSource.Scim => "scim",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: $"/orgs/{org}/invitations",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                .AddOptionalParameter("page", page?.ToString()) 
                .AddOptionalParameter("role", roleValue?.ToString()) 
                .AddOptionalParameter("invitation_source", invitationSourceValue?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareOrgsListPendingInvitationsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                org: org,
                perPage: perPage,
                page: page,
                role: role,
                invitationSource: invitationSource);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessOrgsListPendingInvitationsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Resource not found
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::G.BasicError? __value_404 = null;
                if (ReadResponseAsString)
                {
                    __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_404 = global::G.BasicError.FromJson(__content_404, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_404 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_404 = await global::G.BasicError.FromJsonStreamAsync(__contentStream_404, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.BasicError>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseObject = __value_404,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessOrgsListPendingInvitationsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
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

                return
                    global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.OrganizationInvitation>?>(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
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

                using var __content = await __response.Content.ReadAsStreamAsync().ConfigureAwait(false);

                return
                    global::Newtonsoft.Json.JsonSerializer.Create(JsonSerializerOptions).Deserialize<global::System.Collections.Generic.IList<global::G.OrganizationInvitation>?>(new global::Newtonsoft.Json.JsonTextReader(new global::System.IO.StreamReader(__content))) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}