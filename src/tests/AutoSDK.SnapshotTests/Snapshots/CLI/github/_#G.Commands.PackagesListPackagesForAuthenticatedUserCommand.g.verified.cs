//HintName: G.Commands.PackagesListPackagesForAuthenticatedUserCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PackagesListPackagesForAuthenticatedUserCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.PackagesListPackagesForAuthenticatedUserPackageType packageType,
            global::G.PackagesListPackagesForAuthenticatedUserVisibility? visibility,
            int? page,
            int? perPage,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.Package> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.PackagesListPackagesForAuthenticatedUserPackageType> PackageType { get; } = new(
            name: "packageType")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.PackagesListPackagesForAuthenticatedUserVisibility?> Visibility { get; } = new(
            name: "visibility")
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
        public PackagesListPackagesForAuthenticatedUserCommand(G.IApi client) : base(
            name: "packages",
            description: @"Lists packages owned by the authenticated user within the user's namespace.

OAuth app tokens and personal access tokens (classic) need the `read:packages` scope to use this endpoint. If the `package_type` belongs to a GitHub Packages registry that only supports repository-scoped permissions, the `repo` scope is also required. For the list of these registries, see ""[About permissions for GitHub Packages](https://docs.github.com/packages/learn-github-packages/about-permissions-for-github-packages#permissions-for-repository-scoped-packages).""")
        {
            _client = client;

            Arguments.Add(PackageType);
            Options.Add(Visibility);
            Options.Add(Page);
            Options.Add(PerPage);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var packageType = parseResult.GetRequiredValue(PackageType);
            var visibility = parseResult.GetRequiredValue(Visibility);
            var page = parseResult.GetRequiredValue(Page);
            var perPage = parseResult.GetRequiredValue(PerPage);

            Validate(
                parseResult: parseResult,
                packageType: packageType,
                visibility: visibility,
                page: page,
                perPage: perPage,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Packages.PackagesListPackagesForAuthenticatedUserAsync(
                packageType: packageType,
                visibility: visibility,
                page: page,
                perPage: perPage,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}