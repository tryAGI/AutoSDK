//HintName: G.UserClient.DeleteUser.g.cs

#nullable enable

namespace G
{
    public partial class UserClient
    {
        partial void PrepareDeleteUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref long? id,
            global::System.Collections.Generic.IList<string>? roles,
            ref string? firstName,
            ref string? lastName,
            ref string? userName,
            ref string? email,
            ref string? phoneNumber,
            ref string? addressLine1,
            ref string? addressLine2,
            ref string? city,
            ref string? region,
            ref string? countryIsoCode,
            ref bool? isDeleted,
            ref bool? passwordChangeRequired,
            ref bool? profileUpdateRequired,
            ref bool? securityWordsGenerated,
            ref bool? securityWordsResetRequired,
            ref string? instagramHandle,
            ref bool? isDisabled,
            ref string? blockRemarks,
            ref string? firebaseNotificationToken,
            ref double? longitude,
            ref double? latitude,
            ref global::System.DateTime? dateOfBirth,
            ref bool? emailConfirmed,
            ref bool? quickPay,
            ref bool? xTera,
            ref string? currentCulture);
        partial void PrepareDeleteUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            long? id,
            global::System.Collections.Generic.IList<string>? roles,
            string? firstName,
            string? lastName,
            string? userName,
            string? email,
            string? phoneNumber,
            string? addressLine1,
            string? addressLine2,
            string? city,
            string? region,
            string? countryIsoCode,
            bool? isDeleted,
            bool? passwordChangeRequired,
            bool? profileUpdateRequired,
            bool? securityWordsGenerated,
            bool? securityWordsResetRequired,
            string? instagramHandle,
            bool? isDisabled,
            string? blockRemarks,
            string? firebaseNotificationToken,
            double? longitude,
            double? latitude,
            global::System.DateTime? dateOfBirth,
            bool? emailConfirmed,
            bool? quickPay,
            bool? xTera,
            string? currentCulture);
        partial void ProcessDeleteUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDeleteUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// This is a description
        /// </summary>
        /// <param name="id"></param>
        /// <param name="roles"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="userName"></param>
        /// <param name="email"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="addressLine1"></param>
        /// <param name="addressLine2"></param>
        /// <param name="city"></param>
        /// <param name="region"></param>
        /// <param name="countryIsoCode"></param>
        /// <param name="isDeleted"></param>
        /// <param name="passwordChangeRequired"></param>
        /// <param name="profileUpdateRequired"></param>
        /// <param name="securityWordsGenerated"></param>
        /// <param name="securityWordsResetRequired"></param>
        /// <param name="instagramHandle"></param>
        /// <param name="isDisabled"></param>
        /// <param name="blockRemarks"></param>
        /// <param name="firebaseNotificationToken"></param>
        /// <param name="longitude"></param>
        /// <param name="latitude"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="emailConfirmed"></param>
        /// <param name="quickPay"></param>
        /// <param name="xTera"></param>
        /// <param name="currentCulture">
        /// Default Value: en-GB
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<string> DeleteUserAsync(
            long? id = default,
            global::System.Collections.Generic.IList<string>? roles = default,
            string? firstName = default,
            string? lastName = default,
            string? userName = default,
            string? email = default,
            string? phoneNumber = default,
            string? addressLine1 = default,
            string? addressLine2 = default,
            string? city = default,
            string? region = default,
            string? countryIsoCode = default,
            bool? isDeleted = default,
            bool? passwordChangeRequired = default,
            bool? profileUpdateRequired = default,
            bool? securityWordsGenerated = default,
            bool? securityWordsResetRequired = default,
            string? instagramHandle = default,
            bool? isDisabled = default,
            string? blockRemarks = default,
            string? firebaseNotificationToken = default,
            double? longitude = default,
            double? latitude = default,
            global::System.DateTime? dateOfBirth = default,
            bool? emailConfirmed = default,
            bool? quickPay = default,
            bool? xTera = default,
            string? currentCulture = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareDeleteUserArguments(
                httpClient: HttpClient,
                id: ref id,
                roles: roles,
                firstName: ref firstName,
                lastName: ref lastName,
                userName: ref userName,
                email: ref email,
                phoneNumber: ref phoneNumber,
                addressLine1: ref addressLine1,
                addressLine2: ref addressLine2,
                city: ref city,
                region: ref region,
                countryIsoCode: ref countryIsoCode,
                isDeleted: ref isDeleted,
                passwordChangeRequired: ref passwordChangeRequired,
                profileUpdateRequired: ref profileUpdateRequired,
                securityWordsGenerated: ref securityWordsGenerated,
                securityWordsResetRequired: ref securityWordsResetRequired,
                instagramHandle: ref instagramHandle,
                isDisabled: ref isDisabled,
                blockRemarks: ref blockRemarks,
                firebaseNotificationToken: ref firebaseNotificationToken,
                longitude: ref longitude,
                latitude: ref latitude,
                dateOfBirth: ref dateOfBirth,
                emailConfirmed: ref emailConfirmed,
                quickPay: ref quickPay,
                xTera: ref xTera,
                currentCulture: ref currentCulture);

            var __pathBuilder = new PathBuilder(
                path: "/api/User/delete",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("Id", id?.ToString()) 
                .AddOptionalParameter("Roles", roles, delimiter: ",", explode: true) 
                .AddOptionalParameter("FirstName", firstName) 
                .AddOptionalParameter("LastName", lastName) 
                .AddOptionalParameter("UserName", userName) 
                .AddOptionalParameter("Email", email) 
                .AddOptionalParameter("PhoneNumber", phoneNumber) 
                .AddOptionalParameter("AddressLine1", addressLine1) 
                .AddOptionalParameter("AddressLine2", addressLine2) 
                .AddOptionalParameter("City", city) 
                .AddOptionalParameter("Region", region) 
                .AddOptionalParameter("CountryIsoCode", countryIsoCode) 
                .AddOptionalParameter("IsDeleted", isDeleted?.ToString()) 
                .AddOptionalParameter("PasswordChangeRequired", passwordChangeRequired?.ToString()) 
                .AddOptionalParameter("ProfileUpdateRequired", profileUpdateRequired?.ToString()) 
                .AddOptionalParameter("SecurityWordsGenerated", securityWordsGenerated?.ToString()) 
                .AddOptionalParameter("SecurityWordsResetRequired", securityWordsResetRequired?.ToString()) 
                .AddOptionalParameter("InstagramHandle", instagramHandle) 
                .AddOptionalParameter("IsDisabled", isDisabled?.ToString()) 
                .AddOptionalParameter("BlockRemarks", blockRemarks) 
                .AddOptionalParameter("FirebaseNotificationToken", firebaseNotificationToken) 
                .AddOptionalParameter("Longitude", longitude?.ToString()) 
                .AddOptionalParameter("Latitude", latitude?.ToString()) 
                .AddOptionalParameter("DateOfBirth", dateOfBirth?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("EmailConfirmed", emailConfirmed?.ToString()) 
                .AddOptionalParameter("QuickPay", quickPay?.ToString()) 
                .AddOptionalParameter("XTera", xTera?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

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

            if (currentCulture != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Current-Culture", currentCulture.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareDeleteUserRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                id: id,
                roles: roles,
                firstName: firstName,
                lastName: lastName,
                userName: userName,
                email: email,
                phoneNumber: phoneNumber,
                addressLine1: addressLine1,
                addressLine2: addressLine2,
                city: city,
                region: region,
                countryIsoCode: countryIsoCode,
                isDeleted: isDeleted,
                passwordChangeRequired: passwordChangeRequired,
                profileUpdateRequired: profileUpdateRequired,
                securityWordsGenerated: securityWordsGenerated,
                securityWordsResetRequired: securityWordsResetRequired,
                instagramHandle: instagramHandle,
                isDisabled: isDisabled,
                blockRemarks: blockRemarks,
                firebaseNotificationToken: firebaseNotificationToken,
                longitude: longitude,
                latitude: latitude,
                dateOfBirth: dateOfBirth,
                emailConfirmed: emailConfirmed,
                quickPay: quickPay,
                xTera: xTera,
                currentCulture: currentCulture);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessDeleteUserResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Bad Request
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::G.ValidationProblemDetails? __value_400 = null;
                if (ReadResponseAsString)
                {
                    __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_400 = global::G.ValidationProblemDetails.FromJson(__content_400, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_400 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_400 = await global::G.ValidationProblemDetails.FromJsonStreamAsync(__contentStream_400, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.ValidationProblemDetails>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Unauthorized
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::G.ProblemDetails? __value_401 = null;
                if (ReadResponseAsString)
                {
                    __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = global::G.ProblemDetails.FromJson(__content_401, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_401 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_401 = await global::G.ProblemDetails.FromJsonStreamAsync(__contentStream_401, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.ProblemDetails>(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseObject = __value_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Forbidden
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::G.ProblemDetails? __value_403 = null;
                if (ReadResponseAsString)
                {
                    __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_403 = global::G.ProblemDetails.FromJson(__content_403, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_403 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_403 = await global::G.ProblemDetails.FromJsonStreamAsync(__contentStream_403, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.ProblemDetails>(
                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseObject = __value_403,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Not Found
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::G.ProblemDetails? __value_404 = null;
                if (ReadResponseAsString)
                {
                    __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_404 = global::G.ProblemDetails.FromJson(__content_404, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_404 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_404 = await global::G.ProblemDetails.FromJsonStreamAsync(__contentStream_404, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.ProblemDetails>(
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
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
            // Internal Server Error
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::G.ProblemDetails? __value_500 = null;
                if (ReadResponseAsString)
                {
                    __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_500 = global::G.ProblemDetails.FromJson(__content_500, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_500 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_500 = await global::G.ProblemDetails.FromJsonStreamAsync(__contentStream_500, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.ProblemDetails>(
                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_500,
                    ResponseObject = __value_500,
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
                ProcessDeleteUserResponseContent(
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

                return __content;
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

                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                return __content;
            }
        }
    }
}