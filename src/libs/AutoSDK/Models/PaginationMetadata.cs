namespace AutoSDK.Models;

public enum PaginationScheme
{
    Offset,
    PageNumber,
    Cursor,
    CursorId,
    Url,
}

public enum PaginationRequestBindingTarget
{
    Parameter,
    RequestBodyProperty,
}

public enum PaginationValueSource
{
    Body,
    Header,
}

public record struct PaginationRequestBinding(
    string Id,
    PaginationRequestBindingTarget Target)
{
    public static PaginationRequestBinding Default => new(
        Id: string.Empty,
        Target: PaginationRequestBindingTarget.Parameter);

    public bool IsDefault => string.IsNullOrWhiteSpace(Id);
}

public record struct PaginationValueBinding(
    PaginationValueSource Source,
    string Value)
{
    public static PaginationValueBinding Default => new(
        Source: PaginationValueSource.Body,
        Value: string.Empty);

    public bool IsDefault => string.IsNullOrWhiteSpace(Value);
}

public record struct PaginationMetadata(
    PaginationScheme Scheme,
    TypeData ItemType,
    string ItemsPath,
    bool ItemsAreTopLevelArray,
    PaginationRequestBinding LimitBinding,
    PaginationRequestBinding OffsetBinding,
    PaginationRequestBinding PageNumberBinding,
    PaginationRequestBinding NextCursorBinding,
    PaginationRequestBinding NextCursorIdBinding,
    PaginationValueBinding NextCursorValue,
    PaginationValueBinding NextPageUrlValue,
    PaginationValueBinding CurrentPageValue,
    PaginationValueBinding TotalPagesValue,
    PaginationValueBinding NextOffsetValue,
    PaginationValueBinding TotalCountValue,
    string CursorItemIdPath)
{
    public static PaginationMetadata Default => new(
        Scheme: PaginationScheme.Cursor,
        ItemType: TypeData.Default,
        ItemsPath: string.Empty,
        ItemsAreTopLevelArray: false,
        LimitBinding: PaginationRequestBinding.Default,
        OffsetBinding: PaginationRequestBinding.Default,
        PageNumberBinding: PaginationRequestBinding.Default,
        NextCursorBinding: PaginationRequestBinding.Default,
        NextCursorIdBinding: PaginationRequestBinding.Default,
        NextCursorValue: PaginationValueBinding.Default,
        NextPageUrlValue: PaginationValueBinding.Default,
        CurrentPageValue: PaginationValueBinding.Default,
        TotalPagesValue: PaginationValueBinding.Default,
        NextOffsetValue: PaginationValueBinding.Default,
        TotalCountValue: PaginationValueBinding.Default,
        CursorItemIdPath: string.Empty);

    public bool IsDefault => string.IsNullOrWhiteSpace(ItemType.CSharpTypeWithoutNullability);
}
