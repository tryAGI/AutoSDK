//HintName: G.Commands.PackagesDeletePackageVersionForOrgCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PackagesDeletePackageVersionForOrgCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.PackagesDeletePackageVersionForOrgPackageType packageType,
            string packageName,
            string org,
            int packageVersionId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.PackagesDeletePackageVersionForOrgPackageType> PackageType { get; } = new(
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

        private global::System.CommandLine.Argument<int> PackageVersionId { get; } = new(
            name: "packageVersionId")
        {
            Description = "",
        };

        public PackagesDeletePackageVersionForOrgCommand(G.IApi client) : base(
            name: "packages",
            description: @"Deletes a specific package version in an organization. If the package is public and the package version has more than 5,000 downloads, you cannot delete the package version. In this scenario, contact GitHub support for further assistance.

The authenticated user must have admin permissions in the organization to use this endpoint. If the `package_type` belongs to a GitHub Packages registry that supports granular permissions, the authenticated user must also have admin permissions to the package. For the list of these registries, see ""[About permissions for GitHub Packages](https://docs.github.com/packages/learn-github-packages/about-permissions-for-github-packages#granular-permissions-for-userorganization-scoped-packages).""

OAuth app tokens and personal access tokens (classic) need the `read:packages` and `delete:packages` scopes to use this endpoint. If the `package_type` belongs to a GitHub Packages registry that only supports repository-scoped permissions, the `repo` scope is also required. For the list of these registries, see ""[About permissions for GitHub Packages](https://docs.github.com/packages/learn-github-packages/about-permissions-for-github-packages#permissions-for-repository-scoped-packages).""")
        {
            _client = client;

            Arguments.Add(PackageType);
            Arguments.Add(PackageName);
            Arguments.Add(Org);
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
            var org = parseResult.GetRequiredValue(Org);
            var packageVersionId = parseResult.GetRequiredValue(PackageVersionId);

            Validate(
                parseResult: parseResult,
                packageType: packageType,
                packageName: packageName,
                org: org,
                packageVersionId: packageVersionId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Packages.PackagesDeletePackageVersionForOrgAsync(
                packageType: packageType,
                packageName: packageName,
                org: org,
                packageVersionId: packageVersionId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}