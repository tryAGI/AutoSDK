//HintName: G.Commands.ReposGetOrgRulesetsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposGetOrgRulesetsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            int? perPage,
            int? page,
            string? targets,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.RepositoryRuleset> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Org { get; } = new(
            name: "org")
        {
            Description = "",
        };

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

        private global::System.CommandLine.Option<string?> Targets { get; } = new(
            name: "targets")
        {
            Description = "",
        };
        public ReposGetOrgRulesetsCommand(G.IApi client) : base(
            name: "repos",
            description: @"Get all the repository rulesets for an organization.")
        {
            _client = client;

            Arguments.Add(Org);
            Options.Add(PerPage);
            Options.Add(Page);
            Options.Add(Targets);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var org = parseResult.GetRequiredValue(Org);
            var perPage = parseResult.GetRequiredValue(PerPage);
            var page = parseResult.GetRequiredValue(Page);
            var targets = parseResult.GetRequiredValue(Targets);

            Validate(
                parseResult: parseResult,
                org: org,
                perPage: perPage,
                page: page,
                targets: targets,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Repos.ReposGetOrgRulesetsAsync(
                org: org,
                perPage: perPage,
                page: page,
                targets: targets,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}