//HintName: G.EditInDescriptClient.PostEditInDescriptSchema.g.cs

#nullable enable

namespace G
{
    public partial class EditInDescriptClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_PostEditInDescriptSchemaSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_PostEditInDescriptSchemaSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_PostEditInDescriptSchemaSecurityRequirement0,
            };
        partial void PreparePostEditInDescriptSchemaArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.EditInDescriptSchemaPostBody request);
        partial void PreparePostEditInDescriptSchemaRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.EditInDescriptSchemaPostBody request);
        partial void ProcessPostEditInDescriptSchemaResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPostEditInDescriptSchemaResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Import URL<br/>
        /// Create an Import URL by sending a Project schema to Descript API from your service's backend.<br/>
        /// ### Import Schema<br/>
        /// Our import schemas are specified as a minimal JSON list of files which is detailed in full at the bottom of this<br/>
        /// section. At it's smallest, the request body looks like:<br/>
        /// ```<br/>
        /// {<br/>
        ///   "partner_drive_id": "162c61d1-6ced-4b25-a622-7dba922983ee",<br/>
        ///   "project_schema": {<br/>
        ///     "schema_version": "1.0.0",<br/>
        ///     "files": [{"uri": "https://descriptusercontent.com/jane.wav?signature=d182bca64bf94a1483d2fd16b579f955"}]<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// ### File Access<br/>
        /// The file paths provided in the schema need to either be public or pre-signed URIs with enough time before<br/>
        /// expiration for failures and retries, we suggest URIs that won't expire for 48 hours. We ask that the files have<br/>
        /// already been saved when the import link is generated to minimize cases where we're waiting for eventually<br/>
        /// consistent storage of files that will never be written. We will, however, wait for eventual consistency of the<br/>
        /// storage layer and retry fetching files before eventually timing out.<br/>
        /// Files must be hosted on preapproved hosts as our import process has an allow list which it checks URIs against.<br/>
        /// Files will be requested with `User-Agent: Descriptbot/1.0` (version may change) for tracking purposes.<br/>
        /// ### Import link expiration<br/>
        /// Import links are no longer valid after a user imports their data once. Viewing an already used import link will<br/>
        /// not allow for importing again and will not provide access to a previously created Descript Project. Partners are<br/>
        /// able to generate a new import link at any time, regardless of if a previous import link has been used.<br/>
        /// The API does not currently provide partners with a link to the Descript Project, though users will be redirected<br/>
        /// to it from Descript's web interface the first time they import files, and can always find the Project in Descript.<br/>
        /// Import links expire after 3 hours and attempting to use an import link after the pre-signed links in the schema<br/>
        /// file have expired will result in an error, so we recommend generating the import link after the user has clicked<br/>
        /// the Edit in Descript button.<br/>
        /// ### Supported media specification<br/>
        /// We recommend sending the highest quality, uncompressed versions of files available to you. If you have multiple<br/>
        /// tracks, we recommend prioritizing sending us the full multi-track sequence over a combined file.<br/>
        /// * Audio: WAV, FLAC, AAC, MP3<br/>
        /// * Video: h264, HEVC (container: MOV, MP4)
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.EditInDescriptSchemaPostResponse> PostEditInDescriptSchemaAsync(

            global::G.EditInDescriptSchemaPostBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePostEditInDescriptSchemaArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_PostEditInDescriptSchemaSecurityRequirements,
                operationName: "PostEditInDescriptSchemaAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/edit_in_descript/schema",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            PreparePostEditInDescriptSchemaRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessPostEditInDescriptSchemaResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::System.Exception? __exception_403 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_403,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Too many requests - rate limit exceeded. Use the `Retry-After` header to determine when to retry. 
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                global::System.Exception? __exception_429 = null;
                global::G.Error429? __value_429 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_429 = global::G.Error429.FromJson(__content_429, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_429 = global::G.Error429.FromJson(__content_429, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_429 = __ex;
                }

                throw new global::G.ApiException<global::G.Error429>(
                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_429,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_429,
                    ResponseObject = __value_429,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

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
                ProcessPostEditInDescriptSchemaResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.EditInDescriptSchemaPostResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.EditInDescriptSchemaPostResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Create Import URL<br/>
        /// Create an Import URL by sending a Project schema to Descript API from your service's backend.<br/>
        /// ### Import Schema<br/>
        /// Our import schemas are specified as a minimal JSON list of files which is detailed in full at the bottom of this<br/>
        /// section. At it's smallest, the request body looks like:<br/>
        /// ```<br/>
        /// {<br/>
        ///   "partner_drive_id": "162c61d1-6ced-4b25-a622-7dba922983ee",<br/>
        ///   "project_schema": {<br/>
        ///     "schema_version": "1.0.0",<br/>
        ///     "files": [{"uri": "https://descriptusercontent.com/jane.wav?signature=d182bca64bf94a1483d2fd16b579f955"}]<br/>
        ///   }<br/>
        /// }<br/>
        /// ```<br/>
        /// ### File Access<br/>
        /// The file paths provided in the schema need to either be public or pre-signed URIs with enough time before<br/>
        /// expiration for failures and retries, we suggest URIs that won't expire for 48 hours. We ask that the files have<br/>
        /// already been saved when the import link is generated to minimize cases where we're waiting for eventually<br/>
        /// consistent storage of files that will never be written. We will, however, wait for eventual consistency of the<br/>
        /// storage layer and retry fetching files before eventually timing out.<br/>
        /// Files must be hosted on preapproved hosts as our import process has an allow list which it checks URIs against.<br/>
        /// Files will be requested with `User-Agent: Descriptbot/1.0` (version may change) for tracking purposes.<br/>
        /// ### Import link expiration<br/>
        /// Import links are no longer valid after a user imports their data once. Viewing an already used import link will<br/>
        /// not allow for importing again and will not provide access to a previously created Descript Project. Partners are<br/>
        /// able to generate a new import link at any time, regardless of if a previous import link has been used.<br/>
        /// The API does not currently provide partners with a link to the Descript Project, though users will be redirected<br/>
        /// to it from Descript's web interface the first time they import files, and can always find the Project in Descript.<br/>
        /// Import links expire after 3 hours and attempting to use an import link after the pre-signed links in the schema<br/>
        /// file have expired will result in an error, so we recommend generating the import link after the user has clicked<br/>
        /// the Edit in Descript button.<br/>
        /// ### Supported media specification<br/>
        /// We recommend sending the highest quality, uncompressed versions of files available to you. If you have multiple<br/>
        /// tracks, we recommend prioritizing sending us the full multi-track sequence over a combined file.<br/>
        /// * Audio: WAV, FLAC, AAC, MP3<br/>
        /// * Video: h264, HEVC (container: MOV, MP4)
        /// </summary>
        /// <param name="partnerDriveId">
        /// The drive id associated with the auth token.<br/>
        /// Example: aa3b2d8d-e5ca-41c2-8801-683328293fb9
        /// </param>
        /// <param name="projectSchema">
        /// The Project schema
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.EditInDescriptSchemaPostResponse> PostEditInDescriptSchemaAsync(
            global::System.Guid partnerDriveId,
            global::G.EditInDescriptSchemaPostBodyProjectSchema projectSchema,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.EditInDescriptSchemaPostBody
            {
                PartnerDriveId = partnerDriveId,
                ProjectSchema = projectSchema,
            };

            return await PostEditInDescriptSchemaAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}