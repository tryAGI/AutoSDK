//HintName: G.Commands.PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType packageType,
            string packageName,
            int? page,
            int? perPage,
            global::G.PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserState? state,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.PackageVersion> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserPackageType> PackageType { get; } = new(
            name: "packageType")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> PackageName { get; } = new(
            name: "packageName")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Page { get; } = new(
            name: "page")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> PerPage { get; } = new(
            name: "perPage")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserState?> State { get; } = new(
            name: "state")
        {
            Description = "",
        };
        public PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserCommand(G.IApi client) : base(
            name: "packages",
            description: @"Lists package versions for a package owned by the authenticated user.

OAuth app tokens and personal access tokens (classic) need the `read:packages` scope to use this endpoint. If the `package_type` belongs to a GitHub Packages registry that only supports repository-scoped permissions, the `repo` scope is also required. For the list of these registries, see ""[About permissions for GitHub Packages](https://docs.github.com/packages/learn-github-packages/about-permissions-for-github-packages#permissions-for-repository-scoped-packages).""")
        {
            _client = client;

            Arguments.Add(PackageType);
            Arguments.Add(PackageName);
            Options.Add(Page);
            Options.Add(PerPage);
            Options.Add(State);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var packageType = parseResult.GetRequiredValue(PackageType);
            var packageName = parseResult.GetRequiredValue(PackageName);
            var page = parseResult.GetRequiredValue(Page);
            var perPage = parseResult.GetRequiredValue(PerPage);
            var state = parseResult.GetRequiredValue(State);

            Validate(
                parseResult: parseResult,
                packageType: packageType,
                packageName: packageName,
                page: page,
                perPage: perPage,
                state: state,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Packages.PackagesGetAllPackageVersionsForPackageOwnedByAuthenticatedUserAsync(
                packageType: packageType,
                packageName: packageName,
                page: page,
                perPage: perPage,
                state: state,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}