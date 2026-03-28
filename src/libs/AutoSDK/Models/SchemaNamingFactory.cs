using Microsoft.OpenApi;

namespace AutoSDK.Models;

public readonly struct ReferenceNameContext : IEquatable<ReferenceNameContext>
{
    public ReferenceNameContext(SchemaNamingSettings settings, SchemaContext? parent, string referenceId)
    {
        Settings = settings;
        Parent = parent;
        ReferenceId = referenceId;
    }

    public SchemaNamingSettings Settings { get; }
    public SchemaContext? Parent { get; }
    public string ReferenceId { get; }

    public bool Equals(ReferenceNameContext other)
    {
        return Settings.Equals(other.Settings) &&
               ReferenceEquals(Parent, other.Parent) &&
               string.Equals(ReferenceId, other.ReferenceId, StringComparison.Ordinal);
    }

    public override bool Equals(object? obj)
    {
        return obj is ReferenceNameContext other && Equals(other);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            var hashCode = Settings.GetHashCode();
            hashCode = (hashCode * 397) ^ (Parent?.GetHashCode() ?? 0);
            hashCode = (hashCode * 397) ^ StringComparer.Ordinal.GetHashCode(ReferenceId ?? string.Empty);
            return hashCode;
        }
    }

    public static bool operator ==(ReferenceNameContext left, ReferenceNameContext right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(ReferenceNameContext left, ReferenceNameContext right)
    {
        return !left.Equals(right);
    }
}

public readonly struct SchemaNameContext : IEquatable<SchemaNameContext>
{
    public SchemaNameContext(
        SchemaNamingSettings settings,
        SchemaContext? parent,
        Hint? hint,
        OpenApiOperation? operation,
        IOpenApiParameter? parameter,
        string? propertyName,
        string? componentId,
        int? index,
        string? title,
        string? operationPath,
        System.Net.Http.HttpMethod? operationType)
    {
        Settings = settings;
        Parent = parent;
        Hint = hint;
        Operation = operation;
        Parameter = parameter;
        PropertyName = propertyName;
        ComponentId = componentId;
        Index = index;
        Title = title;
        OperationPath = operationPath;
        OperationType = operationType;
    }

    public SchemaNamingSettings Settings { get; }
    public SchemaContext? Parent { get; }
    public Hint? Hint { get; }
    public OpenApiOperation? Operation { get; }
    public IOpenApiParameter? Parameter { get; }
    public string? PropertyName { get; }
    public string? ComponentId { get; }
    public int? Index { get; }
    public string? Title { get; }
    public string? OperationPath { get; }
    public System.Net.Http.HttpMethod? OperationType { get; }

    public bool Equals(SchemaNameContext other)
    {
        return Settings.Equals(other.Settings) &&
               ReferenceEquals(Parent, other.Parent) &&
               Hint == other.Hint &&
               ReferenceEquals(Operation, other.Operation) &&
               ReferenceEquals(Parameter, other.Parameter) &&
               string.Equals(PropertyName, other.PropertyName, StringComparison.Ordinal) &&
               string.Equals(ComponentId, other.ComponentId, StringComparison.Ordinal) &&
               Index == other.Index &&
               string.Equals(Title, other.Title, StringComparison.Ordinal) &&
               string.Equals(OperationPath, other.OperationPath, StringComparison.Ordinal) &&
               Equals(OperationType, other.OperationType);
    }

    public override bool Equals(object? obj)
    {
        return obj is SchemaNameContext other && Equals(other);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            var hashCode = Settings.GetHashCode();
            hashCode = (hashCode * 397) ^ (Parent?.GetHashCode() ?? 0);
            hashCode = (hashCode * 397) ^ Hint.GetHashCode();
            hashCode = (hashCode * 397) ^ (Operation?.GetHashCode() ?? 0);
            hashCode = (hashCode * 397) ^ (Parameter?.GetHashCode() ?? 0);
            hashCode = (hashCode * 397) ^ StringComparer.Ordinal.GetHashCode(PropertyName ?? string.Empty);
            hashCode = (hashCode * 397) ^ StringComparer.Ordinal.GetHashCode(ComponentId ?? string.Empty);
            hashCode = (hashCode * 397) ^ Index.GetHashCode();
            hashCode = (hashCode * 397) ^ StringComparer.Ordinal.GetHashCode(Title ?? string.Empty);
            hashCode = (hashCode * 397) ^ StringComparer.Ordinal.GetHashCode(OperationPath ?? string.Empty);
            hashCode = (hashCode * 397) ^ (OperationType?.GetHashCode() ?? 0);
            return hashCode;
        }
    }

    public static bool operator ==(SchemaNameContext left, SchemaNameContext right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(SchemaNameContext left, SchemaNameContext right)
    {
        return !left.Equals(right);
    }
}
