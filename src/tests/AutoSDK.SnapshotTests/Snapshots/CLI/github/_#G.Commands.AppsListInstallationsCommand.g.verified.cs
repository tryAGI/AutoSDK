//HintName: G.Commands.AppsListInstallationsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AppsListInstallationsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? perPage,
            int? page,
            global::System.DateTime? since,
            string? outdated,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.Installation> response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<int?> PerPage { get; } = new(
            name: "perPage")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Page { get; } = new(
            name: "page")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> Since { get; } = new(
            name: "since")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Outdated { get; } = new(
            name: "outdated")
        {
            Description = "",
        };
        public AppsListInstallationsCommand(G.IApi client) : base(
            name: "apps",
            description: @"The permissions the installation has are included under the `permissions` key.

You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.")
        {
            _client = client;

            Options.Add(PerPage);
            Options.Add(Page);
            Options.Add(Since);
            Options.Add(Outdated);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var perPage = parseResult.GetRequiredValue(PerPage);
            var page = parseResult.GetRequiredValue(Page);
            var since = parseResult.GetRequiredValue(Since);
            var outdated = parseResult.GetRequiredValue(Outdated);

            Validate(
                parseResult: parseResult,
                perPage: perPage,
                page: page,
                since: since,
                outdated: outdated,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Apps.AppsListInstallationsAsync(
                perPage: perPage,
                page: page,
                since: since,
                outdated: outdated,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}