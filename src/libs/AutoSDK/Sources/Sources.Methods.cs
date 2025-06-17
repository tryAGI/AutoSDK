using AutoSDK.Extensions;
using AutoSDK.Helpers;
using AutoSDK.Models;
using AutoSDK.Serialization.Json;
using Microsoft.OpenApi.Models;

namespace AutoSDK.Generation;

public static partial class Sources
{
    public static string GenerateEndPoint(
        EndPoint endPoint,
        CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(endPoint.Path))
        {
            return string.Empty;
        }

        var contentType = endPoint.ContentType switch
        {
            ContentType.String => "string",
            ContentType.Stream => "global::System.IO.Stream",
            _ => "byte[]",
        };

        return $@"
#nullable enable{(
    endPoint.Parameters.Any(x => x is { IsDeprecated: true, Location: not null }) ||
    endPoint.IsMultipartFormData && endPoint.Parameters.Any(x => x.IsDeprecated) ? @"

#pragma warning disable CS0618 // Type or member is obsolete" : "")}

namespace {endPoint.Settings.Namespace}
{{
    public partial class {endPoint.ClassName}
    {{
        partial void Prepare{endPoint.NotAsyncMethodName}Arguments(
            global::System.Net.Http.HttpClient httpClient{endPoint.Parameters
                .Where(x => x.Location != null)
                .Select(x => $@",
            {(x.Type.IsReferenceable ? "ref " : "")}{x.Type.CSharpType} {x.ParameterName}").Inject(emptyValue: "")}{(string.IsNullOrWhiteSpace(endPoint.RequestType.CSharpType) ? "" : @$",
            {endPoint.RequestType.CSharpTypeWithoutNullability} request")});
        partial void Prepare{endPoint.NotAsyncMethodName}Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage{endPoint.Parameters
                .Where(x => x.Location != null)
                .Select(x => $@",
            {x.Type.CSharpType} {x.ParameterName}").Inject(emptyValue: "")}{(string.IsNullOrWhiteSpace(endPoint.RequestType.CSharpType) ? "" : @$",
            {endPoint.RequestType.CSharpTypeWithoutNullability} request")});
        partial void Process{endPoint.NotAsyncMethodName}Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);
{(string.IsNullOrWhiteSpace(endPoint.SuccessResponse.Type.CSharpType) || endPoint.Stream ? " " : $@"
        partial void Process{endPoint.NotAsyncMethodName}ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref {contentType} content);")}

{GenerateMethod(endPoint)}
{GenerateExtensionMethod(endPoint)}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }

    public static string GenerateEndPointInterface(
        EndPoint endPoint,
        CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(endPoint.Path))
        {
            return string.Empty;
        }

        return $@"#nullable enable

namespace {endPoint.Settings.Namespace}
{{
    public partial interface I{endPoint.ClassName}
    {{
{GenerateMethod(endPoint, isInterface: true)}
{GenerateExtensionMethod(endPoint, isInterface: true)}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }

    public static string GetHttpMethod(OperationType operationType)
    {
        if (operationType == OperationType.Patch)
        {
            return "new global::System.Net.Http.HttpMethod(\"PATCH\")";
        }

        return $"global::System.Net.Http.HttpMethod.{operationType:G}";
    }

    public static string GenerateMethod(
        EndPoint endPoint, bool isInterface = false)
    {
        var taskType = endPoint.Stream
            ? string.IsNullOrWhiteSpace(endPoint.SuccessResponse.Type.CSharpType)
                ? throw new InvalidOperationException($"Streamed responses must have a response type. OperationId: {endPoint.Id}.")
                : $"global::System.Collections.Generic.IAsyncEnumerable<{endPoint.SuccessResponse.Type.CSharpTypeWithoutNullability}>"
            : string.IsNullOrWhiteSpace(endPoint.SuccessResponse.Type.CSharpType)
                ? "global::System.Threading.Tasks.Task"
                : $"global::System.Threading.Tasks.Task<{endPoint.SuccessResponse.Type.CSharpTypeWithoutNullability}>";
        var cancellationTokenAttribute = endPoint.Stream && !isInterface
            ? "[global::System.Runtime.CompilerServices.EnumeratorCancellation] "
            : string.Empty;
        var body = isInterface
            ? ";"
            : @$"
        {{
{(string.IsNullOrWhiteSpace(endPoint.RequestType.CSharpType) || endPoint.RequestType.IsAnyOfLike ? " " : @" 
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));
")}
            PrepareArguments(
                client: HttpClient);
            Prepare{endPoint.NotAsyncMethodName}Arguments(
                httpClient: HttpClient{endPoint.Parameters
                    .Where(x => x.Location != null)
                    .Select(x => $@",
                {x.ParameterName}: {(x.Type.IsReferenceable ? "ref " : "")}{x.ParameterName}").Inject(emptyValue: "")}{(string.IsNullOrWhiteSpace(endPoint.RequestType.CSharpType) ? "" : @",
                request: request")});

{(endPoint.Settings.JsonSerializerType == JsonSerializerType.NewtonsoftJson ? endPoint.Parameters
    .Where(x => x is { Location: not null, Type.EnumValues.Length: > 0 })
    .Select(x => $@"
            var {x.ArgumentName} = {x.ParameterName} switch
            {{
{x.Type.Properties.Zip(x.Type.EnumValues, (property, value) => (Property: property, Value: value))
    .Select(y => string.IsNullOrWhiteSpace(y.Property) ? @"
                null => string.Empty," : $@"
                {x.Type.CSharpTypeWithoutNullability}.{y.Property} => ""{y.Value}"",").Inject()}
                _ => throw new global::System.NotImplementedException(""Enum value not implemented.""),
            }};").Inject() : " ")}
{GeneratePathAndQuery(endPoint)}
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: {GetHttpMethod(endPoint.HttpMethod)},
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
{           // Use HTTP/3.0 or HTTP/2.0 if available
            // https://learn.microsoft.com/en-us/dotnet/core/extensions/httpclient-http3#httpclient-settings
    " "}
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
{(endPoint.Authorizations.Any(x => x is
    { Type: SecuritySchemeType.ApiKey, In: ParameterLocation.Header } or
    { Type: SecuritySchemeType.Http } or
    { Type: SecuritySchemeType.OAuth2 }) ? @$"
            foreach (var __authorization in Authorizations)
            {{
                if (__authorization.Type == ""{SecuritySchemeType.Http:G}"" ||
                    __authorization.Type == ""{SecuritySchemeType.OAuth2:G}"")
                {{
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }}
                else if (__authorization.Type == ""{SecuritySchemeType.ApiKey:G}"" &&
                         __authorization.Location == ""{ParameterLocation.Header:G}"")
                {{
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }}
            }}" : " ")}
{(endPoint.Parameters.Any(x => x is { Location: ParameterLocation.Header }) ? "" : " ")}
{endPoint.Parameters
    .Where(x => x is { Location: ParameterLocation.Header, IsRequired: true })
    .Select(x => $@"
            __httpRequest.Headers.TryAddWithoutValidation(""{x.Id}"", {x.ParameterName}{(x.Type.IsEnum ? ".ToValueString()" : ".ToString()")});").Inject()}
{endPoint.Parameters
    .Where(x => x is { Location: ParameterLocation.Header, IsRequired: false })
    .Select(x => $@"
            if ({x.ParameterName} != default)
            {{
                __httpRequest.Headers.TryAddWithoutValidation(""{x.Id}"", {x.ParameterName}{(x.Type.IsEnum ? "?.ToValueString() ?? string.Empty" : ".ToString()")});
            }}").Inject()}
{(endPoint.Parameters.Any(x => x is { Location: ParameterLocation.Header }) ? "" : " ")}
 
{GenerateRequestData(endPoint)}

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            Prepare{endPoint.NotAsyncMethodName}Request(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest{endPoint.Parameters
                    .Where(x => x.Location != null)
                    .Select(x => $@",
                {x.ParameterName}: {x.ParameterName}").Inject(emptyValue: "")}{(string.IsNullOrWhiteSpace(endPoint.RequestType.CSharpType) ? "" : @",
                request: request")});

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.{(endPoint.Stream
                    // https://learn.microsoft.com/en-us/dotnet/fundamentals/networking/http/httpclient-migrate-from-httpwebrequest#usage-of-buffering-properties
                    ? nameof(HttpCompletionOption.ResponseHeadersRead)
                    : nameof(HttpCompletionOption.ResponseContentRead))},
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            Process{endPoint.NotAsyncMethodName}Response(
                httpClient: HttpClient,
                httpResponseMessage: __response);
{GenerateResponse(endPoint)}
        }}";

        return $@" 
        {endPoint.Summary.ToXmlDocumentationSummary(level: 8)}
{endPoint.Parameters.Where(x => x.Location != null).Select(x => $@"
        {x.Summary.ToXmlDocumentationForParam(x.ParameterName, level: 8)}").Inject()}
{(string.IsNullOrWhiteSpace(endPoint.RequestType.CSharpType) ? " " : @" 
        /// <param name=""request""></param>")}
        /// <param name=""cancellationToken"">The token to cancel the operation with</param>
        /// <exception cref=""global::{endPoint.Settings.Namespace}.ApiException""></exception>
        {GenerateEndPointAttributes(endPoint)}
        {(isInterface ? "" : "public async ")}{taskType} {endPoint.MethodName}(
{endPoint.Parameters.Where(x => x is { Location: not null, IsRequired: true }).Select(x => $@"
            {x.Type.CSharpType} {x.ParameterName},").Inject()}
{(string.IsNullOrWhiteSpace(endPoint.RequestType.CSharpType) ? " " : @$" 
            {endPoint.RequestType.CSharpTypeWithoutNullability} request,")}
{endPoint.Parameters.Where(x => x is { Location: not null, IsRequired: false }).Select(x => $@"
            {x.Type.CSharpType} {x.ParameterName} = {x.ParameterDefaultValue},").Inject()}
            {cancellationTokenAttribute}global::System.Threading.CancellationToken cancellationToken = default){body}
 ".RemoveBlankLinesWhereOnlyWhitespaces();
    }

    public static string SerializePropertyAsString(
        MethodParameter property)
    {
        var name = property.Location != null
            ? property.ParameterName
            : "request." + property.Name;
        if (property.Type.IsArray)
        {
            var subType = property.Type.SubTypes.First();
            var additionalConvertSubtype = subType.Unbox<TypeData>().IsEnum
                ? ".ToValueString()"
                : string.Empty;
            return $"$\"[{{string.Join(\",\", global::System.Linq.Enumerable.Select({name}, x => x{additionalConvertSubtype}))}}]\"";
        }

        var additionalConvert = property.Type.IsEnum
            ? $"{(property.IsRequired ? "" : "?")}.ToValueString()"
            : string.Empty;

        return property.Type.IsAnyOfLike
            ? $"{name}{(property.IsRequired ? "" : "?")}.ToString() ?? string.Empty"
            : $"$\"{{{name}{additionalConvert}}}\"";
    }

    public static string GeneratePathAndQuery(
        EndPoint endPoint)
    {
        var code = @$" 
            var __pathBuilder = new global::{endPoint.GlobalSettings.Namespace}.PathBuilder(
                path: {endPoint.Path},
                baseUri: HttpClient.BaseAddress);";
        if (endPoint.Authorizations.Any(x => x is { Type: SecuritySchemeType.ApiKey, In: ParameterLocation.Query }))
        {
            code += $@"
            foreach (var __authorization in Authorizations)
            {{
                if (__authorization.Type == ""{SecuritySchemeType.ApiKey:G}"" &&
                    __authorization.Location == ""{ParameterLocation.Query:G}"")
                {{
                    __pathBuilder = __pathBuilder.AddRequiredParameter(__authorization.Name, __authorization.Value);
                }}
            }}";
        }

        var queryParameters = endPoint.QueryParameters.ToArray();

        if (queryParameters.Length > 0)
        {
            code += @" 
            __pathBuilder";
        }

        foreach (var parameter in queryParameters)
        {
            var additionalArguments = parameter.Type.IsArray
                ? $", delimiter: \"{parameter.Delimiter}\", explode: {(parameter.Explode ? "true" : "false")}"
                : string.Empty;
            if (parameter.Type.IsArray && parameter.Type.SubTypes[0].Unbox<TypeData>().CSharpTypeWithoutNullability is not "string")
            {
                additionalArguments = $", selector: static x => {parameter.Selector}" + additionalArguments;
            }
            if (parameter.IsRequired)
            {
                code += $@" 
                .AddRequiredParameter(""{parameter.Id}"", {parameter.Value}{additionalArguments})";
            }
            else
            {
                code += $@" 
                .AddOptionalParameter(""{parameter.Id}"", {parameter.Value}{additionalArguments})";
            }
        }

        if (queryParameters.Length > 0)
        {
            code += @" 
                ;";
        }

        code += @" 
            var __path = __pathBuilder.ToString();";

        return code.RemoveBlankLinesWhereOnlyWhitespaces();
    }

    public static string GenerateResponse(
        EndPoint endPoint)
    {
        var jsonSerializer = endPoint.Settings.JsonSerializerType.GetSerializer();

        if (endPoint.Stream)
        {
            return $@" 
            try
            {{
                __response.EnsureSuccessStatusCode();
            }}
            catch (global::System.Net.Http.HttpRequestException __ex)
            {{
                throw new global::{endPoint.GlobalSettings.Namespace}.ApiException(
                    message: __response.ReasonPhrase ?? string.Empty,
                    innerException: __ex,
                    statusCode: __response.StatusCode)
                {{
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                }};
            }}

            using var __stream = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                cancellationToken
#endif
            ).ConfigureAwait(false);
            using var __reader = new global::System.IO.StreamReader(__stream);

            while (!__reader.EndOfStream && !cancellationToken.IsCancellationRequested)
            {{
                var __content = await __reader.ReadLineAsync().ConfigureAwait(false) ?? string.Empty;
                var __streamedResponse = {jsonSerializer.GenerateDeserializeCall("__content", endPoint.SuccessResponse.Type, endPoint.Settings.JsonSerializerContext)} ??
                                       throw new global::System.InvalidOperationException($""Response deserialization failed for \""{{__content}}\"" "");

                yield return __streamedResponse;
            }}
 ";
        }

        // If a response range is defined using an explicit code, the explicit code definition takes precedence over the range definition for that code  
        var orderedErrorResponses = endPoint.ErrorResponses
            .Where(x => x is { IsPattern: false, IsDefault: false })
            .Concat(endPoint.ErrorResponses.Where(x => x is { IsPattern: true, IsDefault: false }))
            .Concat(endPoint.ErrorResponses.Where(x => x.IsDefault))
            .ToArray();

        var errors = endPoint.Settings.GenerateExceptions ? orderedErrorResponses.Select(x => $@"
            // {x.Description.Replace('\n', ' ').Replace('\r', ' ')}
{(x.IsDefault ? @" 
            if (!__response.IsSuccessStatusCode)"
    : x.IsPattern ? $@" 
            if ((int)__response.StatusCode >= {x.Min} && (int)__response.StatusCode <= {x.Max})"
    : @$" 
            if ((int)__response.StatusCode == {x.StatusCode})")}
            {{
                string? __content_{x.StatusCode} = null;
                global::System.Exception? __exception_{x.StatusCode} = null;
{(!string.IsNullOrWhiteSpace(x.Type.CSharpTypeWithoutNullability) ? $@" 
                {x.Type.CSharpTypeWithoutNullability}? __value_{x.StatusCode} = null;" : " ")}
                try
                {{
                    if (ReadResponseAsString)
                    {{
                        __content_{x.StatusCode} = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
{(!string.IsNullOrWhiteSpace(x.Type.CSharpTypeWithoutNullability) ? $@" 
                        __value_{x.StatusCode} = {jsonSerializer.GenerateDeserializeCall($"__content_{x.StatusCode}", x.Type, endPoint.Settings.JsonSerializerContext)};" : " ")}
                    }}
                    else
                    {{
                        var __contentStream_{x.StatusCode} = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
{(!string.IsNullOrWhiteSpace(x.Type.CSharpTypeWithoutNullability) ? $@" 
                        __value_{x.StatusCode} = {jsonSerializer.GenerateDeserializeFromStreamCall($"__contentStream_{x.StatusCode}", x.Type, endPoint.Settings.JsonSerializerContext)};" : " ")}
                    }}
                }}
                catch (global::System.Exception __ex)
                {{
                    __exception_{x.StatusCode} = __ex;
                }}

{(!string.IsNullOrWhiteSpace(x.Type.CSharpTypeWithoutNullability) ? $@" 
                throw new global::{endPoint.GlobalSettings.Namespace}.ApiException<{x.Type.CSharpTypeWithNullabilityForValueTypes}>(" : $@" 
                throw new global::{endPoint.GlobalSettings.Namespace}.ApiException(")}
                    message: __content_{x.StatusCode} ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_{x.StatusCode},
                    statusCode: __response.StatusCode)
                {{
                    ResponseBody = __content_{x.StatusCode},
{(!string.IsNullOrWhiteSpace(x.Type.CSharpTypeWithoutNullability) ? $@" 
                    ResponseObject = __value_{x.StatusCode}," : " ")}
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                }};
            }}").Inject() : " ";

        return @$"{errors}

            if (ReadResponseAsString)
            {{
                var __content = await __response.Content.ReadAs{endPoint.ContentType switch
        {
            ContentType.String => "String",
            ContentType.Stream => "Stream",
            _ => "ByteArray",
        }}Async(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

{(endPoint.ContentType == ContentType.String ? @" 
                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);" : " ")}
{(!string.IsNullOrWhiteSpace(endPoint.SuccessResponse.Type.CSharpType) ? @$" 
                Process{endPoint.NotAsyncMethodName}ResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);" : " ")}

                try
                {{
                    __response.EnsureSuccessStatusCode();

{(string.IsNullOrWhiteSpace(endPoint.SuccessResponse.Type.CSharpType)
    ? " "
    : endPoint is { ContentType: ContentType.String, SuccessResponse.Type.CSharpTypeWithoutNullability: not "string" } ? $@" 
                    return
                        {jsonSerializer.GenerateDeserializeCall("__content", endPoint.SuccessResponse.Type, endPoint.Settings.JsonSerializerContext)} ??
                        throw new global::System.InvalidOperationException($""Response deserialization failed for \""{{__content}}\"" "");" : @" 
                    return __content;")}
                }}
                catch (global::System.Exception __ex)
                {{
                    throw new global::{endPoint.GlobalSettings.Namespace}.ApiException(
{(endPoint.ContentType == ContentType.String ? $@" 
                        message: __content ?? __response.ReasonPhrase ?? string.Empty," : @" 
                        message: __response.ReasonPhrase ?? string.Empty,")}
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {{
{(endPoint.ContentType == ContentType.String ? $@" 
                        ResponseBody = __content," : " ")}
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    }};
                }}
            }}
            else
            {{
                try
                {{
                    __response.EnsureSuccessStatusCode();

                    {endPoint.ContentType switch
                    {
                        ContentType.String when endPoint.SuccessResponse.Type.CSharpTypeWithoutNullability is not "string" => "using ",
                        ContentType.Stream => "using ",
                        _ => string.Empty,
                    }}var __content = await __response.Content.ReadAs{endPoint.ContentType switch
            {
                ContentType.String when endPoint.SuccessResponse.Type.CSharpTypeWithoutNullability is "string" => "String",
                ContentType.String => "Stream",
                ContentType.Stream => "Stream",
                _ => "ByteArray",
            }}Async(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

{(string.IsNullOrWhiteSpace(endPoint.SuccessResponse.Type.CSharpType)
    ? " "
    : endPoint is { ContentType: ContentType.String, SuccessResponse.Type.CSharpTypeWithoutNullability: not "string" } ? $@" 
                    return
                        {jsonSerializer.GenerateDeserializeFromStreamCall("__content", endPoint.SuccessResponse.Type, endPoint.Settings.JsonSerializerContext)} ??
                        throw new global::System.InvalidOperationException(""Response deserialization failed."");" : @" 
                    return __content;")}
                }}
                catch (global::System.Exception __ex)
                {{
                    throw new global::{endPoint.GlobalSettings.Namespace}.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {{
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    }};
                }}
            }}
 ";
    }

    public static string GenerateRequestData(
        EndPoint endPoint)
    {
        if (string.IsNullOrWhiteSpace(endPoint.RequestType.CSharpType))
        {
            return " ";
        }

        var jsonSerializer = endPoint.Settings.JsonSerializerType.GetSerializer();
        if (endPoint.IsMultipartFormData)
        {
            return $@" 
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
{endPoint.Parameters.Where(x => !x.IsMultiPartFormDataFilename).Select(x =>
{
    var add = x.Type.IsBinary ? @$" 
            __httpRequestContent.Add(
                content: new global::System.Net.Http.ByteArrayContent(request.{x.Name} ?? global::System.Array.Empty<byte>()),
                name: ""{x.Id}"",
                fileName: request.{x.Name + "name"} ?? string.Empty);
 " : @$" 
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent({SerializePropertyAsString(x)}),
                name: ""{x.Id}"");
 ";
    if (x.IsRequired)
    {
        return add;
    }

    return $@" 
            if ({(x.Location != null ? x.ParameterName : "request." + x.Name)} != {x.ParameterDefaultValue})
            {{
{add.AddIndent(1)}
            }}";
}).Inject()}
            
            __httpRequest.Content = __httpRequestContent;
 ".RemoveBlankLinesWhereOnlyWhitespaces();
        }

        var requestContent = endPoint.RequestType.IsBase64
            ? "global::System.Convert.ToBase64String(request)"
            : jsonSerializer.GenerateSerializeCall(endPoint.RequestType, endPoint.Settings.JsonSerializerContext);

        return $@" 
            var __httpRequestContentBody = {requestContent};
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: ""{endPoint.RequestMediaType}"");
            __httpRequest.Content = __httpRequestContent;
 ".RemoveBlankLinesWhereOnlyWhitespaces();
    }

    public static string GenerateExtensionMethod(
        EndPoint endPoint, bool isInterface = false)
    {
        if (string.IsNullOrWhiteSpace(endPoint.RequestType.CSharpType) ||
            endPoint.RequestType.IsArray ||
            endPoint.RequestType.IsEnum ||
            endPoint.RequestType.IsBase64 ||
            endPoint.RequestType.CSharpTypeWithoutNullability is "string")
        {
            return " ";
        }

        var taskType = endPoint.Stream
            ? string.IsNullOrWhiteSpace(endPoint.SuccessResponse.Type.CSharpType)
                ? throw new InvalidOperationException($"Streamed responses must have a response type. OperationId: {endPoint.Id}.")
                : $"global::System.Collections.Generic.IAsyncEnumerable<{endPoint.SuccessResponse.Type.CSharpTypeWithoutNullability}>"
            : string.IsNullOrWhiteSpace(endPoint.SuccessResponse.Type.CSharpType)
                ? "global::System.Threading.Tasks.Task"
                : $"global::System.Threading.Tasks.Task<{endPoint.SuccessResponse.Type.CSharpTypeWithoutNullability}>";
        var cancellationTokenAttribute = endPoint.Stream && !isInterface
            ? "[global::System.Runtime.CompilerServices.EnumeratorCancellation] "
            : string.Empty;
        var response = endPoint.Stream
            ? "var __enumerable = "
            : string.IsNullOrWhiteSpace(endPoint.SuccessResponse.Type.CSharpType)
                ? "await "
                : "return await ";
        var configureAwaitResponse = !endPoint.Stream
            ? ".ConfigureAwait(false)"
            : string.Empty;
        var body = isInterface
            ? ";"
            : @$"
        {{
            var __request = new {endPoint.RequestType.CSharpTypeWithoutNullability}
            {{
{endPoint.Parameters.Where(x => x.Location == null && (x.IsRequired || !x.IsDeprecated)).Select(x => $@"
{(x.IsDeprecated ? "#pragma warning disable CS0618 // Type or member is obsolete" : " ")}
                {(x.Name.StartsWith("request", StringComparison.Ordinal) ? x.Name.Replace("request", string.Empty) : x.Name)} = {x.ParameterName},
{(x.IsDeprecated ? "#pragma warning restore CS0618 // Type or member is obsolete" : " ")}".TrimEnd()).Inject()}
            }};

            {response}{endPoint.MethodName}(
{endPoint.Parameters.Where(x => x.Location != null).Select(x => $@"
                {x.ParameterName}: {x.ParameterName},").Inject()}
                request: __request,
                cancellationToken: cancellationToken){configureAwaitResponse};
{(endPoint.Stream ? @"
            
            await foreach (var __response in __enumerable)
            {
                yield return __response;
            }" : " ")}
        }}";

        var parameters = endPoint.Parameters
            .Where(static x => x is { IsDeprecated: false } or { IsRequired: true } or { IsDeprecated: true, Location: not null })
            .ToList();

        return $@"
        {endPoint.Summary.ToXmlDocumentationSummary(level: 8)}
{parameters.Select(x => $@"
        {x.Summary.ToXmlDocumentationForParam(x.ParameterName, level: 8)}").Inject()}
        /// <param name=""cancellationToken"">The token to cancel the operation with</param>
        /// <exception cref=""global::System.InvalidOperationException""></exception>
        {GenerateEndPointAttributes(endPoint)}
        {(isInterface ? "" : "public async ")}{taskType} {endPoint.MethodName}(
{parameters.Where(static x => x.IsRequired).Select(x => $@"
            {x.Type.CSharpType} {x.ParameterName},").Inject()}
{parameters.Where(static x => x is { IsRequired: false }).Select(x => $@"
            {x.Type.CSharpType} {x.ParameterName} = {x.ParameterDefaultValue},").Inject()}
            {cancellationTokenAttribute}global::System.Threading.CancellationToken cancellationToken = default){body}
 ".RemoveBlankLinesWhereOnlyWhitespaces();
    }

    private static string GenerateEndPointAttributes(EndPoint endPoint)
    {
        return @$" 
{(endPoint.IsDeprecated ? @" 
        [global::System.Obsolete(""This method marked as deprecated."")]" : " ")}
 
{(endPoint.Settings.UseExperimentalAttributes is
      SdkFeatureUsage.Always or
      SdkFeatureUsage.InSupportedTargetFrameworks &&
    !string.IsNullOrWhiteSpace(endPoint.ExperimentalStage)
            ? $@" 
{(endPoint.Settings.UseExperimentalAttributes is SdkFeatureUsage.InSupportedTargetFrameworks ? @" 
#if NET8_0_OR_GREATER" : " ")}
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: ""{endPoint.Settings.Namespace.Replace(".", "_").ToUpperInvariant()}_{endPoint.ExperimentalStage.ToUpperInvariant()}_001"")]
{(endPoint.Settings.UseExperimentalAttributes is SdkFeatureUsage.InSupportedTargetFrameworks ? @" 
#endif" : " ")}"
            : " ")}";
    }
}