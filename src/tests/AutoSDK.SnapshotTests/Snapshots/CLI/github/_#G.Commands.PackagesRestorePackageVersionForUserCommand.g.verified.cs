//HintName: G.Commands.PackagesRestorePackageVersionForUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PackagesRestorePackageVersionForUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.PackagesRestorePackageVersionForUserPackageType packageType,
            string packageName,
            string username,
            int packageVersionId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.PackagesRestorePackageVersionForUserPackageType> PackageType { get; } = new(
            name: "packageType")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> PackageName { get; } = new(
            name: "packageName")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Username { get; } = new(
            name: "username")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<int> PackageVersionId { get; } = new(
            name: "packageVersionId")
        {
            Description = "",
        };

        public PackagesRestorePackageVersionForUserCommand(G.IApi client) : base(
            name: "packages",
            description: @"Restores a specific package version for a user.

You can restore a deleted package under the following conditions:
  - The package was deleted within the last 30 days.
  - The same package namespace and version is still available and not reused for a new package. If the same package namespace is not available, you will not be able to restore your package. In this scenario, to restore the deleted package, you must delete the new package that uses the deleted package's namespace first.

If the `package_type` belongs to a GitHub Packages registry that supports granular permissions, the authenticated user must have admin permissions to the package. For the list of these registries, see ""[About permissions for GitHub Packages](https://docs.github.com/packages/learn-github-packages/about-permissions-for-github-packages#granular-permissions-for-userorganization-scoped-packages).""

OAuth app tokens and personal access tokens (classic) need the `read:packages` and `write:packages` scopes to use this endpoint. If the `package_type` belongs to a GitHub Packages registry that only supports repository-scoped permissions, the `repo` scope is also required. For the list of these registries, see ""[About permissions for GitHub Packages](https://docs.github.com/packages/learn-github-packages/about-permissions-for-github-packages#permissions-for-repository-scoped-packages).""")
        {
            _client = client;

            Arguments.Add(PackageType);
            Arguments.Add(PackageName);
            Arguments.Add(Username);
            Arguments.Add(PackageVersionId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var packageType = parseResult.GetRequiredValue(PackageType);
            var packageName = parseResult.GetRequiredValue(PackageName);
            var username = parseResult.GetRequiredValue(Username);
            var packageVersionId = parseResult.GetRequiredValue(PackageVersionId);

            Validate(
                parseResult: parseResult,
                packageType: packageType,
                packageName: packageName,
                username: username,
                packageVersionId: packageVersionId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Packages.PackagesRestorePackageVersionForUserAsync(
                packageType: packageType,
                packageName: packageName,
                username: username,
                packageVersionId: packageVersionId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}