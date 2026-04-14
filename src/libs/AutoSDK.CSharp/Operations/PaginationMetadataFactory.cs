using System.Text;
using System.Text.Json.Nodes;
using AutoSDK.Extensions;
using AutoSDK.Helpers;
using AutoSDK.Models;
using Microsoft.OpenApi;

namespace AutoSDK.Generation;

internal static class PaginationMetadataFactory
{
    private static readonly char[] PathSeparators = new[] { '/' };

    public static PaginationMetadata? TryCreate(
        OperationContext operation,
        string requestMediaType,
        EndPointResponse successResponse,
        IReadOnlyList<MethodParameter> parameters)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        if (!CanPaginate(successResponse))
        {
            return null;
        }

        var responseContext = FindResponseContext(operation, successResponse);
        if (responseContext == null)
        {
            return null;
        }

        if (TryCreateFromSpeakeasy(operation, responseContext, successResponse, parameters, out var speakeasy))
        {
            return speakeasy;
        }

        var requestContext = FindRequestContext(operation, requestMediaType);
        return TryCreateFromStainless(operation, requestContext, responseContext, successResponse, parameters, out var stainless)
            ? stainless
            : null;
    }

    private static bool TryCreateFromSpeakeasy(
        OperationContext operation,
        SchemaContext responseContext,
        EndPointResponse successResponse,
        IReadOnlyList<MethodParameter> parameters,
        out PaginationMetadata pagination)
    {
        pagination = PaginationMetadata.Default;

        if (!(operation.Operation.Extensions?.TryGetValue("x-speakeasy-pagination", out var extension) ?? false) ||
            OpenApiExtensions.TryGetExtensionJsonNode(extension) is not JsonObject extensionObject ||
            !TryGetJsonObjectString(extensionObject, out var rawType, "type"))
        {
            return false;
        }

        PaginationRequestBinding pageBinding = default;
        PaginationRequestBinding offsetBinding = default;
        PaginationRequestBinding limitBinding = default;
        PaginationRequestBinding cursorBinding = default;

        if (TryGetJsonObjectProperty(extensionObject, "inputs", out var inputsNode) &&
            inputsNode is JsonArray inputsArray)
        {
            foreach (var inputNode in inputsArray)
            {
                if (inputNode is not JsonObject inputObject ||
                    !TryGetJsonObjectString(inputObject, out var inputName, "name") ||
                    !TryGetJsonObjectString(inputObject, out var inputLocation, "in") ||
                    !TryGetJsonObjectString(inputObject, out var inputType, "type"))
                {
                    continue;
                }

                var binding = ResolveSpeakeasyRequestBinding(parameters, inputName, inputLocation);
                if (binding.IsDefault)
                {
                    continue;
                }

                switch (inputType)
                {
                    case "page":
                        pageBinding = binding;
                        break;
                    case "offset":
                        offsetBinding = binding;
                        break;
                    case "limit":
                        limitBinding = binding;
                        break;
                    case "cursor":
                        cursorBinding = binding;
                        break;
                }
            }
        }

        PaginationValueBinding nextCursorValue = default;
        PaginationValueBinding nextPageUrlValue = default;
        PaginationValueBinding totalPagesValue = default;
        string itemsPath = string.Empty;
        TypeData itemType = TypeData.Default;
        var itemsAreTopLevelArray = false;

        if (TryGetJsonObjectProperty(extensionObject, "outputs", out var outputsNode) &&
            outputsNode is JsonObject outputsObject)
        {
            if (TryGetJsonObjectString(outputsObject, out var resultsPathRaw, "results") &&
                TryNormalizeSpeakeasyPath(resultsPathRaw, out var resultsPath) &&
                TryResolveItemsPath(responseContext, successResponse.Type, resultsPath, out itemsPath, out itemType, out itemsAreTopLevelArray))
            {
            }

            if (TryGetJsonObjectString(outputsObject, out var nextCursorRaw, "nextCursor") &&
                TryNormalizeSpeakeasyPath(nextCursorRaw, out var normalizedNextCursor) &&
                TryResolveBodyPath(responseContext, normalizedNextCursor))
            {
                nextCursorValue = new PaginationValueBinding(PaginationValueSource.Body, normalizedNextCursor);
            }

            if (TryGetJsonObjectString(outputsObject, out var nextUrlRaw, "nextUrl") &&
                TryNormalizeSpeakeasyPath(nextUrlRaw, out var normalizedNextUrl) &&
                TryResolveBodyPath(responseContext, normalizedNextUrl))
            {
                nextPageUrlValue = new PaginationValueBinding(PaginationValueSource.Body, normalizedNextUrl);
            }

            if (TryGetJsonObjectString(outputsObject, out var totalPagesRaw, "numPages") &&
                TryNormalizeSpeakeasyPath(totalPagesRaw, out var normalizedTotalPages) &&
                TryResolveBodyPath(responseContext, normalizedTotalPages))
            {
                totalPagesValue = new PaginationValueBinding(PaginationValueSource.Body, normalizedTotalPages);
            }
        }

        if (itemType == TypeData.Default &&
            !nextCursorValue.IsDefault &&
            TryDeriveItemsPathFromCursorPath(nextCursorValue.Value, out var derivedItemsPath) &&
            TryResolveItemsPath(responseContext, successResponse.Type, derivedItemsPath, out itemsPath, out itemType, out itemsAreTopLevelArray))
        {
        }

        if (itemType == TypeData.Default &&
            string.Equals(rawType, "url", StringComparison.OrdinalIgnoreCase) &&
            TryFindSingleArrayPath(responseContext, successResponse.Type, out itemsPath, out itemType, out itemsAreTopLevelArray))
        {
        }

        if (itemType == TypeData.Default)
        {
            return false;
        }

        if (string.Equals(rawType, "offsetLimit", StringComparison.OrdinalIgnoreCase))
        {
            if (!pageBinding.IsDefault)
            {
                pagination = PaginationMetadata.Default with
                {
                    Scheme = PaginationScheme.PageNumber,
                    ItemType = itemType,
                    ItemsPath = itemsPath,
                    ItemsAreTopLevelArray = itemsAreTopLevelArray,
                    LimitBinding = limitBinding,
                    PageNumberBinding = pageBinding,
                    TotalPagesValue = totalPagesValue,
                };
                return true;
            }

            if (!offsetBinding.IsDefault)
            {
                pagination = PaginationMetadata.Default with
                {
                    Scheme = PaginationScheme.Offset,
                    ItemType = itemType,
                    ItemsPath = itemsPath,
                    ItemsAreTopLevelArray = itemsAreTopLevelArray,
                    LimitBinding = limitBinding,
                    OffsetBinding = offsetBinding,
                };
                return true;
            }

            return false;
        }

        if (string.Equals(rawType, "cursor", StringComparison.OrdinalIgnoreCase) &&
            !cursorBinding.IsDefault &&
            !nextCursorValue.IsDefault)
        {
            pagination = PaginationMetadata.Default with
            {
                Scheme = PaginationScheme.Cursor,
                ItemType = itemType,
                ItemsPath = itemsPath,
                ItemsAreTopLevelArray = itemsAreTopLevelArray,
                LimitBinding = limitBinding,
                NextCursorBinding = cursorBinding,
                NextCursorValue = nextCursorValue,
            };
            return true;
        }

        if (string.Equals(rawType, "url", StringComparison.OrdinalIgnoreCase) &&
            !nextPageUrlValue.IsDefault)
        {
            pagination = PaginationMetadata.Default with
            {
                Scheme = PaginationScheme.Url,
                ItemType = itemType,
                ItemsPath = itemsPath,
                ItemsAreTopLevelArray = itemsAreTopLevelArray,
                NextPageUrlValue = nextPageUrlValue,
            };
            return true;
        }

        return false;
    }

    private static bool TryCreateFromStainless(
        OperationContext operation,
        SchemaContext? requestContext,
        SchemaContext responseContext,
        EndPointResponse successResponse,
        IReadOnlyList<MethodParameter> parameters,
        out PaginationMetadata pagination)
    {
        pagination = PaginationMetadata.Default;

        PaginationRequestBinding limitBinding = default;
        PaginationRequestBinding offsetBinding = default;
        PaginationRequestBinding pageNumberBinding = default;
        PaginationRequestBinding nextCursorBinding = default;
        PaginationRequestBinding nextCursorIdBinding = default;

        foreach (var parameterContext in operation.Schemas.Where(static x => x is { Hint: Hint.Parameter, ParameterData: not null }))
        {
            if (!TryGetStainlessPaginationProperty(parameterContext.Schema.Extensions, out var purpose, out _))
            {
                continue;
            }

            var binding = new PaginationRequestBinding(parameterContext.ParameterData!.Value.Id, PaginationRequestBindingTarget.Parameter);
            switch (purpose)
            {
                case "offset_count_param":
                    offsetBinding = binding;
                    break;
                case "page_number_param":
                    pageNumberBinding = binding;
                    break;
                case "next_cursor_param":
                    nextCursorBinding = binding;
                    break;
                case "next_cursor_id_param":
                    nextCursorIdBinding = binding;
                    break;
            }
        }

        if (requestContext != null)
        {
            foreach (var (context, _) in EnumerateContexts(requestContext))
            {
                if (context is not { IsProperty: true, PropertyData: not null })
                {
                    continue;
                }

                if (!TryGetStainlessPaginationProperty(context.Schema.Extensions, out var purpose, out _))
                {
                    continue;
                }

                var binding = new PaginationRequestBinding(context.PropertyData!.Value.Id, PaginationRequestBindingTarget.RequestBodyProperty);
                switch (purpose)
                {
                    case "offset_count_param":
                        offsetBinding = binding;
                        break;
                    case "page_number_param":
                        pageNumberBinding = binding;
                        break;
                    case "next_cursor_param":
                        nextCursorBinding = binding;
                        break;
                    case "next_cursor_id_param":
                        nextCursorIdBinding = binding;
                        break;
                }
            }
        }

        PaginationValueBinding nextCursorValue = default;
        PaginationValueBinding nextPageUrlValue = default;
        PaginationValueBinding currentPageValue = default;
        PaginationValueBinding totalPagesValue = default;
        PaginationValueBinding nextOffsetValue = default;
        PaginationValueBinding totalCountValue = default;
        string itemsPath = string.Empty;
        var itemsAreTopLevelArray = false;
        TypeData itemType = TypeData.Default;
        string? absoluteCursorItemIdPath = null;

        foreach (var (context, path) in EnumerateContexts(responseContext))
        {
            if (!TryGetStainlessPaginationProperty(context.Schema.Extensions, out var purpose, out var fromHeader) &&
                !TryGetStainlessTopLevelArray(context.Schema.Extensions, out var isTopLevelArray))
            {
                continue;
            }

            if (TryGetStainlessTopLevelArray(context.Schema.Extensions, out isTopLevelArray) &&
                isTopLevelArray &&
                context == responseContext &&
                TryResolveItemsPath(responseContext, successResponse.Type, string.Empty, out itemsPath, out itemType, out itemsAreTopLevelArray))
            {
                continue;
            }

            if (string.IsNullOrWhiteSpace(purpose))
            {
                continue;
            }

            switch (purpose)
            {
                case "items" when TryResolveItemsPath(responseContext, successResponse.Type, path, out itemsPath, out itemType, out itemsAreTopLevelArray):
                    break;
                case "next_cursor_field":
                    nextCursorValue = CreateResponseBinding(path, fromHeader);
                    break;
                case "next_cursor_id_param":
                    nextCursorValue = CreateResponseBinding(path, fromHeader);
                    break;
                case "cursor_url_field":
                    nextPageUrlValue = CreateResponseBinding(path, fromHeader);
                    break;
                case "current_page_number_field":
                    currentPageValue = CreateResponseBinding(path, fromHeader);
                    break;
                case "total_page_count_field":
                    totalPagesValue = CreateResponseBinding(path, fromHeader);
                    break;
                case "offset_count_start_field":
                    nextOffsetValue = CreateResponseBinding(path, fromHeader);
                    break;
                case "offset_total_count_field":
                    totalCountValue = CreateResponseBinding(path, fromHeader);
                    break;
                case "cursor_item_id":
                    absoluteCursorItemIdPath = path;
                    break;
            }
        }

        if (itemType == TypeData.Default)
        {
            return false;
        }

        var cursorItemIdPath = string.Empty;
        if (!string.IsNullOrWhiteSpace(absoluteCursorItemIdPath))
        {
            var absoluteCursorItemIdPathValue = absoluteCursorItemIdPath!;
            if (itemsAreTopLevelArray)
            {
                cursorItemIdPath = absoluteCursorItemIdPathValue;
            }
            else if (absoluteCursorItemIdPathValue.StartsWith(itemsPath + "/", StringComparison.Ordinal))
            {
                cursorItemIdPath = absoluteCursorItemIdPathValue.Substring(itemsPath.Length + 1);
            }
        }

        if (!nextPageUrlValue.IsDefault)
        {
            pagination = PaginationMetadata.Default with
            {
                Scheme = PaginationScheme.Url,
                ItemType = itemType,
                ItemsPath = itemsPath,
                ItemsAreTopLevelArray = itemsAreTopLevelArray,
                LimitBinding = limitBinding,
                NextPageUrlValue = nextPageUrlValue,
            };
            return true;
        }

        if (!nextCursorIdBinding.IsDefault &&
            (!string.IsNullOrWhiteSpace(cursorItemIdPath) || !nextCursorValue.IsDefault))
        {
            pagination = PaginationMetadata.Default with
            {
                Scheme = PaginationScheme.CursorId,
                ItemType = itemType,
                ItemsPath = itemsPath,
                ItemsAreTopLevelArray = itemsAreTopLevelArray,
                LimitBinding = limitBinding,
                NextCursorIdBinding = nextCursorIdBinding,
                NextCursorValue = nextCursorValue,
                CursorItemIdPath = cursorItemIdPath,
            };
            return true;
        }

        if (!nextCursorBinding.IsDefault &&
            !nextCursorValue.IsDefault)
        {
            pagination = PaginationMetadata.Default with
            {
                Scheme = PaginationScheme.Cursor,
                ItemType = itemType,
                ItemsPath = itemsPath,
                ItemsAreTopLevelArray = itemsAreTopLevelArray,
                LimitBinding = limitBinding,
                NextCursorBinding = nextCursorBinding,
                NextCursorValue = nextCursorValue,
            };
            return true;
        }

        if (!pageNumberBinding.IsDefault)
        {
            pagination = PaginationMetadata.Default with
            {
                Scheme = PaginationScheme.PageNumber,
                ItemType = itemType,
                ItemsPath = itemsPath,
                ItemsAreTopLevelArray = itemsAreTopLevelArray,
                LimitBinding = limitBinding,
                PageNumberBinding = pageNumberBinding,
                CurrentPageValue = currentPageValue,
                TotalPagesValue = totalPagesValue,
            };
            return true;
        }

        if (!offsetBinding.IsDefault)
        {
            pagination = PaginationMetadata.Default with
            {
                Scheme = PaginationScheme.Offset,
                ItemType = itemType,
                ItemsPath = itemsPath,
                ItemsAreTopLevelArray = itemsAreTopLevelArray,
                LimitBinding = limitBinding,
                OffsetBinding = offsetBinding,
                NextOffsetValue = nextOffsetValue,
                TotalCountValue = totalCountValue,
            };
            return true;
        }

        return false;
    }

    private static PaginationValueBinding CreateResponseBinding(string path, string? fromHeader)
    {
        return !string.IsNullOrWhiteSpace(fromHeader)
            ? new PaginationValueBinding(PaginationValueSource.Header, fromHeader!)
            : new PaginationValueBinding(PaginationValueSource.Body, path);
    }

    private static bool CanPaginate(EndPointResponse successResponse)
    {
        return successResponse.ContentType == ContentType.String &&
               !string.IsNullOrWhiteSpace(successResponse.Type.CSharpTypeWithoutNullability) &&
               !string.Equals(successResponse.Type.CSharpTypeWithoutNullability, "string", StringComparison.Ordinal) &&
               successResponse.MimeType.IsJsonMimeType();
    }

    private static SchemaContext? FindRequestContext(OperationContext operation, string requestMediaType)
    {
        return operation.Schemas.FirstOrDefault(x =>
                   x.Hint == Hint.Request &&
                   x.ContentType == requestMediaType &&
                   !x.IsMediaTypeItemSchema) ??
               operation.Schemas.FirstOrDefault(x =>
                   x.Hint == Hint.Request &&
                   !x.IsMediaTypeItemSchema);
    }

    private static SchemaContext? FindResponseContext(OperationContext operation, EndPointResponse successResponse)
    {
        return operation.Schemas.FirstOrDefault(x =>
                   x.Hint == Hint.Response &&
                   x.ResponseStatusCode == successResponse.StatusCode &&
                   (x.ContentType == null || string.Equals(x.ContentType, successResponse.MimeType, StringComparison.OrdinalIgnoreCase)) &&
                   !x.IsMediaTypeItemSchema) ??
               operation.Schemas.FirstOrDefault(x =>
                   x.Hint == Hint.Response &&
                   x.ResponseStatusCode == successResponse.StatusCode &&
                   !x.IsMediaTypeItemSchema);
    }

    private static PaginationRequestBinding ResolveSpeakeasyRequestBinding(
        IReadOnlyList<MethodParameter> parameters,
        string inputName,
        string inputLocation)
    {
        var fromRequestBody = string.Equals(inputLocation, "requestBody", StringComparison.OrdinalIgnoreCase);
        var parameter = parameters.FirstOrDefault(x =>
            string.Equals(x.Id, inputName, StringComparison.OrdinalIgnoreCase) &&
            (fromRequestBody ? x.Location == null : x.Location != null));

        return string.IsNullOrWhiteSpace(parameter.Id)
            ? PaginationRequestBinding.Default
            : new PaginationRequestBinding(
                parameter.Id,
                fromRequestBody
                    ? PaginationRequestBindingTarget.RequestBodyProperty
                    : PaginationRequestBindingTarget.Parameter);
    }

    private static bool TryResolveItemsPath(
        SchemaContext responseContext,
        TypeData successResponseType,
        string path,
        out string itemsPath,
        out TypeData itemType,
        out bool itemsAreTopLevelArray)
    {
        itemsPath = path;
        itemType = TypeData.Default;
        itemsAreTopLevelArray = false;

        if (string.IsNullOrWhiteSpace(path))
        {
            if (TryGetArrayItemType(responseContext, successResponseType, out itemType))
            {
                itemsAreTopLevelArray = true;
                itemsPath = string.Empty;
                return true;
            }

            return false;
        }

        if (!TryResolveBodyPath(responseContext, path, out var targetContext))
        {
            return false;
        }

        return TryGetArrayItemType(targetContext, targetContext.TypeData, out itemType);
    }

    private static bool TryFindSingleArrayPath(
        SchemaContext responseContext,
        TypeData successResponseType,
        out string itemsPath,
        out TypeData itemType,
        out bool itemsAreTopLevelArray)
    {
        itemsPath = string.Empty;
        itemType = TypeData.Default;
        itemsAreTopLevelArray = false;

        var candidates = new List<(string Path, TypeData ItemType, bool IsTopLevelArray)>();

        if (TryGetArrayItemType(responseContext, successResponseType, out var rootItemType))
        {
            candidates.Add((string.Empty, rootItemType, true));
        }

        foreach (var (context, path) in EnumerateContexts(responseContext))
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                continue;
            }

            if (TryGetArrayItemType(context, context.TypeData, out var candidateItemType))
            {
                candidates.Add((path, candidateItemType, false));
            }
        }

        if (candidates.Count != 1)
        {
            return false;
        }

        var candidate = candidates[0];
        itemsPath = candidate.Path;
        itemType = candidate.ItemType;
        itemsAreTopLevelArray = candidate.IsTopLevelArray;
        return true;
    }

    private static bool TryResolveBodyPath(SchemaContext responseContext, string path)
    {
        return TryResolveBodyPath(responseContext, path, out _);
    }

    private static bool TryResolveBodyPath(SchemaContext responseContext, string path, out SchemaContext targetContext)
    {
        targetContext = responseContext;
        var current = responseContext;

        if (string.IsNullOrWhiteSpace(path))
        {
            return true;
        }

        foreach (var segment in path.Split(PathSeparators, StringSplitOptions.RemoveEmptyEntries))
        {
            if (segment == "[-1]")
            {
                var effectiveArrayContext = current.ResolvedReference ?? current;
                var arrayItem = effectiveArrayContext.Children.FirstOrDefault(static x => x.Hint == Hint.ArrayItem);
                if (arrayItem == null)
                {
                    return false;
                }

                current = arrayItem;
                continue;
            }

            var effectiveContext = current.ResolvedReference ?? current;
            var property = effectiveContext.Children.FirstOrDefault(x =>
                x.IsProperty &&
                string.Equals(x.PropertyName, segment, StringComparison.OrdinalIgnoreCase));
            if (property == null)
            {
                return false;
            }

            current = property;
        }

        targetContext = current.ResolvedReference ?? current;
        return true;
    }

    private static bool TryGetArrayItemType(SchemaContext context, TypeData type, out TypeData itemType)
    {
        itemType = TypeData.Default;
        var effectiveType = (context.ResolvedReference ?? context).TypeData;
        if (effectiveType.IsArray && effectiveType.SubTypes.Length > 0)
        {
            itemType = effectiveType.SubTypes[0].Unbox<TypeData>();
            return !string.IsNullOrWhiteSpace(itemType.CSharpTypeWithoutNullability);
        }

        if (type.IsArray && type.SubTypes.Length > 0)
        {
            itemType = type.SubTypes[0].Unbox<TypeData>();
            return !string.IsNullOrWhiteSpace(itemType.CSharpTypeWithoutNullability);
        }

        return false;
    }

    private static IEnumerable<(SchemaContext Context, string Path)> EnumerateContexts(SchemaContext root)
    {
        return EnumerateCore(root, path: string.Empty, ancestry: new HashSet<SchemaContext>());

        static IEnumerable<(SchemaContext Context, string Path)> EnumerateCore(
            SchemaContext current,
            string path,
            HashSet<SchemaContext> ancestry)
        {
            yield return (current, path);

            var effective = current.ResolvedReference ?? current;
            if (!ancestry.Add(effective))
            {
                yield break;
            }

            foreach (var child in effective.Children)
            {
                var childPath = string.IsNullOrWhiteSpace(child.PropertyName)
                    ? path
                    : string.IsNullOrWhiteSpace(path)
                        ? child.PropertyName!
                        : $"{path}/{child.PropertyName}";
                foreach (var item in EnumerateCore(child, childPath, ancestry))
                {
                    yield return item;
                }
            }

            ancestry.Remove(effective);
        }
    }

    private static bool TryDeriveItemsPathFromCursorPath(string path, out string itemsPath)
    {
        itemsPath = string.Empty;
        if (string.IsNullOrWhiteSpace(path))
        {
            return false;
        }

        var segments = path.Split(PathSeparators, StringSplitOptions.RemoveEmptyEntries);
        var index = Array.IndexOf(segments, "[-1]");
        if (index <= 0)
        {
            return false;
        }

        itemsPath = string.Join("/", segments.Take(index));
        return !string.IsNullOrWhiteSpace(itemsPath);
    }

    private static bool TryNormalizeSpeakeasyPath(string rawPath, out string normalizedPath)
    {
        normalizedPath = string.Empty;

        if (string.IsNullOrWhiteSpace(rawPath))
        {
            return false;
        }

        var value = rawPath.Trim();
        if (!value.StartsWith("$", StringComparison.Ordinal))
        {
            return false;
        }

        if (value.Length == 1)
        {
            normalizedPath = string.Empty;
            return true;
        }

        var segments = new List<string>();
        var buffer = new StringBuilder();

        for (var i = 1; i < value.Length; i++)
        {
            switch (value[i])
            {
                case '.':
                    FlushBuffer(buffer, segments);
                    break;
                case '[':
                    FlushBuffer(buffer, segments);
                    var endIndex = value.IndexOf(']', i + 1);
                    if (endIndex < 0)
                    {
                        return false;
                    }

                    var token = value.Substring(i + 1, endIndex - i - 1).Trim();
                    if (string.Equals(token, "-1", StringComparison.Ordinal))
                    {
                        segments.Add("[-1]");
                    }
                    else if (TryUnquote(token, out var quotedToken))
                    {
                        segments.Add(quotedToken);
                    }
                    else
                    {
                        segments.Add(token);
                    }

                    i = endIndex;
                    break;
                default:
                    buffer.Append(value[i]);
                    break;
            }
        }

        FlushBuffer(buffer, segments);
        if (segments.Count == 0)
        {
            normalizedPath = string.Empty;
            return true;
        }

        if (segments.Any(static x => string.IsNullOrWhiteSpace(x)))
        {
            return false;
        }

        normalizedPath = string.Join("/", segments);
        return true;

        static void FlushBuffer(StringBuilder builder, List<string> values)
        {
            if (builder.Length == 0)
            {
                return;
            }

            values.Add(builder.ToString());
            builder.Clear();
        }
    }

    private static bool TryUnquote(string value, out string unquoted)
    {
        unquoted = string.Empty;
        if (value.Length < 2)
        {
            return false;
        }

        var lastCharacter = value[value.Length - 1];
        if ((value[0] == '\'' && lastCharacter == '\'') ||
            (value[0] == '"' && lastCharacter == '"'))
        {
            unquoted = value.Substring(1, value.Length - 2);
            return true;
        }

        return false;
    }

    private static bool TryGetStainlessPaginationProperty(
        IDictionary<string, IOpenApiExtension>? extensions,
        out string purpose,
        out string? fromHeader)
    {
        purpose = string.Empty;
        fromHeader = null;

        if (!(extensions?.TryGetValue("x-stainless-pagination-property", out var extension) ?? false) ||
            OpenApiExtensions.TryGetExtensionJsonNode(extension) is not JsonObject paginationObject)
        {
            return false;
        }

        _ = TryGetJsonObjectString(paginationObject, out purpose, "purpose");
        _ = TryGetJsonObjectString(paginationObject, out fromHeader, "from_header");
        return !string.IsNullOrWhiteSpace(purpose) || !string.IsNullOrWhiteSpace(fromHeader);
    }

    private static bool TryGetStainlessTopLevelArray(
        IDictionary<string, IOpenApiExtension>? extensions,
        out bool isTopLevelArray)
    {
        isTopLevelArray = false;

        if (!(extensions?.TryGetValue("x-stainless-pagination-property", out var extension) ?? false) ||
            OpenApiExtensions.TryGetExtensionJsonNode(extension) is not JsonObject paginationObject)
        {
            return false;
        }

        return TryGetJsonObjectBoolean(paginationObject, out isTopLevelArray, "is_top_level_array") &&
               isTopLevelArray;
    }

    private static bool TryGetJsonObjectString(
        JsonObject jsonObject,
        out string value,
        params string[] propertyNames)
    {
        value = string.Empty;

        foreach (var propertyName in propertyNames)
        {
            if (!TryGetJsonObjectProperty(jsonObject, propertyName, out var node) ||
                node is not JsonValue jsonValue ||
                !jsonValue.TryGetValue<string>(out var stringValue) ||
                string.IsNullOrWhiteSpace(stringValue))
            {
                continue;
            }

            value = stringValue;
            return true;
        }

        return false;
    }

    private static bool TryGetJsonObjectBoolean(
        JsonObject jsonObject,
        out bool value,
        params string[] propertyNames)
    {
        value = false;

        foreach (var propertyName in propertyNames)
        {
            if (!TryGetJsonObjectProperty(jsonObject, propertyName, out var node) ||
                node is not JsonValue jsonValue)
            {
                continue;
            }

            if (jsonValue.TryGetValue<bool>(out value))
            {
                return true;
            }

            if (jsonValue.TryGetValue<string>(out var stringValue) &&
                bool.TryParse(stringValue, out value))
            {
                return true;
            }
        }

        return false;
    }

    private static bool TryGetJsonObjectProperty(
        JsonObject jsonObject,
        string propertyName,
        out JsonNode? value)
    {
        foreach (var kvp in jsonObject)
        {
            if (!string.Equals(kvp.Key, propertyName, StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            value = kvp.Value;
            return value != null;
        }

        value = null;
        return false;
    }
}
