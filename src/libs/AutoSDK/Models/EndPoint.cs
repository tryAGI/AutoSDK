using System.Collections.Immutable;

namespace AutoSDK.Models;

public record struct EndPoint(
    string Id,
    string ClassName,
    string NotAsyncMethodName,
    string MethodName,
    string CliCommandClassName,
    string FileNameWithoutExtension,
    string InterfaceFileNameWithoutExtension,
    Tag Tag,
    string BaseUrl,
    StreamFormat StreamFormat,
    string Path,
    string RequestMediaType,
    EquatableArray<MethodParameter> Parameters,
    EndPointResponse SuccessResponse,
    EquatableArray<EndPointResponse> ErrorResponses,
    EquatableArray<Authorization> Authorizations,
    EquatableArray<AuthorizationRequirementSet> AuthorizationRequirements,
    EquatableArray<MethodParameter> QueryParameters,
    System.Net.Http.HttpMethod HttpMethod,
    ContentType ContentType,
    string Summary,
    string Description,
    string BaseUrlSummary,
    string CliAction,
    Settings Settings,
    Settings GlobalSettings,
    bool IsDeprecated,
    string DeprecationMessage,
    string ExperimentalStage,
    TypeData RequestType,
    TypeData RequestInitializationType,
    bool? ForcedRequestStreamValue,
    string StreamTerminator,
    string Remarks,
    bool GenerateResponseWrapper,
    EquatableArray<PollingOperation> PollingOperations
)
{
    public bool Stream => StreamFormat != StreamFormat.None;
    public bool RawStream => StreamFormat == StreamFormat.Binary;
    public bool EnumerableStream => Stream && !RawStream;
    public bool IsMultipartFormData => RequestMediaType == "multipart/form-data";
}
