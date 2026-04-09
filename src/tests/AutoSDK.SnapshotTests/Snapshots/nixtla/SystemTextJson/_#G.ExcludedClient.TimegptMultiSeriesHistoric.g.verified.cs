//HintName: G.ExcludedClient.TimegptMultiSeriesHistoric.g.cs

#nullable enable

namespace G
{
    public partial class ExcludedClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_TimegptMultiSeriesHistoricSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HTTPBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_TimegptMultiSeriesHistoricSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_TimegptMultiSeriesHistoricSecurityRequirement0,
            };
        partial void PrepareTimegptMultiSeriesHistoricArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.MultiSeriesInsampleForecast request);
        partial void PrepareTimegptMultiSeriesHistoricRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.MultiSeriesInsampleForecast request);
        partial void ProcessTimegptMultiSeriesHistoricResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTimegptMultiSeriesHistoricResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Foundational Time Series Model Multi Series Historic (Beta)<br/>
        /// Based on the provided data, this endpoint predicts the in-sample period (historical period) values of multiple time series at once. It takes a JSON as an input containing information like the series frequency and historical data. (See below for a full description of the parameters.) The response contains the predicted values for the historical period. Usually useful for anomaly detection. Get your token for private beta at https://nixtla.io/free-trial?utm_source=nixtla.io&amp;utm_campaign=/docs/api-reference.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task<string> TimegptMultiSeriesHistoricAsync(

            global::G.MultiSeriesInsampleForecast request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareTimegptMultiSeriesHistoricArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_TimegptMultiSeriesHistoricSecurityRequirements,
                operationName: "TimegptMultiSeriesHistoricAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/timegpt_multi_series_historic",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            var __cookies = new global::System.Collections.Generic.List<string>();
            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Cookie")
                {
                    var __cookieValue = global::System.Uri.EscapeDataString(__authorization.Value);
                    __cookies.Add($"{__authorization.Name}={__cookieValue}");
                }
            }

            if (__cookies.Count > 0)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Cookie", string.Join("; ", __cookies));
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
            PrepareTimegptMultiSeriesHistoricRequest(
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
            ProcessTimegptMultiSeriesHistoricResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::G.HTTPValidationError? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::G.ApiException<global::G.HTTPValidationError>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
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
                ProcessTimegptMultiSeriesHistoricResponseContent(
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
        /// <summary>
        /// Foundational Time Series Model Multi Series Historic (Beta)<br/>
        /// Based on the provided data, this endpoint predicts the in-sample period (historical period) values of multiple time series at once. It takes a JSON as an input containing information like the series frequency and historical data. (See below for a full description of the parameters.) The response contains the predicted values for the historical period. Usually useful for anomaly detection. Get your token for private beta at https://nixtla.io/free-trial?utm_source=nixtla.io&amp;utm_campaign=/docs/api-reference.
        /// </summary>
        /// <param name="model">
        /// Model to use as a string. Common options are (but not restricted to) `timegpt-1` and `timegpt-1-long-horizon.` Full options vary by different users. Contact support@nixtla.io for more information. We recommend using `timegpt-1-long-horizon` for forecasting if you want to predict more than one seasonal period given the frequency of your data.<br/>
        /// Default Value: timegpt-1
        /// </param>
        /// <param name="freq">
        /// The frequency of the data represented as a string. 'D' for daily, 'M' for monthly, 'H' for hourly, and 'W' for weekly frequencies are available.<br/>
        /// Default Value: D
        /// </param>
        /// <param name="level">
        /// A list of values representing the prediction intervals. Each value is a percentage that indicates the level of certainty for the corresponding prediction interval. For example, [80, 90] defines 80% and 90% prediction intervals.
        /// </param>
        /// <param name="y">
        /// The historical time series data provided as a dictionary of two colums: columns and data. The columns contains the columns of the dataframe and data contains eaach data point. For example: {"columns": ["unique_id", "ds", "y"], "data": [["ts_0", "2021-01-01", 0.7], ["ts_0", "2021-01-02", 0.8]}.<br/>
        /// Default Value: {"columns":["unique_id","ds","y"],"data":[["PeytonManning","2015-12-02",4.390508031418598],["PeytonManning","2015-12-03",5.721514930979356],["PeytonManning","2015-12-04",4.822107008573151],["PeytonManning","2015-12-05",4.359065463975175],["PeytonManning","2015-12-06",3.3892383947112377],["PeytonManning","2015-12-07",5.167152904533249],["PeytonManning","2015-12-08",3.50069769010154],["PeytonManning","2015-12-09",7.134184006256638],["PeytonManning","2015-12-10",7.709302084008234],["PeytonManning","2015-12-11",3.0675321506062216],["PeytonManning","2015-12-12",6.333800304661317],["PeytonManning","2015-12-13",4.231159358023236],["PeytonManning","2015-12-14",4.5443564887514585],["PeytonManning","2015-12-15",7.404773106341288],["PeytonManning","2015-12-16",0.5682884655830955],["PeytonManning","2015-12-17",0.6970343976123257],["PeytonManning","2015-12-18",0.16174717952260576],["PeytonManning","2015-12-19",6.660958764383504],["PeytonManning","2015-12-20",6.225254007598804],["PeytonManning","2015-12-21",6.960097185974553],["PeytonManning","2015-12-22",7.828946737862112],["PeytonManning","2015-12-23",6.393268513733789],["PeytonManning","2015-12-24",3.6918348980234548],["PeytonManning","2015-12-25",6.244233410291644],["PeytonManning","2015-12-26",0.9461954069514658],["PeytonManning","2015-12-27",5.119368170620191],["PeytonManning","2015-12-28",1.1468262992723712],["PeytonManning","2015-12-29",7.557351336396671],["PeytonManning","2015-12-30",4.174786574000573],["PeytonManning","2015-12-31",3.3172955199241887],["PeytonManning","2016-01-01",2.1164448968370158],["PeytonManning","2016-01-02",6.193869515473733],["PeytonManning","2016-01-03",3.6492026577323884],["PeytonManning","2016-01-04",4.547471590949188],["PeytonManning","2016-01-05",0.15031840349084113],["PeytonManning","2016-01-06",4.9410839766070165],["PeytonManning","2016-01-07",4.896765781779371],["PeytonManning","2016-01-08",4.935471974998055],["PeytonManning","2016-01-09",7.549984628116993],["PeytonManning","2016-01-10",5.454562392827867],["PeytonManning","2016-01-11",2.876063204590288],["PeytonManning","2016-01-12",3.4962556303947316],["PeytonManning","2016-01-13",5.581049567418119],["TomBrady","2015-12-02",4.390508031418598],["TomBrady","2015-12-03",5.721514930979356],["TomBrady","2015-12-04",4.822107008573151],["TomBrady","2015-12-05",4.359065463975175],["TomBrady","2015-12-06",3.3892383947112377],["TomBrady","2015-12-07",5.167152904533249],["TomBrady","2015-12-08",3.50069769010154],["TomBrady","2015-12-09",7.134184006256638],["TomBrady","2015-12-10",7.709302084008234],["TomBrady","2015-12-11",3.0675321506062216],["TomBrady","2015-12-12",6.333800304661317],["TomBrady","2015-12-13",4.231159358023236],["TomBrady","2015-12-14",4.5443564887514585],["TomBrady","2015-12-15",7.404773106341288],["TomBrady","2015-12-16",0.5682884655830955],["TomBrady","2015-12-17",0.6970343976123257],["TomBrady","2015-12-18",0.16174717952260576],["TomBrady","2015-12-19",6.660958764383504],["TomBrady","2015-12-20",6.225254007598804],["TomBrady","2015-12-21",6.960097185974553],["TomBrady","2015-12-22",7.828946737862112],["TomBrady","2015-12-23",6.393268513733789],["TomBrady","2015-12-24",3.6918348980234548],["TomBrady","2015-12-25",6.244233410291644],["TomBrady","2015-12-26",0.9461954069514658],["TomBrady","2015-12-27",5.119368170620191],["TomBrady","2015-12-28",1.1468262992723712],["TomBrady","2015-12-29",7.557351336396671],["TomBrady","2015-12-30",4.174786574000573],["TomBrady","2015-12-31",3.3172955199241887],["TomBrady","2016-01-01",2.1164448968370158],["TomBrady","2016-01-02",6.193869515473733],["TomBrady","2016-01-03",3.6492026577323884],["TomBrady","2016-01-04",4.547471590949188],["TomBrady","2016-01-05",0.15031840349084113],["TomBrady","2016-01-06",4.9410839766070165],["TomBrady","2016-01-07",4.896765781779371],["TomBrady","2016-01-08",4.935471974998055],["TomBrady","2016-01-09",7.549984628116993],["TomBrady","2016-01-10",5.454562392827867],["TomBrady","2016-01-11",2.876063204590288],["TomBrady","2016-01-12",3.4962556303947316],["TomBrady","2016-01-13",5.581049567418119]]}
        /// </param>
        /// <param name="x">
        /// The exogenous  variables provided as a dictionary of two colums: columns and data. The columns contains the columns of the dataframe and data contains eaach data point. For example: {"columns": ["unique_id", "ds", "ex_1", "ex_2"], "data": [["ts_0", "2021-01-01", 0.2, 0.67], ["ts_0", "2021-01-02", 0.4, 0.7]}. This should also include forecasting horizon (fh) additional timestamps for each unique_id to calculate the future values.
        /// </param>
        /// <param name="cleanExFirst">
        /// A boolean flag that indicates whether the API should preprocess (clean) the exogenous signal before applying the large time model. If True, the exogenous signal is cleaned; if False, the exogenous variables are applied after the large time model.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task<string> TimegptMultiSeriesHistoricAsync(
            object? model = default,
            string? freq = default,
            global::System.Collections.Generic.IList<global::G.AnyOf<int?, double?>>? level = default,
            object? y = default,
            global::G.MultiSeriesInput? x = default,
            bool? cleanExFirst = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.MultiSeriesInsampleForecast
            {
                Model = model,
                Freq = freq,
                Level = level,
                Y = y,
                X = x,
                CleanExFirst = cleanExFirst,
            };

            return await TimegptMultiSeriesHistoricAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}