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
    EquatableArray<PollingOperation> PollingOperations,
    EquatableArray<ServerOption> Servers = default,
    bool HasServerOverride = false,
    bool ClientUsesServerSelectionSupport = false,
    bool HasLocationHeaderOnSuccess = false,
    LocationWaitCompanion LocationWaitCompanion = default,
    PageableMetadata PageableMetadata = default
)
{
    public bool Stream => StreamFormat != StreamFormat.None;
    public bool RawStream => StreamFormat == StreamFormat.Binary;
    public bool EnumerableStream => Stream && !RawStream;
    public bool IsMultipartFormData => RequestMediaType == "multipart/form-data";
    public bool HasLocationWaitCompanion => !string.IsNullOrEmpty(LocationWaitCompanion.SiblingMethodName);
    public bool HasPageableHelper => PageableMetadata.Style != PageableStyle.None;
}

public enum PageableStyle
{
    None,
    Offset,
}

public record struct PageableMetadata(
    PageableStyle Style,
    string PageParameterName,
    string ItemsPropertyName,
    TypeData ItemType)
{
    public static PageableMetadata Empty => new(
        Style: PageableStyle.None,
        PageParameterName: string.Empty,
        ItemsPropertyName: string.Empty,
        ItemType: TypeData.Default);
}

public record struct LocationWaitCompanion(
    string SiblingMethodName,
    string SiblingPollingMethodName,
    string SiblingPath,
    string SiblingIdParameterName,
    TypeData SiblingReturnType)
{
    public static LocationWaitCompanion Empty => new(
        SiblingMethodName: string.Empty,
        SiblingPollingMethodName: string.Empty,
        SiblingPath: string.Empty,
        SiblingIdParameterName: string.Empty,
        SiblingReturnType: TypeData.Default);
}
