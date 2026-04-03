using System.Collections.Immutable;

namespace AutoSDK.Grpc;

public sealed class GrpcProtoDocument
{
    public GrpcProtoDocument(
        string? packageName,
        string? csharpNamespace,
        ImmutableArray<string> imports,
        ImmutableArray<string> services)
    {
        PackageName = packageName;
        CSharpNamespace = csharpNamespace;
        Imports = imports;
        Services = services;
    }

    public string? PackageName { get; }

    public string? CSharpNamespace { get; }

    public ImmutableArray<string> Imports { get; }

    public ImmutableArray<string> Services { get; }
}
