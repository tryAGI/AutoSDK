//HintName: G.Commands.PackagesGetAllPackageVersionsForPackageOwnedByOrgCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PackagesGetAllPackageVersionsForPackageOwnedByOrgCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType packageType,
            string packageName,
            string org,
            int? page,
            int? perPage,
            global::G.PackagesGetAllPackageVersionsForPackageOwnedByOrgState? state,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.PackageVersion> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.PackagesGetAllPackageVersionsForPackageOwnedByOrgPackageType> PackageType { get; } = new(
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

        private global::System.CommandLine.Option<global::G.PackagesGetAllPackageVersionsForPackageOwnedByOrgState?> State { get; } = new(
            name: "state")
        {
            Description = "",
        };
        public PackagesGetAllPackageVersionsForPackageOwnedByOrgCommand(G.IApi client) : base(
            name: "packages",
            description: @"Lists package versions for a package owned by an organization.

OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint if the `package_type` belongs to a GitHub Packages registry that only supports repository-scoped permissions. For the list of these registries, see ""[About permissions for GitHub Packages](https://docs.github.com/packages/learn-github-packages/about-permissions-for-github-packages#permissions-for-repository-scoped-packages).""")
        {
            _client = client;

            Arguments.Add(PackageType);
            Arguments.Add(PackageName);
            Arguments.Add(Org);
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
            var org = parseResult.GetRequiredValue(Org);
            var page = parseResult.GetRequiredValue(Page);
            var perPage = parseResult.GetRequiredValue(PerPage);
            var state = parseResult.GetRequiredValue(State);

            Validate(
                parseResult: parseResult,
                packageType: packageType,
                packageName: packageName,
                org: org,
                page: page,
                perPage: perPage,
                state: state,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Packages.PackagesGetAllPackageVersionsForPackageOwnedByOrgAsync(
                packageType: packageType,
                packageName: packageName,
                org: org,
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