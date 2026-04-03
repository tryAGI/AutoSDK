//HintName: G.AccountClient.GetFocusReport.g.cs

#nullable enable

namespace G
{
    public partial class AccountClient
    {
        partial void PrepareGetFocusReportArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.GetFocusReportSource source,
            ref string? billingMonth,
            ref string? chargeMonth,
            ref global::G.AnyOf<global::System.DateTime?, string>? start,
            ref global::G.AnyOf<global::System.DateTime?, string>? end,
            ref string? timezone,
            ref global::G.GetFocusReportTimeframe? timeframe,
            ref global::G.GetFocusReportBoundToTimeframe? boundToTimeframe);
        partial void PrepareGetFocusReportRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.GetFocusReportSource source,
            string? billingMonth,
            string? chargeMonth,
            global::G.AnyOf<global::System.DateTime?, string>? start,
            global::G.AnyOf<global::System.DateTime?, string>? end,
            string? timezone,
            global::G.GetFocusReportTimeframe? timeframe,
            global::G.GetFocusReportBoundToTimeframe? boundToTimeframe);
        partial void ProcessGetFocusReportResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetFocusReportResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// FOCUS Report<br/>
        /// Returns a FOCUS compliant billing report as a CSV download.<br/>
        /// &gt; **Availability:** This endpoint is available to enterprise customers with FOCUS reports enabled. Contact your account team or support@fal.ai to request access.<br/>
        /// Supports two data sources:<br/>
        /// - **invoice**: Finalized invoice data for a billing month. Includes usage charges, credits, and taxes.<br/>
        /// - **estimate**: Real-time usage estimates for a date range. Pre-invoice data that may change once invoiced.<br/>
        /// The report follows the [FinOps FOCUS specification](https://focus.finops.org/) for cloud billing data interoperability.<br/>
        /// **Invoice reports** default to the most recently available billing month.<br/>
        /// **Usage estimates** default to the last 24 hours, with a maximum 90-day lookback.<br/>
        ///     
        /// </summary>
        /// <param name="source">
        /// Report source. 'invoice' returns finalized invoice data for a billing month. 'estimate' returns real-time usage estimates for a date range.<br/>
        /// Example: invoice
        /// </param>
        /// <param name="billingMonth">
        /// Invoice billing month (YYYY-MM). The month the invoice was issued (e.g. '2025-02' for January charges). Used with source=invoice. Defaults to most recent available billing month.<br/>
        /// Example: 2025-02
        /// </param>
        /// <param name="chargeMonth">
        /// Charge month (YYYY-MM). The month charges were incurred. Converted to billing_month by adding 1 month (billing in arrears). Alternative to billing_month. Used with source=invoice.<br/>
        /// Example: 2025-01
        /// </param>
        /// <param name="start">
        /// Start date in ISO8601 format (e.g., '2025-01-01T00:00:00Z' or '2025-01-01'). Defaults to 24 hours ago.<br/>
        /// Example: 2025-01-01T00:00:00Z
        /// </param>
        /// <param name="end">
        /// End date in ISO8601 format, exclusive (e.g., '2025-02-01T00:00:00Z' or '2025-02-01'). Data up to but not including this timestamp is returned. Defaults to current time.<br/>
        /// Example: 2025-02-01T00:00:00Z
        /// </param>
        /// <param name="timezone">
        /// Timezone for date aggregation and boundaries. All timestamps in responses are in UTC, but this controls how dates are bucketed.<br/>
        /// Default Value: UTC<br/>
        /// Example: UTC
        /// </param>
        /// <param name="timeframe">
        /// Aggregation timeframe for timeseries data (auto-detected from date range if not specified). Auto-detection uses: minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).<br/>
        /// Example: day
        /// </param>
        /// <param name="boundToTimeframe">
        /// Whether to adjust start/end dates to align with timeframe boundaries and use exclusive end. Defaults to true. When true, dates are aligned to the start of the timeframe period (e.g., start of day) and end is made exclusive (e.g., start of next day). When false, uses exact dates provided.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<string> GetFocusReportAsync(
            global::G.GetFocusReportSource source,
            string? billingMonth = default,
            string? chargeMonth = default,
            global::G.AnyOf<global::System.DateTime?, string>? start = default,
            global::G.AnyOf<global::System.DateTime?, string>? end = default,
            string? timezone = default,
            global::G.GetFocusReportTimeframe? timeframe = default,
            global::G.GetFocusReportBoundToTimeframe? boundToTimeframe = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetFocusReportArguments(
                httpClient: HttpClient,
                source: ref source,
                billingMonth: ref billingMonth,
                chargeMonth: ref chargeMonth,
                start: ref start,
                end: ref end,
                timezone: ref timezone,
                timeframe: ref timeframe,
                boundToTimeframe: ref boundToTimeframe);

            var sourceValue = source switch
            {
                global::G.GetFocusReportSource.Invoice => "invoice",
                global::G.GetFocusReportSource.Estimate => "estimate",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var timeframeValue = timeframe switch
            {
                global::G.GetFocusReportTimeframe.Minute => "minute",
                global::G.GetFocusReportTimeframe.Hour => "hour",
                global::G.GetFocusReportTimeframe.Day => "day",
                global::G.GetFocusReportTimeframe.Week => "week",
                global::G.GetFocusReportTimeframe.Month => "month",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var boundToTimeframeValue = boundToTimeframe switch
            {
                global::G.GetFocusReportBoundToTimeframe.True => "true",
                global::G.GetFocusReportBoundToTimeframe.False => "false",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: "/account/focus",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("source", source.ToValueString())
                .AddOptionalParameter("billing_month", billingMonth)
                .AddOptionalParameter("charge_month", chargeMonth)
                .AddOptionalParameter("start", start?.ToString())
                .AddOptionalParameter("end", end?.ToString())
                .AddOptionalParameter("timezone", timezone)
                .AddOptionalParameter("timeframe", timeframe?.ToValueString())
                .AddOptionalParameter("bound_to_timeframe", boundToTimeframe?.ToValueString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetFocusReportRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                source: source,
                billingMonth: billingMonth,
                chargeMonth: chargeMonth,
                start: start,
                end: end,
                timezone: timezone,
                timeframe: timeframe,
                boundToTimeframe: boundToTimeframe);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetFocusReportResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Invalid request parameters
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.GetFocusReportResponse? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.GetFocusReportResponse.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.GetFocusReportResponse.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.GetFocusReportResponse>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
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
            // Authentication required
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                global::G.GetFocusReportResponse2? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::G.GetFocusReportResponse2.FromJson(__content_401, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_401 = global::G.GetFocusReportResponse2.FromJson(__content_401, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::G.ApiException<global::G.GetFocusReportResponse2>(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_401,
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
            // Access denied
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::System.Exception? __exception_403 = null;
                global::G.GetFocusReportResponse3? __value_403 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_403 = global::G.GetFocusReportResponse3.FromJson(__content_403, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_403 = global::G.GetFocusReportResponse3.FromJson(__content_403, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::G.ApiException<global::G.GetFocusReportResponse3>(
                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_403,
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
            // Rate limit exceeded
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                global::System.Exception? __exception_429 = null;
                global::G.GetFocusReportResponse4? __value_429 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_429 = global::G.GetFocusReportResponse4.FromJson(__content_429, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_429 = global::G.GetFocusReportResponse4.FromJson(__content_429, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_429 = __ex;
                }

                throw new global::G.ApiException<global::G.GetFocusReportResponse4>(
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
            // Internal server error
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::System.Exception? __exception_500 = null;
                global::G.GetFocusReportResponse5? __value_500 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_500 = global::G.GetFocusReportResponse5.FromJson(__content_500, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_500 = global::G.GetFocusReportResponse5.FromJson(__content_500, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_500 = __ex;
                }

                throw new global::G.ApiException<global::G.GetFocusReportResponse5>(
                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_500,
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
                ProcessGetFocusReportResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return __content;
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
                    var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return __content;
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
    }
}