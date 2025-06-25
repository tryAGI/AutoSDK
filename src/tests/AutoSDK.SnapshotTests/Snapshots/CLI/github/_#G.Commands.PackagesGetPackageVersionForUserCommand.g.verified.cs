//HintName: G.Commands.PackagesGetPackageVersionForUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PackagesGetPackageVersionForUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.PackagesGetPackageVersionForUserPackageType packageType,
            string packageName,
            int packageVersionId,
            string username,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.PackageVersion response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.PackagesGetPackageVersionForUserPackageType> PackageType { get; } = new(
            name: "packageType")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> PackageName { get; } = new(
            name: "packageName")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<int> PackageVersionId { get; } = new(
            name: "packageVersionId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Username { get; } = new(
            name: "username")
        {
            Description = "",
        };

        public PackagesGetPackageVersionForUserCommand(G.IApi client) : base(
            name: "packages",
            description: @"Gets a specific package version for a public package owned by a specified user.

OAuth app tokens and personal access tokens (classic) need the `read:packages` scope to use this endpoint. If the `package_type` belongs to a GitHub Packages registry that only supports repository-scoped permissions, the `repo` scope is also required. For the list of these registries, see ""[About permissions for GitHub Packages](https://docs.github.com/packages/learn-github-packages/about-permissions-for-github-packages#permissions-for-repository-scoped-packages).""")
        {
            _client = client;

            Arguments.Add(PackageType);
            Arguments.Add(PackageName);
            Arguments.Add(PackageVersionId);
            Arguments.Add(Username);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var packageType = parseResult.GetRequiredValue(PackageType);
            var packageName = parseResult.GetRequiredValue(PackageName);
            var packageVersionId = parseResult.GetRequiredValue(PackageVersionId);
            var username = parseResult.GetRequiredValue(Username);

            Validate(
                parseResult: parseResult,
                packageType: packageType,
                packageName: packageName,
                packageVersionId: packageVersionId,
                username: username,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Packages.PackagesGetPackageVersionForUserAsync(
                packageType: packageType,
                packageName: packageName,
                packageVersionId: packageVersionId,
                username: username,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}