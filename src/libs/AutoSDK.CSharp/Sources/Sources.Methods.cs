using AutoSDK.Extensions;
using AutoSDK.Helpers;
using AutoSDK.Models;
using AutoSDK.Serialization.Json;
using Microsoft.OpenApi;

namespace AutoSDK.Generation;

public static partial class Sources
{
    private static bool RequiresDeprecatedTypeWarningSuppression(EndPoint endPoint)
    {
        if (TypeUsesDeprecatedMembers(endPoint.RequestType) ||
            TypeUsesDeprecatedMembers(endPoint.SuccessResponse.Type))
        {
            return true;
        }

        for (var i = 0; i < endPoint.Parameters.Length; i++)
        {
            if (TypeUsesDeprecatedMembers(endPoint.Parameters[i].Type))
            {
                return true;
            }
        }

        for (var i = 0; i < endPoint.ErrorResponses.Length; i++)
        {
            if (TypeUsesDeprecatedMembers(endPoint.ErrorResponses[i].Type))
            {
                return true;
            }
        }

        return false;
    }

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
    endPoint.IsMultipartFormData && endPoint.Parameters.Any(x => x.IsDeprecated) ||
    RequiresDeprecatedTypeWarningSuppression(endPoint) ? @"

#pragma warning disable CS0618 // Type or member is obsolete" : "")}

namespace {endPoint.Settings.Namespace}
{{
    public partial class {endPoint.ClassName}
    {{
{(!endPoint.AuthorizationRequirements.IsEmpty ? GenerateSecurityRequirementsField(endPoint) : TrimmedLine)}
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
{(string.IsNullOrWhiteSpace(endPoint.SuccessResponse.Type.CSharpType) || endPoint.Stream ? TrimmedLine : $@"
        partial void Process{endPoint.NotAsyncMethodName}ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref {contentType} content);")}

{GenerateMethod(endPoint)}
{(ShouldGenerateResponseWrapperMethod(endPoint) ? GenerateMethod(endPoint, returnResponseWrapper: true) : TrimmedLine)}
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

        return $@"#nullable enable{(RequiresDeprecatedTypeWarningSuppression(endPoint) ? @"

#pragma warning disable CS0618 // Type or member is obsolete" : "")}

namespace {endPoint.Settings.Namespace}
{{
    public partial interface I{endPoint.ClassName}
    {{
{GenerateMethod(endPoint, isInterface: true)}
{(ShouldGenerateResponseWrapperMethod(endPoint) ? GenerateMethod(endPoint, isInterface: true, returnResponseWrapper: true) : TrimmedLine)}
{GenerateExtensionMethod(endPoint, isInterface: true)}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }

    public static string GetHttpMethod(System.Net.Http.HttpMethod operationType)
    {
        operationType = operationType ?? throw new ArgumentNullException(nameof(operationType));

        return operationType.Method.ToUpperInvariant() switch
        {
            "GET" => "global::System.Net.Http.HttpMethod.Get",
            "POST" => "global::System.Net.Http.HttpMethod.Post",
            "PUT" => "global::System.Net.Http.HttpMethod.Put",
            "DELETE" => "global::System.Net.Http.HttpMethod.Delete",
            "HEAD" => "global::System.Net.Http.HttpMethod.Head",
            "OPTIONS" => "global::System.Net.Http.HttpMethod.Options",
            "TRACE" => "global::System.Net.Http.HttpMethod.Trace",
            "PATCH" => "new global::System.Net.Http.HttpMethod(\"PATCH\")",
            _ => $"new global::System.Net.Http.HttpMethod(\"{operationType.Method}\")",
        };
    }

    private static bool IsRequestStreamParameter(MethodParameter parameter)
    {
        return parameter.Location == null &&
               string.Equals(parameter.Id, "stream", StringComparison.OrdinalIgnoreCase);
    }

    private static string GetRequestPropertyName(MethodParameter parameter)
    {
        return parameter.Name.StartsWith("request", StringComparison.Ordinal)
            ? parameter.Name.Replace("request", string.Empty)
            : parameter.Name;
    }

    private static string GetPinnedRequestPropertyValue(
        EndPoint endPoint,
        MethodParameter parameter,
        string sourceRequestExpression)
    {
        if (IsRequestStreamParameter(parameter) && endPoint.ForcedRequestStreamValue is bool forcedRequestStreamValue)
        {
            return forcedRequestStreamValue ? "true" : "false";
        }

        return $"{sourceRequestExpression}.{GetRequestPropertyName(parameter)}";
    }

    private static TypeData? GetTransparentWrappedRequestType(EndPoint endPoint)
    {
        var requestParameters = endPoint.Parameters
            .Where(static x => x.Location == null)
            .ToArray();
        var initializationTypeName = endPoint.RequestInitializationType.CSharpTypeWithoutNullability;
        var requestTypeName = endPoint.RequestType.CSharpTypeWithoutNullability;
        if (requestParameters.Length == 0 ||
            endPoint.RequestInitializationType == TypeData.Default ||
            string.IsNullOrWhiteSpace(initializationTypeName) ||
            string.Equals(initializationTypeName, requestTypeName, StringComparison.Ordinal))
        {
            return null;
        }

        return endPoint.RequestInitializationType;
    }

    private static string GenerateRequestAssignments(
        EndPoint endPoint,
        Func<MethodParameter, string> valueFactory)
    {
        return endPoint.Parameters
            .Where(x => x.Location == null && (x.IsRequired || !x.IsDeprecated))
            .Select(x => $@"
{(x.IsDeprecated ? "#pragma warning disable CS0618 // Type or member is obsolete" : TrimmedLine)}
                {GetRequestPropertyName(x)} = {valueFactory(x)},
{(x.IsDeprecated ? "#pragma warning restore CS0618 // Type or member is obsolete" : TrimmedLine)}".TrimEnd())
            .Inject();
    }

    private static string GenerateRequestInitialization(
        EndPoint endPoint,
        string targetVariableName,
        Func<MethodParameter, string> valueFactory,
        bool declareVariable = true)
    {
        var targetPrefix = declareVariable ? $"var {targetVariableName}" : targetVariableName;
        var assignments = GenerateRequestAssignments(endPoint, valueFactory);
        var wrappedRequestType = GetTransparentWrappedRequestType(endPoint);
        if (wrappedRequestType is not TypeData nestedRequestType)
        {
            return @$"
            {targetPrefix} = new {endPoint.RequestType.CSharpTypeWithoutNullability}
            {{
{assignments}
            }};".TrimStart('\r', '\n');
        }

        return @$"
            {targetPrefix} = new {endPoint.RequestType.CSharpTypeWithoutNullability}(
                new {nestedRequestType.CSharpTypeWithoutNullability}
                {{
{assignments}
                }});".TrimStart('\r', '\n');
    }

    private static string GeneratePinnedRequestCopy(EndPoint endPoint, string sourceRequestExpression)
    {
        if (endPoint.ForcedRequestStreamValue is null)
        {
            return TrimmedLine;
        }

        var requestParameters = endPoint.Parameters
            .Where(static x => x.Location == null)
            .ToArray();
        if (!requestParameters.Any(IsRequestStreamParameter))
        {
            return TrimmedLine;
        }

        var wrappedRequestType = GetTransparentWrappedRequestType(endPoint);
        var requestSourceExpression = wrappedRequestType is null
            ? sourceRequestExpression
            : $"(({wrappedRequestType.Value.CSharpTypeWithoutNullability}?)({sourceRequestExpression}))!";

        return GenerateRequestInitialization(
            endPoint,
            "request",
            x => GetPinnedRequestPropertyValue(endPoint, x, requestSourceExpression),
            declareVariable: false)
            .RemoveBlankLinesWhereOnlyWhitespaces();
    }

    private static IEnumerable<MethodParameter> GetExtensionMethodParameters(EndPoint endPoint)
    {
        return endPoint.Parameters
            .Where(static x => x is { IsDeprecated: false } or { IsRequired: true } or { IsDeprecated: true, Location: not null })
            .Where(x => !(endPoint.ForcedRequestStreamValue is not null && IsRequestStreamParameter(x)));
    }

    private static bool ShouldGenerateResponseWrapperMethod(EndPoint endPoint)
    {
        return endPoint.GenerateResponseWrapper && !endPoint.EnumerableStream;
    }

    private static string GetResponseWrapperMethodName(EndPoint endPoint)
    {
        return $"{endPoint.NotAsyncMethodName}AsResponseAsync";
    }

    private static string GetSuccessResponseBodyType(EndPoint endPoint)
    {
        if (string.IsNullOrWhiteSpace(endPoint.SuccessResponse.Type.CSharpType))
        {
            return string.Empty;
        }

        return endPoint.RawStream
            ? "global::System.IO.Stream"
            : endPoint.SuccessResponse.Type.CSharpTypeWithoutNullability;
    }

    private static string GetResponseWrapperType(EndPoint endPoint)
    {
        var bodyType = GetSuccessResponseBodyType(endPoint);
        return string.IsNullOrWhiteSpace(bodyType)
            ? $"global::{endPoint.Settings.Namespace}.AutoSDKHttpResponse"
            : $"global::{endPoint.Settings.Namespace}.AutoSDKHttpResponse<{bodyType}>";
    }

    private static string GenerateMethodInvocationArguments(EndPoint endPoint)
    {
        return $@"{endPoint.Parameters.Where(x => x is { Location: not null, IsRequired: true } && !x.HasSchemaDefault).Select(x => $@"
                {x.ParameterName}: {x.ParameterName},").Inject()}
{(string.IsNullOrWhiteSpace(endPoint.RequestType.CSharpType) ? TrimmedLine : @"
                request: request,")}
{endPoint.Parameters.Where(x => x is { Location: not null } && (!x.IsRequired || x.HasSchemaDefault)).Select(x => $@"
                {x.ParameterName}: {x.ParameterName},").Inject()}
                cancellationToken: cancellationToken".RemoveBlankLinesWhereOnlyWhitespaces();
    }

    public static string GenerateMethod(
        EndPoint endPoint, bool isInterface = false, bool returnResponseWrapper = false)
    {
        var hasOAuth2Authorization = endPoint.Authorizations.Any(static x => x.Type is SecuritySchemeType.OAuth2);
        var rootClassName = endPoint.Settings.ClassName.Replace(".", string.Empty);
        var completionOption = $"global::System.Net.Http.HttpCompletionOption.{(endPoint.Stream
            ? nameof(HttpCompletionOption.ResponseHeadersRead)
            : nameof(HttpCompletionOption.ResponseContentRead))}";
        var sendExpression = hasOAuth2Authorization
            ? $@"global::{endPoint.Settings.Namespace}.{rootClassName}.AutoSDKOAuth2Helpers.SendAsync(
                httpClient: HttpClient,
                request: __httpRequest,
                completionOption: {completionOption},
                authorizations: __authorizations,
                oAuth2Coordinator: AutoSDKOAuth2State,
                cancellationToken: cancellationToken)"
            : $@"HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: {completionOption},
                cancellationToken: cancellationToken)";
        var taskType = returnResponseWrapper
            ? $"global::System.Threading.Tasks.Task<{GetResponseWrapperType(endPoint)}>"
            : endPoint.RawStream
            ? "global::System.Threading.Tasks.Task<global::System.IO.Stream>"
            : endPoint.EnumerableStream
            ? string.IsNullOrWhiteSpace(endPoint.SuccessResponse.Type.CSharpType)
                ? throw new InvalidOperationException($"Streamed responses must have a response type. OperationId: {endPoint.Id}.")
                : $"global::System.Collections.Generic.IAsyncEnumerable<{endPoint.SuccessResponse.Type.CSharpTypeWithoutNullability}>"
            : string.IsNullOrWhiteSpace(endPoint.SuccessResponse.Type.CSharpType)
                ? "global::System.Threading.Tasks.Task"
                : $"global::System.Threading.Tasks.Task<{endPoint.SuccessResponse.Type.CSharpTypeWithoutNullability}>";
        var methodName = returnResponseWrapper
            ? GetResponseWrapperMethodName(endPoint)
            : endPoint.MethodName;
        var cancellationTokenAttribute = endPoint.EnumerableStream && !isInterface
            ? "[global::System.Runtime.CompilerServices.EnumeratorCancellation] "
            : string.Empty;
        var body = isInterface
            ? ";"
            : !returnResponseWrapper && ShouldGenerateResponseWrapperMethod(endPoint)
            ? string.IsNullOrWhiteSpace(endPoint.SuccessResponse.Type.CSharpType)
                ? @$"
        {{
            await {GetResponseWrapperMethodName(endPoint)}(
{GenerateMethodInvocationArguments(endPoint)}
            ).ConfigureAwait(false);
        }}"
                : @$"
        {{
            var __response = await {GetResponseWrapperMethodName(endPoint)}(
{GenerateMethodInvocationArguments(endPoint)}
            ).ConfigureAwait(false);

            return __response.Body;
        }}"
            : @$"
        {{
{(string.IsNullOrWhiteSpace(endPoint.RequestType.CSharpType) || endPoint.RequestType.IsAnyOfLike ? TrimmedLine : @" 
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));
")}
{(string.IsNullOrWhiteSpace(endPoint.RequestType.CSharpType) || endPoint.RequestType.IsAnyOfLike ? TrimmedLine : GeneratePinnedRequestCopy(endPoint, "request"))}
            PrepareArguments(
                client: HttpClient);
            Prepare{endPoint.NotAsyncMethodName}Arguments(
                httpClient: HttpClient{endPoint.Parameters
                    .Where(x => x.Location != null)
                    .Select(x => $@",
                {x.ParameterName}: {(x.Type.IsReferenceable ? "ref " : "")}{x.ParameterName}").Inject(emptyValue: "")}{(string.IsNullOrWhiteSpace(endPoint.RequestType.CSharpType) ? "" : @",
                request: request")});
{(!endPoint.AuthorizationRequirements.IsEmpty ? $@"

            var __authorizations = global::{endPoint.GlobalSettings.Namespace}.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_{endPoint.NotAsyncMethodName}SecurityRequirements,
                operationName: ""{endPoint.MethodName}"");" : TrimmedLine)}

{(endPoint.Settings.UsesNewtonsoftJson() ? endPoint.Parameters
    .Where(x => x is { Location: not null, Type.IsEnum: true, Type.IsAnyOfLike: false, Type.EnumValues.Length: > 0 })
    .Select(x => $@"
            var {x.ArgumentName} = {x.ParameterName} switch
            {{
{x.Type.Properties.Zip(x.Type.EnumValues, (property, value) => (Property: property, Value: value))
    .Select(y => string.IsNullOrWhiteSpace(y.Property) ? @"
                null => string.Empty," : $@"
                {x.Type.CSharpTypeWithoutNullability}.{y.Property} => ""{y.Value}"",").Inject()}
                _ => throw new global::System.NotImplementedException(""Enum value not implemented.""),
            }};").Inject() : TrimmedLine)}
{GeneratePathAndQuery(endPoint, authorizationVariableName: endPoint.AuthorizationRequirements.IsEmpty ? "Authorizations" : "__authorizations")}
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: {GetHttpMethod(endPoint.HttpMethod)},
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
{           // Use HTTP/3.0 or HTTP/2.0 if available
            // https://learn.microsoft.com/en-us/dotnet/core/extensions/httpclient-http3#httpclient-settings
    TrimmedLine}
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
{(endPoint.Authorizations.Any(x => x is
    { Type: SecuritySchemeType.ApiKey, In: ParameterLocation.Header } or
    { Type: SecuritySchemeType.Http } or
    { Type: SecuritySchemeType.OAuth2 }) ? @$"
            foreach (var __authorization in {(endPoint.AuthorizationRequirements.IsEmpty ? "Authorizations" : "__authorizations")})
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
            }}" : TrimmedLine)}
{(endPoint.Parameters.Any(x => x is { Location: ParameterLocation.Header }) ? "" : TrimmedLine)}
{endPoint.Parameters
    .Where(x => x is { Location: ParameterLocation.Header, IsRequired: true })
    .Select(x => $@"
            __httpRequest.Headers.TryAddWithoutValidation(""{x.Id}"", {x.ParameterName}{(x.Type.IsEnum && !x.Type.IsAnyOfLike ? ".ToValueString()" : ".ToString()")});").Inject()}
{endPoint.Parameters
    .Where(x => x is { Location: ParameterLocation.Header, IsRequired: false })
    .Select(x => $@"
            if ({x.ParameterName} != default)
            {{
                __httpRequest.Headers.TryAddWithoutValidation(""{x.Id}"", {x.ParameterName}{(x.Type.IsEnum && !x.Type.IsAnyOfLike ? "?.ToValueString() ?? string.Empty" : ".ToString()")});
            }}").Inject()}
{(endPoint.Parameters.Any(x => x is { Location: ParameterLocation.Header }) ? "" : TrimmedLine)}
{GenerateCookieParameterHandling(endPoint)}
 
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

            {(endPoint.RawStream ? "" : "using ")}var __response = await {sendExpression}.ConfigureAwait(false);
{(endPoint.RawStream ? @"
            try
            {" : TrimmedLine)}

            ProcessResponse(
                client: HttpClient,
                response: __response);
            Process{endPoint.NotAsyncMethodName}Response(
                httpClient: HttpClient,
                httpResponseMessage: __response);
{GenerateResponse(endPoint, wrapSuccessResponse: returnResponseWrapper)}
{(endPoint.RawStream ? @"
            }
            catch
            {
                __response.Dispose();
                throw;
            }" : TrimmedLine)}
        }}";

        return $@" 
        {endPoint.Summary.ToXmlDocumentationSummary(level: 8)}
{endPoint.Parameters.Where(x => x.Location != null).Select(x => $@"
        {x.Summary.ToXmlDocumentationForParam(x.ParameterName, level: 8)}").Inject()}
{(string.IsNullOrWhiteSpace(endPoint.RequestType.CSharpType) ? TrimmedLine : @" 
        /// <param name=""request""></param>")}
        /// <param name=""cancellationToken"">The token to cancel the operation with</param>
        /// <exception cref=""global::{endPoint.Settings.Namespace}.ApiException""></exception>{(string.IsNullOrWhiteSpace(endPoint.Remarks) ? "" : $@"
        {endPoint.Remarks.ToXmlDocumentationRemarks(level: 8)}")}
        {GenerateEndPointAttributes(endPoint)}
        {(isInterface ? "" : "public async ")}{taskType} {methodName}(
{endPoint.Parameters.Where(x => x is { Location: not null, IsRequired: true } && !x.HasSchemaDefault).Select(x => $@"
            {x.Type.CSharpType} {x.ParameterName},").Inject()}
{(string.IsNullOrWhiteSpace(endPoint.RequestType.CSharpType) ? TrimmedLine : @$"
            {endPoint.RequestType.CSharpTypeWithoutNullability} request,")}
{endPoint.Parameters.Where(x => x is { Location: not null } && (!x.IsRequired || x.HasSchemaDefault)).Select(x => $@"
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
            ? $"{(property.Type.CSharpTypeNullability ? "?" : "")}.ToValueString()"
            : string.Empty;

        return property.Type.IsAnyOfLike
            ? $"{name}{(property.Type.CSharpTypeNullability ? "?" : "")}.ToString() ?? string.Empty"
            : $"$\"{{{name}{additionalConvert}}}\"";
    }

    private static string GenerateCookieParameterHandling(
        EndPoint endPoint)
    {
        var cookieParameters = endPoint.Parameters
            .Where(x => x.Location == ParameterLocation.Cookie)
            .ToArray();
        if (cookieParameters.Length == 0)
        {
            return TrimmedLine;
        }

        var builder = new System.Text.StringBuilder();
        builder.AppendLine("            var __cookies = new global::System.Collections.Generic.List<string>();");
        foreach (var parameter in cookieParameters)
        {
            builder.AppendLine(GenerateCookieParameterHandling(parameter, endPoint.Settings));
        }

        builder.AppendLine(@"            if (__cookies.Count > 0)
            {
                __httpRequest.Headers.TryAddWithoutValidation(""Cookie"", string.Join(""; "", __cookies));
            }");

        return builder.ToString().RemoveBlankLinesWhereOnlyWhitespaces();
    }

    private static string GenerateCookieParameterHandling(
        MethodParameter parameter,
        Settings settings)
    {
        if (parameter.Properties.Length > 0)
        {
            var builder = new System.Text.StringBuilder();
            foreach (var property in parameter.Properties)
            {
                builder.AppendLine(GeneratePropertySegmentAppendStatements(
                    collectionName: "__cookies",
                    segmentName: property.Id,
                    accessExpression: GetParameterPropertyAccessExpression(parameter, property),
                    type: property.Type,
                    isNullableLike: IsParameterPropertyNullableLike(parameter, property),
                    urlEncode: false,
                    localNamePrefix: $"{parameter.ParameterName}_{property.Name}",
                    settings: settings));
            }

            return builder.ToString().RemoveBlankLinesWhereOnlyWhitespaces();
        }

        return GenerateSegmentAppendStatements(
            collectionName: "__cookies",
            segmentName: parameter.Id,
            accessExpression: parameter.ParameterName,
            type: parameter.Type,
            isNullableLike: IsNullableLike(parameter.Type),
            urlEncode: false,
            localNamePrefix: parameter.ParameterName,
            settings: settings);
    }

    private static string GenerateQueryStringParameterHandling(
        EndPoint endPoint)
    {
        var queryStringParameters = endPoint.Parameters
            .Where(x => x.Location == ParameterLocation.QueryString)
            .ToArray();
        if (queryStringParameters.Length == 0)
        {
            return TrimmedLine;
        }

        var builder = new System.Text.StringBuilder();
        foreach (var parameter in queryStringParameters)
        {
            builder.AppendLine(GenerateQueryStringParameterHandling(endPoint, parameter));
        }

        return builder.ToString().RemoveBlankLinesWhereOnlyWhitespaces();
    }

    private static string GenerateQueryStringParameterHandling(
        EndPoint endPoint,
        MethodParameter parameter)
    {
        if (string.Equals(parameter.ContentType, "application/x-www-form-urlencoded", StringComparison.OrdinalIgnoreCase) &&
            parameter.Properties.Length > 0)
        {
            var segmentsVariableName = $"__queryStringSegments_{parameter.ParameterName}";
            var builder = new System.Text.StringBuilder();
            builder.AppendLine("            var " + segmentsVariableName + " = new global::System.Collections.Generic.List<string>();");
            foreach (var property in parameter.Properties)
            {
                builder.AppendLine(GeneratePropertySegmentAppendStatements(
                    collectionName: segmentsVariableName,
                    segmentName: property.Id,
                    accessExpression: GetParameterPropertyAccessExpression(parameter, property),
                    type: property.Type,
                    isNullableLike: IsParameterPropertyNullableLike(parameter, property),
                    urlEncode: true,
                    localNamePrefix: $"{parameter.ParameterName}_{property.Name}",
                    settings: endPoint.Settings));
            }

            builder.AppendLine(
                "            if (" + segmentsVariableName + @".Count > 0)
            {
                __pathBuilder = __pathBuilder.AddRawQueryString(string.Join(""&"", " + segmentsVariableName + @"));
            }");

            return builder.ToString().RemoveBlankLinesWhereOnlyWhitespaces();
        }

        var serializedValueExpression = GenerateStandaloneQueryStringValueExpression(endPoint, parameter);
        var code = $@"            var __queryStringValue_{parameter.ParameterName} = {serializedValueExpression};
            if (!string.IsNullOrWhiteSpace(__queryStringValue_{parameter.ParameterName}))
            {{
                __pathBuilder = __pathBuilder.AddRawQueryString(__queryStringValue_{parameter.ParameterName});
            }}";

        if (!IsNullableLike(parameter.Type))
        {
            return code.RemoveBlankLinesWhereOnlyWhitespaces();
        }

        return $@"            if ({parameter.ParameterName} is not null)
            {{
{code.AddIndent(1)}
            }}".RemoveBlankLinesWhereOnlyWhitespaces();
    }

    private static string GenerateStandaloneQueryStringValueExpression(
        EndPoint endPoint,
        MethodParameter parameter)
    {
        if (parameter.Type.CSharpTypeWithoutNullability == "string")
        {
            return string.Equals(parameter.ContentType, "application/x-www-form-urlencoded", StringComparison.OrdinalIgnoreCase)
                ? parameter.ParameterName
                : $"global::System.Uri.EscapeDataString({parameter.ParameterName})";
        }

        if (string.Equals(parameter.ContentType, "application/x-www-form-urlencoded", StringComparison.OrdinalIgnoreCase))
        {
            return GenerateSerializedValueExpression(
                type: parameter.Type,
                expression: parameter.ParameterName,
                isNullableLike: IsNullableLike(parameter.Type),
                settings: endPoint.Settings);
        }

        return $"global::System.Uri.EscapeDataString({GenerateJsonSerializeExpression(endPoint, parameter)})";
    }

    private static string GenerateJsonSerializeExpression(
        EndPoint endPoint,
        MethodParameter parameter)
    {
        return GenerateJsonSerializeExpression(
            type: parameter.Type,
            valueExpression: parameter.ParameterName,
            settings: endPoint.Settings);
    }

    private static string GenerateJsonSerializeExpression(
        TypeData type,
        string valueExpression,
        Settings settings)
    {
        if (!settings.UsesSystemTextJson())
        {
            return type.UsesGeneratedJsonHelpers
                ? $"{valueExpression}.ToJson(JsonSerializerOptions)"
                : $"global::Newtonsoft.Json.JsonConvert.SerializeObject({valueExpression}, JsonSerializerOptions)";
        }

        if (type.UsesGeneratedJsonHelpers)
        {
            return settings.HasJsonSerializerContext()
                ? $"{valueExpression}.ToJson(JsonSerializerContext)"
                : $"{valueExpression}.ToJson(JsonSerializerOptions)";
        }

        return settings.HasJsonSerializerContext()
            ? $"global::System.Text.Json.JsonSerializer.Serialize({valueExpression}, {valueExpression}.GetType(), JsonSerializerContext)"
            : $"global::System.Text.Json.JsonSerializer.Serialize({valueExpression}, JsonSerializerOptions)";
    }

    private static string GeneratePropertySegmentAppendStatements(
        string collectionName,
        string segmentName,
        string accessExpression,
        TypeData type,
        bool isNullableLike,
        bool urlEncode,
        string localNamePrefix,
        Settings settings)
    {
        return GenerateSegmentAppendStatements(
            collectionName: collectionName,
            segmentName: segmentName,
            accessExpression: accessExpression,
            type: type,
            isNullableLike: isNullableLike,
            urlEncode: urlEncode,
            localNamePrefix: localNamePrefix,
            settings: settings);
    }

    private static string GenerateSegmentAppendStatements(
        string collectionName,
        string segmentName,
        string accessExpression,
        TypeData type,
        bool isNullableLike,
        bool urlEncode,
        string localNamePrefix,
        Settings settings)
    {
        if (type.IsArray &&
            !type.SubTypes.IsEmpty)
        {
            var itemType = type.SubTypes[0].Unbox<TypeData>();
            var collectionVariableName = $"__{localNamePrefix}";
            var itemVariableName = $"{collectionVariableName}_item";
            var appendExpression = CreateSegmentAppendExpression(
                collectionName: collectionName,
                segmentName: segmentName,
                valueExpression: GenerateSerializedValueExpression(
                    type: itemType,
                    expression: itemVariableName,
                    isNullableLike: IsNullableLike(itemType),
                    settings: settings),
                urlEncode: urlEncode);

            var body = $@"foreach (var {itemVariableName} in {collectionVariableName})
                {{
                    {appendExpression};
                }}";
            if (!isNullableLike)
            {
                return $@"            var {collectionVariableName} = {accessExpression};
            {body}".RemoveBlankLinesWhereOnlyWhitespaces();
            }

            return $@"            var {collectionVariableName} = {accessExpression};
            if ({collectionVariableName} is not null)
            {{
{body.AddIndent(1)}
            }}".RemoveBlankLinesWhereOnlyWhitespaces();
        }

        var localVariableName = $"__{localNamePrefix}";
        var appendValueExpression = GenerateSerializedValueExpression(
            type: type,
            expression: localVariableName,
            isNullableLike: isNullableLike,
            settings: settings);
        var appendStatement = CreateSegmentAppendExpression(
            collectionName: collectionName,
            segmentName: segmentName,
            valueExpression: appendValueExpression,
            urlEncode: urlEncode);
        if (!isNullableLike)
        {
            return $@"            var {localVariableName} = {accessExpression};
            {appendStatement};".RemoveBlankLinesWhereOnlyWhitespaces();
        }

        return $@"            var {localVariableName} = {accessExpression};
            if ({localVariableName} is not null)
            {{
                {appendStatement};
            }}".RemoveBlankLinesWhereOnlyWhitespaces();
    }

    private static string CreateSegmentAppendExpression(
        string collectionName,
        string segmentName,
        string valueExpression,
        bool urlEncode)
    {
        segmentName = segmentName.Replace("\"", "\\\"");

        return urlEncode
            ? $"{collectionName}.Add(\"{segmentName}=\" + global::System.Uri.EscapeDataString({valueExpression}))"
            : $"{collectionName}.Add($\"{segmentName}={{{valueExpression}}}\")";
    }

    private static string GetParameterPropertyAccessExpression(
        MethodParameter parameter,
        PropertyData property)
    {
        return parameter.Type.CSharpTypeNullability
            ? $"{parameter.ParameterName}?.{property.Name}"
            : $"{parameter.ParameterName}.{property.Name}";
    }

    private static bool IsParameterPropertyNullableLike(
        MethodParameter parameter,
        PropertyData property)
    {
        var isLiftedNullable =
            parameter.Type.CSharpTypeNullability &&
            property.Type.IsValueType &&
            !property.Type.CSharpTypeNullability;

        return IsNullableLike(property.Type, isLiftedNullable);
    }

    private static bool IsNullableLike(
        TypeData type,
        bool liftedNullable = false)
    {
        return !type.IsValueType ||
               type.CSharpTypeNullability ||
               liftedNullable;
    }

    private static string GenerateSerializedValueExpression(
        TypeData type,
        string expression,
        bool isNullableLike,
        Settings settings)
    {
        if (type.CSharpTypeWithoutNullability == "string")
        {
            return isNullableLike
                ? $"{expression}.ToString() ?? string.Empty"
                : expression;
        }

        if (type.IsEnum &&
            !type.IsAnyOfLike)
        {
            var enumExpression = isNullableLike && type.IsValueType
                ? $"{expression}.Value"
                : expression;
            return $"{enumExpression}.ToValueString()";
        }

        if (type.IsAnyOfLike)
        {
            return $"{expression}.ToString() ?? string.Empty";
        }

        if (type.IsDate)
        {
            var dateExpression = isNullableLike && type.IsValueType
                ? $"{expression}.Value"
                : expression;
            return $"{dateExpression}.ToString(\"yyyy-MM-dd\")";
        }

        if (type.IsDateTime)
        {
            var dateTimeExpression = isNullableLike && type.IsValueType
                ? $"{expression}.Value"
                : expression;
            return $"{dateTimeExpression}.ToString(\"yyyy-MM-ddTHH:mm:ssZ\")";
        }

        if (type.CSharpTypeWithoutNullability == "bool")
        {
            var boolExpression = isNullableLike && type.IsValueType
                ? $"{expression}.Value"
                : expression;
            return $"{boolExpression}.ToString().ToLowerInvariant()";
        }

        if (type.Properties.Length > 0)
        {
            return GenerateJsonSerializeExpression(type, expression, settings);
        }

        return $"{expression}.ToString() ?? string.Empty";
    }

    public static string GeneratePathAndQuery(
        EndPoint endPoint,
        string authorizationVariableName = "Authorizations")
    {
        var code = @$" 
            var __pathBuilder = new global::{endPoint.GlobalSettings.Namespace}.PathBuilder(
                path: {endPoint.Path},
                baseUri: HttpClient.BaseAddress);";
        if (endPoint.Authorizations.Any(x => x is { Type: SecuritySchemeType.ApiKey, In: ParameterLocation.Query }))
        {
            code += $@"
            foreach (var __authorization in {authorizationVariableName})
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
            // Use AddOptionalParameter for nullable types even if required (required + nullable = value can be null)
            if (parameter.IsRequired && !parameter.Type.IsNullable)
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

        code += "\n" + GenerateQueryStringParameterHandling(endPoint);

        code += @" 
            var __path = __pathBuilder.ToString();";

        return code.RemoveBlankLinesWhereOnlyWhitespaces();
    }

    private static string GetSuccessResponseHeadersExpression(EndPoint endPoint)
    {
        return $"global::{endPoint.Settings.Namespace}.AutoSDKHttpResponse.CreateHeaders(__response)";
    }

    private static string GenerateSuccessResponseReturn(
        EndPoint endPoint,
        string bodyExpression,
        bool wrapSuccessResponse)
    {
        if (!wrapSuccessResponse)
        {
            return $"return {bodyExpression};";
        }

        return $@"return new global::{endPoint.Settings.Namespace}.AutoSDKHttpResponse<{GetSuccessResponseBodyType(endPoint)}>(
                        statusCode: __response.StatusCode,
                        headers: {GetSuccessResponseHeadersExpression(endPoint)},
                        body: {bodyExpression});";
    }

    private static string GenerateSuccessResponseReturnWithoutBody(
        EndPoint endPoint,
        bool wrapSuccessResponse)
    {
        if (!wrapSuccessResponse)
        {
            return TrimmedLine;
        }

        return $@"return new global::{endPoint.Settings.Namespace}.AutoSDKHttpResponse(
                        statusCode: __response.StatusCode,
                        headers: {GetSuccessResponseHeadersExpression(endPoint)});";
    }

    private static bool IsJsonMediaType(string mediaType)
    {
        return mediaType.IsJsonMimeType() &&
               !mediaType.IsSequentialJsonMimeType();
    }

    private static bool ShouldUseSystemNetHttpJsonForRequest(EndPoint endPoint)
    {
        return endPoint.Settings.GenerateMethodsUsingSystemNetHttpJson &&
               endPoint.Settings.UsesSystemTextJson() &&
               IsJsonMediaType(endPoint.RequestMediaType) &&
               !endPoint.IsMultipartFormData &&
               !endPoint.RequestType.IsBinary &&
               !endPoint.RequestType.IsBase64;
    }

    private static bool ShouldUseSystemNetHttpJsonForSuccessResponse(EndPoint endPoint)
    {
        return endPoint.Settings.GenerateMethodsUsingSystemNetHttpJson &&
               endPoint.Settings.UsesSystemTextJson() &&
               endPoint.ContentType == ContentType.String &&
               endPoint.SuccessResponse.Type.CSharpTypeWithoutNullability is not "string" &&
               IsJsonMediaType(endPoint.SuccessResponse.MimeType) &&
               !endPoint.SuccessResponse.Type.UsesGeneratedJsonHelpers;
    }

    private static string GenerateSystemNetHttpJsonRequestData(
        EndPoint endPoint)
    {
        if (endPoint.Settings.HasJsonSerializerContext())
        {
            return $@" 
            var __httpRequestContent = global::{endPoint.Settings.Namespace}.AutoSdkPolyfills.CreateJsonContent(
                inputValue: request,
                inputType: request.GetType(),
                mediaType: ""{endPoint.RequestMediaType}"",
                jsonSerializerContext: JsonSerializerContext);
            __httpRequest.Content = __httpRequestContent;
 ".RemoveBlankLinesWhereOnlyWhitespaces();
        }

        return $@" 
            var __httpRequestContent = global::{endPoint.Settings.Namespace}.AutoSdkPolyfills.CreateJsonContent(
                inputValue: request,
                mediaType: ""{endPoint.RequestMediaType}"",
                jsonSerializerOptions: JsonSerializerOptions);
            __httpRequest.Content = __httpRequestContent;
 ".RemoveBlankLinesWhereOnlyWhitespaces();
    }

    private static string GenerateSystemNetHttpJsonReadCall(
        EndPoint endPoint)
    {
        var type = endPoint.SuccessResponse.Type.CSharpTypeWithNullabilityForValueTypes;

        if (endPoint.Settings.HasJsonSerializerContext())
        {
            return $"await global::{endPoint.Settings.Namespace}.AutoSdkPolyfills.ReadFromJsonAsync<{type}>(__response.Content, JsonSerializerContext, cancellationToken).ConfigureAwait(false)";
        }

        return $"await global::{endPoint.Settings.Namespace}.AutoSdkPolyfills.ReadFromJsonAsync<{type}>(__response.Content, JsonSerializerOptions, cancellationToken).ConfigureAwait(false)";
    }

    private static string GenerateUnbufferedSuccessResponseHandling(
        EndPoint endPoint,
        bool wrapSuccessResponse)
    {
        var jsonSerializer = endPoint.Settings.JsonSerializerType.GetSerializer();

        if (string.IsNullOrWhiteSpace(endPoint.SuccessResponse.Type.CSharpType))
        {
            var response = GenerateSuccessResponseReturnWithoutBody(endPoint, wrapSuccessResponse);
            return string.IsNullOrWhiteSpace(response)
                ? response
                : $@" 
                    {response}";
        }

        if (endPoint.ContentType == ContentType.String &&
            endPoint.SuccessResponse.Type.CSharpTypeWithoutNullability is not "string")
        {
            if (ShouldUseSystemNetHttpJsonForSuccessResponse(endPoint))
            {
                var readCall = GenerateSystemNetHttpJsonReadCall(endPoint);

                return wrapSuccessResponse
                    ? $@" 
                    var __value = {readCall} ??
                        throw new global::System.InvalidOperationException(""Response deserialization failed."");
                    {GenerateSuccessResponseReturn(endPoint, "__value", wrapSuccessResponse)}"
                    : $@" 
                    return
                        {readCall} ??
                        throw new global::System.InvalidOperationException(""Response deserialization failed."");";
            }

            return wrapSuccessResponse
                ? $@" 
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    var __value = {jsonSerializer.GenerateDeserializeFromStreamCall("__content", endPoint.SuccessResponse.Type, endPoint.Settings.JsonSerializerContext)} ??
                        throw new global::System.InvalidOperationException(""Response deserialization failed."");
                    {GenerateSuccessResponseReturn(endPoint, "__value", wrapSuccessResponse)}"
                : $@" 
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        {jsonSerializer.GenerateDeserializeFromStreamCall("__content", endPoint.SuccessResponse.Type, endPoint.Settings.JsonSerializerContext)} ??
                        throw new global::System.InvalidOperationException(""Response deserialization failed."");";
        }

        return $@" 
                    {endPoint.ContentType switch
        {
            ContentType.Stream => "using ",
            _ => string.Empty,
        }}var __content = await __response.Content.ReadAs{endPoint.ContentType switch
        {
            ContentType.String => "String",
            ContentType.Stream => "Stream",
            _ => "ByteArray",
        }}Async(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    {GenerateSuccessResponseReturn(endPoint, "__content", wrapSuccessResponse)}";
    }

    public static string GenerateResponse(
        EndPoint endPoint,
        bool wrapSuccessResponse = false)
    {
        var jsonSerializer = endPoint.Settings.JsonSerializerType.GetSerializer();

        if (endPoint.StreamFormat == StreamFormat.ServerSentEvents)
        {
            return $@"
            try
            {{
                __response.EnsureSuccessStatusCode();
            }}
            catch (global::System.Net.Http.HttpRequestException __ex)
            {{
                string? __content = null;
                try
                {{
                    __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);
                }}
                catch (global::System.Exception)
                {{
                }}

                throw new global::{endPoint.GlobalSettings.Namespace}.ApiException(
                    message: __content ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __ex,
                    statusCode: __response.StatusCode)
                {{
                    ResponseBody = __content,
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

            await foreach (var __sseEvent in global::System.Net.ServerSentEvents.SseParser
                .Create(__stream).EnumerateAsync(cancellationToken))
            {{
                var __content = __sseEvent.Data;
{(!string.IsNullOrEmpty(endPoint.StreamTerminator)
    ? $@"                if (__content == ""{endPoint.StreamTerminator.Replace("\"", "\\\"")}"")
                {{
                    yield break;
                }}"
    : TrimmedLine)}

                var __streamedResponse = {jsonSerializer.GenerateDeserializeCall("__content", endPoint.SuccessResponse.Type, endPoint.Settings.JsonSerializerContext)} ??
                                       throw new global::{endPoint.GlobalSettings.Namespace}.ApiException(
                                           message: $""Response deserialization failed for \""{{__content}}\"" "",
                                           statusCode: __response.StatusCode)
                                       {{
                                           ResponseBody = __content,
                                           ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                               __response.Headers,
                                               h => h.Key,
                                               h => h.Value),
                                       }};

                yield return __streamedResponse;
            }}
 ";
        }

        if (endPoint.StreamFormat == StreamFormat.Ndjson)
        {
            var isJsonSequence = endPoint.SuccessResponse.MimeType.IsMimeType("application/json-seq");
            var streamReadLoop = isJsonSequence
                ? $@"
            using var __reader = new global::System.IO.StreamReader(__stream);
            var __contentBuilder = new global::System.Text.StringBuilder();
            var __characterBuffer = new char[1];

            while (!cancellationToken.IsCancellationRequested)
            {{
                var __read = await __reader.ReadAsync(__characterBuffer, 0, 1).ConfigureAwait(false);
                if (__read == 0)
                {{
                    break;
                }}

                var __character = __characterBuffer[0];
                if (__character == '\u001e')
                {{
                    if (__contentBuilder.Length > 0)
                    {{
                        var __content = __contentBuilder.ToString().Trim();
                        __contentBuilder.Clear();
                        if (global::System.String.IsNullOrWhiteSpace(__content))
                        {{
                            continue;
                        }}

                        var __streamedResponse = {jsonSerializer.GenerateDeserializeCall("__content", endPoint.SuccessResponse.Type, endPoint.Settings.JsonSerializerContext)} ??
                                               throw new global::{endPoint.GlobalSettings.Namespace}.ApiException(
                                                   message: $""Response deserialization failed for \""{{__content}}\"" "",
                                                   statusCode: __response.StatusCode)
                                               {{
                                                   ResponseBody = __content,
                                                   ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                                       __response.Headers,
                                                       h => h.Key,
                                                       h => h.Value),
                                               }};

                        yield return __streamedResponse;
                    }}

                    continue;
                }}

                __contentBuilder.Append(__character);
            }}

            if (__contentBuilder.Length > 0)
            {{
                var __content = __contentBuilder.ToString().Trim();
                if (!global::System.String.IsNullOrWhiteSpace(__content))
                {{
                    var __streamedResponse = {jsonSerializer.GenerateDeserializeCall("__content", endPoint.SuccessResponse.Type, endPoint.Settings.JsonSerializerContext)} ??
                                           throw new global::{endPoint.GlobalSettings.Namespace}.ApiException(
                                               message: $""Response deserialization failed for \""{{__content}}\"" "",
                                               statusCode: __response.StatusCode)
                                           {{
                                               ResponseBody = __content,
                                               ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                                   __response.Headers,
                                                   h => h.Key,
                                                   h => h.Value),
                                           }};

                    yield return __streamedResponse;
                }}
            }}"
                : $@"
            using var __reader = new global::System.IO.StreamReader(__stream);

            while (!__reader.EndOfStream && !cancellationToken.IsCancellationRequested)
            {{
                var __content = await __reader.ReadLineAsync().ConfigureAwait(false) ?? string.Empty;
                if (global::System.String.IsNullOrWhiteSpace(__content))
                {{
                    continue;
                }}

                var __streamedResponse = {jsonSerializer.GenerateDeserializeCall("__content", endPoint.SuccessResponse.Type, endPoint.Settings.JsonSerializerContext)} ??
                                       throw new global::{endPoint.GlobalSettings.Namespace}.ApiException(
                                           message: $""Response deserialization failed for \""{{__content}}\"" "",
                                           statusCode: __response.StatusCode)
                                       {{
                                           ResponseBody = __content,
                                           ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                               __response.Headers,
                                               h => h.Key,
                                               h => h.Value),
                                       }};

                yield return __streamedResponse;
            }}";

            return $@"
            try
            {{
                __response.EnsureSuccessStatusCode();
            }}
            catch (global::System.Net.Http.HttpRequestException __ex)
            {{
                string? __content = null;
                try
                {{
                    __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);
                }}
                catch (global::System.Exception)
                {{
                }}

                throw new global::{endPoint.GlobalSettings.Namespace}.ApiException(
                    message: __content ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __ex,
                    statusCode: __response.StatusCode)
                {{
                    ResponseBody = __content,
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
{streamReadLoop}
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
                {x.Type.CSharpTypeWithoutNullability}? __value_{x.StatusCode} = null;" : TrimmedLine)}
                try
                {{
                    if (ReadResponseAsString)
                    {{
                        __content_{x.StatusCode} = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
{(!string.IsNullOrWhiteSpace(x.Type.CSharpTypeWithoutNullability) ? $@" 
                        __value_{x.StatusCode} = {jsonSerializer.GenerateDeserializeCall($"__content_{x.StatusCode}", x.Type, endPoint.Settings.JsonSerializerContext)};" : TrimmedLine)}
                    }}
                    else
                    {{
                        __content_{x.StatusCode} = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
{(!string.IsNullOrWhiteSpace(x.Type.CSharpTypeWithoutNullability) ? $@"
                        __value_{x.StatusCode} = {jsonSerializer.GenerateDeserializeCall($"__content_{x.StatusCode}", x.Type, endPoint.Settings.JsonSerializerContext)};" : TrimmedLine)}
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
                    ResponseObject = __value_{x.StatusCode}," : TrimmedLine)}
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                }};
            }}").Inject() : TrimmedLine;

        if (endPoint.RawStream)
        {
            return @$"{errors}

            try
            {{
                __response.EnsureSuccessStatusCode();

                var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

{(wrapSuccessResponse
    ? $@"                return new global::{endPoint.Settings.Namespace}.AutoSDKHttpResponse<global::System.IO.Stream>(
                    statusCode: __response.StatusCode,
                    headers: {GetSuccessResponseHeadersExpression(endPoint)},
                    body: new global::{endPoint.GlobalSettings.Namespace}.ResponseStream(__response, __content));"
    : $"                return new global::{endPoint.GlobalSettings.Namespace}.ResponseStream(__response, __content);")}
            }}
            catch (global::System.Exception __ex)
            {{
                string? __content = null;
                try
                {{
                    __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);
                }}
                catch (global::System.Exception)
                {{
                }}

                throw new global::{endPoint.GlobalSettings.Namespace}.ApiException(
                    message: __content ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __ex,
                    statusCode: __response.StatusCode)
                {{
                    ResponseBody = __content,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                }};
            }}
 ";
        }

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
                    content: ref __content);" : TrimmedLine)}
{(!string.IsNullOrWhiteSpace(endPoint.SuccessResponse.Type.CSharpType) ? @$" 
                Process{endPoint.NotAsyncMethodName}ResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);" : TrimmedLine)}

                try
                {{
                    __response.EnsureSuccessStatusCode();

{(string.IsNullOrWhiteSpace(endPoint.SuccessResponse.Type.CSharpType)
    ? GenerateSuccessResponseReturnWithoutBody(endPoint, wrapSuccessResponse)
    : endPoint is { ContentType: ContentType.String, SuccessResponse.Type.CSharpTypeWithoutNullability: not "string" } ? wrapSuccessResponse ? $@" 
                    var __value = {jsonSerializer.GenerateDeserializeCall("__content", endPoint.SuccessResponse.Type, endPoint.Settings.JsonSerializerContext)} ??
                        throw new global::System.InvalidOperationException($""Response deserialization failed for \""{{__content}}\"" "");
                    {GenerateSuccessResponseReturn(endPoint, "__value", wrapSuccessResponse)}" : $@" 
                    return
                        {jsonSerializer.GenerateDeserializeCall("__content", endPoint.SuccessResponse.Type, endPoint.Settings.JsonSerializerContext)} ??
                        throw new global::System.InvalidOperationException($""Response deserialization failed for \""{{__content}}\"" "");" : $@" 
                    {GenerateSuccessResponseReturn(endPoint, "__content", wrapSuccessResponse)}")}
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
                        ResponseBody = __content," : TrimmedLine)}
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
{GenerateUnbufferedSuccessResponseHandling(endPoint, wrapSuccessResponse)}
                }}
                catch (global::System.Exception __ex)
                {{
                    string? __content = null;
                    try
                    {{
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }}
                    catch (global::System.Exception)
                    {{
                    }}

                    throw new global::{endPoint.GlobalSettings.Namespace}.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {{
                        ResponseBody = __content,
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
            return TrimmedLine;
        }

        var jsonSerializer = endPoint.Settings.JsonSerializerType.GetSerializer();
        if (endPoint.IsMultipartFormData)
        {
            return $@" 
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
{endPoint.Parameters.Where(x => !x.IsMultiPartFormDataFilename).Select(x =>
{
    var isBinaryArray = x.Type.IsArray && !x.Type.SubTypes.IsEmpty && x.Type.SubTypes[0].Unbox<TypeData>().IsBinary;
    // Resolve the actual filename property: prefer the synthetic companion, fall back to
    // a case-insensitive match among siblings (e.g. FileName from file_name for binary file)
    var filenamePropName = x.Type.IsBinary
        ? endPoint.Parameters
            .Where(p => string.Equals(p.Name, x.Name + "name", StringComparison.OrdinalIgnoreCase))
            .Select(p => p.Name)
            .FirstOrDefault() ?? (x.Name + "name")
        : string.Empty;
    var add = x.Type.IsBinary ? @$"
            var __content{x.Name} = new global::System.Net.Http.ByteArrayContent(request.{x.Name} ?? global::System.Array.Empty<byte>());
            __httpRequestContent.Add(
                content: __content{x.Name},
                name: ""\""{x.Id}\"""",
                fileName: request.{filenamePropName} != null ? $""\""{{request.{filenamePropName}}}\"""" : string.Empty);
            if (__content{x.Name}.Headers.ContentDisposition != null)
            {{
                __content{x.Name}.Headers.ContentDisposition.FileNameStar = null;
            }}
 " : isBinaryArray ? @$"
            for (var __i{x.Name} = 0; __i{x.Name} < request.{x.Name}.Count; __i{x.Name}++)
            {{
                var __content{x.Name} = new global::System.Net.Http.ByteArrayContent(request.{x.Name}[__i{x.Name}]);
                __httpRequestContent.Add(
                    content: __content{x.Name},
                    name: ""\""{x.Id}\"""",
                    fileName: $""\""file{{__i{x.Name}}}.bin\"""");
                if (__content{x.Name}.Headers.ContentDisposition != null)
                {{
                    __content{x.Name}.Headers.ContentDisposition.FileNameStar = null;
                }}
            }}
 " : @$"
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent({SerializePropertyAsString(x)}),
                name: ""\""{x.Id}\"""");
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

        if (endPoint.RequestType.IsBinary || endPoint.RequestMediaType == "application/octet-stream")
        {
            return @"
            var __httpRequestContent = new global::System.Net.Http.ByteArrayContent(request);
            __httpRequestContent.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(""application/octet-stream"");
            __httpRequest.Content = __httpRequestContent;
 ".RemoveBlankLinesWhereOnlyWhitespaces();
        }

        if (endPoint.RequestMediaType.IsSequentialJsonMimeType())
        {
            return GenerateSequentialJsonRequestData(endPoint);
        }

        if (ShouldUseSystemNetHttpJsonForRequest(endPoint))
        {
            return GenerateSystemNetHttpJsonRequestData(endPoint);
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

    private static string GenerateSequentialJsonRequestData(
        EndPoint endPoint)
    {
        var isJsonSequence = endPoint.RequestMediaType.IsMimeType("application/json-seq");
        var itemType = endPoint.RequestType.IsArray && !endPoint.RequestType.SubTypes.IsEmpty
            ? endPoint.RequestType.SubTypes[0].Unbox<TypeData>()
            : endPoint.RequestType;
        var serializedItemExpression = GenerateJsonSerializeExpression(
            type: itemType,
            valueExpression: "__requestItem",
            settings: endPoint.Settings);
        var appendDelimiter = isJsonSequence
            ? @"                __httpRequestContentBuilder.Append('\u001e');
                __httpRequestContentBuilder.Append(__requestItemContent);
                __httpRequestContentBuilder.Append('\n');"
            : @"                if (!__httpRequestContentFirst)
                {
                    __httpRequestContentBuilder.Append('\n');
                }

                __httpRequestContentBuilder.Append(__requestItemContent);
                __httpRequestContentFirst = false;";

        if (endPoint.RequestType.IsArray)
        {
            return $@"
            var __httpRequestContentBuilder = new global::System.Text.StringBuilder();
            {(isJsonSequence ? string.Empty : "var __httpRequestContentFirst = true;")}
            foreach (var __requestItem in request)
            {{
                var __requestItemContent = {serializedItemExpression};
{appendDelimiter}
            }}

            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBuilder.ToString(),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: ""{endPoint.RequestMediaType}"");
            __httpRequest.Content = __httpRequestContent;
 ".RemoveBlankLinesWhereOnlyWhitespaces();
        }

        var singleItemBodyExpression = isJsonSequence
            ? "\"\\u001e\" + " + GenerateJsonSerializeExpression(
                type: itemType,
                valueExpression: "request",
                settings: endPoint.Settings) + " + \"\\n\""
            : GenerateJsonSerializeExpression(
                type: itemType,
                valueExpression: "request",
                settings: endPoint.Settings);

        return $@"
            var __httpRequestContentBody = {singleItemBodyExpression};
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
            endPoint.RequestType.IsBinary ||
            endPoint.RequestType.CSharpTypeWithoutNullability is "string")
        {
            return TrimmedLine;
        }

        // Skip convenience overload for discriminator base classes where all properties
        // were filtered out — the overload would just construct an empty base instance
        // with no way to specify which variant to use
        if (endPoint.RequestType.IsBaseClass &&
            !endPoint.Parameters.Any(x => x.Location == null))
        {
            return TrimmedLine;
        }

        var taskType = endPoint.RawStream
            ? "global::System.Threading.Tasks.Task<global::System.IO.Stream>"
            : endPoint.EnumerableStream
            ? string.IsNullOrWhiteSpace(endPoint.SuccessResponse.Type.CSharpType)
                ? throw new InvalidOperationException($"Streamed responses must have a response type. OperationId: {endPoint.Id}.")
                : $"global::System.Collections.Generic.IAsyncEnumerable<{endPoint.SuccessResponse.Type.CSharpTypeWithoutNullability}>"
            : string.IsNullOrWhiteSpace(endPoint.SuccessResponse.Type.CSharpType)
                ? "global::System.Threading.Tasks.Task"
                : $"global::System.Threading.Tasks.Task<{endPoint.SuccessResponse.Type.CSharpTypeWithoutNullability}>";
        var cancellationTokenAttribute = endPoint.EnumerableStream && !isInterface
            ? "[global::System.Runtime.CompilerServices.EnumeratorCancellation] "
            : string.Empty;
        var response = endPoint.EnumerableStream
            ? "var __enumerable = "
            : string.IsNullOrWhiteSpace(endPoint.SuccessResponse.Type.CSharpType)
                ? "await "
                : "return await ";
        var configureAwaitResponse = !endPoint.EnumerableStream
            ? ".ConfigureAwait(false)"
            : string.Empty;
        var body = isInterface
            ? ";"
            : @$"
        {{
{GenerateRequestInitialization(
    endPoint,
    "__request",
    x => IsRequestStreamParameter(x) && endPoint.ForcedRequestStreamValue is bool forcedRequestStreamValue
        ? forcedRequestStreamValue ? "true" : "false"
        : x.ParameterName)}

            {response}{endPoint.MethodName}(
{endPoint.Parameters.Where(x => x.Location != null).Select(x => $@"
                {x.ParameterName}: {x.ParameterName},").Inject()}
                request: __request,
                cancellationToken: cancellationToken){configureAwaitResponse};
{(endPoint.EnumerableStream ? @"
            
            await foreach (var __response in __enumerable)
            {
                yield return __response;
            }" : TrimmedLine)}
        }}";

        var parameters = GetExtensionMethodParameters(endPoint).ToList();

        return $@" 
        {endPoint.Summary.ToXmlDocumentationSummary(level: 8)}
{parameters.Select(x => $@"
        {x.Summary.ToXmlDocumentationForParam(x.ParameterName, level: 8)}").Inject()}
        /// <param name=""cancellationToken"">The token to cancel the operation with</param>
        /// <exception cref=""global::System.InvalidOperationException""></exception>
        {GenerateEndPointAttributes(endPoint)}
        {(isInterface ? "" : "public async ")}{taskType} {endPoint.MethodName}(
{parameters.Where(static x => x.IsRequired && !x.HasSchemaDefault).Select(x => $@"
{x.DisableDeprecationWarningIfRequired}
            {x.Type.CSharpType} {x.ParameterName},
{x.DisableDeprecationWarningIfRequired}".TrimEnd()).Inject()}
{parameters.Where(static x => !x.IsRequired || x.HasSchemaDefault).Select(x => $@"
{x.DisableDeprecationWarningIfRequired}
            {x.Type.CSharpType} {x.ParameterName} = {x.ParameterDefaultValue},
{x.DisableDeprecationWarningIfRequired}".TrimEnd()).Inject()}
            {cancellationTokenAttribute}global::System.Threading.CancellationToken cancellationToken = default){body}
 ".RemoveBlankLinesWhereOnlyWhitespaces();
    }

    private static string GenerateEndPointAttributes(EndPoint endPoint)
    {
        return @$" 
{(endPoint.IsDeprecated ? $@" 
        [global::System.Obsolete(""{(!string.IsNullOrWhiteSpace(endPoint.DeprecationMessage) ? endPoint.DeprecationMessage.ClearForCSharp() : "This method marked as deprecated.")}"")]" : TrimmedLine)}
 
{(endPoint.Settings.UseExperimentalAttributes is
      SdkFeatureUsage.Always or
      SdkFeatureUsage.InSupportedTargetFrameworks &&
    !string.IsNullOrWhiteSpace(endPoint.ExperimentalStage)
            ? $@" 
{(endPoint.Settings.UseExperimentalAttributes is SdkFeatureUsage.InSupportedTargetFrameworks ? @" 
#if NET8_0_OR_GREATER" : TrimmedLine)}
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: ""{endPoint.Settings.Namespace.Replace(".", "_").ToUpperInvariant()}_{endPoint.ExperimentalStage.ToUpperInvariant()}_001"")]
{(endPoint.Settings.UseExperimentalAttributes is SdkFeatureUsage.InSupportedTargetFrameworks ? @" 
#endif" : TrimmedLine)}"
            : TrimmedLine)}";
    }
}
