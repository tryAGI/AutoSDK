//HintName: G.Commands.PackagesRestorePackageForOrgCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PackagesRestorePackageForOrgCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.PackagesRestorePackageForOrgPackageType packageType,
            string packageName,
            string org,
            string? token,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.PackagesRestorePackageForOrgPackageType> PackageType { get; } = new(
            name: "packageType")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> PackageName { get; } = new(
            name: "packageName")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Token { get; } = new(
            name: "token")
        {
            Description = "",
        };
        public PackagesRestorePackageForOrgCommand(G.IApi client) : base(
            name: "packages",
            description: @"Restores an entire package in an organization.

You can restore a deleted package under the following conditions:
  - The package was deleted within the last 30 days.
  - The same package namespace and version is still available and not reused for a new package. If the same package namespace is not available, you will not be able to restore your package. In this scenario, to restore the deleted package, you must delete the new package that uses the deleted package's namespace first.

The authenticated user must have admin permissions in the organization to use this endpoint. If the `package_type` belongs to a GitHub Packages registry that supports granular permissions, the authenticated user must also have admin permissions to the package. For the list of these registries, see ""[About permissions for GitHub Packages](https://docs.github.com/packages/learn-github-packages/about-permissions-for-github-packages#granular-permissions-for-userorganization-scoped-packages).""

OAuth app tokens and personal access tokens (classic) need the `read:packages` and `write:packages` scopes to use this endpoint. If the `package_type` belongs to a GitHub Packages registry that only supports repository-scoped permissions, the `repo` scope is also required. For the list of these registries, see ""[About permissions for GitHub Packages](https://docs.github.com/packages/learn-github-packages/about-permissions-for-github-packages#permissions-for-repository-scoped-packages).""")
        {
            _client = client;

            Arguments.Add(PackageType);
            Arguments.Add(PackageName);
            Arguments.Add(Org);
            Options.Add(Token);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var packageType = parseResult.GetRequiredValue(PackageType);
            var packageName = parseResult.GetRequiredValue(PackageName);
            var org = parseResult.GetRequiredValue(Org);
            var token = parseResult.GetRequiredValue(Token);

            Validate(
                parseResult: parseResult,
                packageType: packageType,
                packageName: packageName,
                org: org,
                token: token,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Packages.PackagesRestorePackageForOrgAsync(
                packageType: packageType,
                packageName: packageName,
                org: org,
                token: token,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}