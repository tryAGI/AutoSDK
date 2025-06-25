//HintName: G.Commands.OrgsListPatGrantRequestsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OrgsListPatGrantRequestsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string org,
            int? perPage,
            int? page,
            global::G.OrgsListPatGrantRequestsSort? sort,
            global::G.OrgsListPatGrantRequestsDirection? direction,
            global::System.Collections.Generic.IList<string>? owner,
            string? repository,
            string? permission,
            global::System.DateTime? lastUsedBefore,
            global::System.DateTime? lastUsedAfter,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.OrganizationProgrammaticAccessGrantRequest> response,
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

        private global::System.CommandLine.Option<global::G.OrgsListPatGrantRequestsSort?> Sort { get; } = new(
            name: "sort")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.OrgsListPatGrantRequestsDirection?> Direction { get; } = new(
            name: "direction")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Owner { get; } = new(
            name: "owner")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Repository { get; } = new(
            name: "repository")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Permission { get; } = new(
            name: "permission")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> LastUsedBefore { get; } = new(
            name: "lastUsedBefore")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> LastUsedAfter { get; } = new(
            name: "lastUsedAfter")
        {
            Description = "",
        };
        public OrgsListPatGrantRequestsCommand(G.IApi client) : base(
            name: "orgs",
            description: @"Lists requests from organization members to access organization resources with a fine-grained personal access token.

Only GitHub Apps can use this endpoint.")
        {
            _client = client;

            Arguments.Add(Org);
            Options.Add(PerPage);
            Options.Add(Page);
            Options.Add(Sort);
            Options.Add(Direction);
            Options.Add(Owner);
            Options.Add(Repository);
            Options.Add(Permission);
            Options.Add(LastUsedBefore);
            Options.Add(LastUsedAfter);

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
            var sort = parseResult.GetRequiredValue(Sort);
            var direction = parseResult.GetRequiredValue(Direction);
            var owner = parseResult.GetRequiredValue(Owner);
            var repository = parseResult.GetRequiredValue(Repository);
            var permission = parseResult.GetRequiredValue(Permission);
            var lastUsedBefore = parseResult.GetRequiredValue(LastUsedBefore);
            var lastUsedAfter = parseResult.GetRequiredValue(LastUsedAfter);

            Validate(
                parseResult: parseResult,
                org: org,
                perPage: perPage,
                page: page,
                sort: sort,
                direction: direction,
                owner: owner,
                repository: repository,
                permission: permission,
                lastUsedBefore: lastUsedBefore,
                lastUsedAfter: lastUsedAfter,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Orgs.OrgsListPatGrantRequestsAsync(
                org: org,
                perPage: perPage,
                page: page,
                sort: sort,
                direction: direction,
                owner: owner,
                repository: repository,
                permission: permission,
                lastUsedBefore: lastUsedBefore,
                lastUsedAfter: lastUsedAfter,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}