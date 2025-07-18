﻿//HintName: G.Commands.ActionsListArtifactsForRepoCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ActionsListArtifactsForRepoCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            int? perPage,
            int? page,
            string? name,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ActionsListArtifactsForRepoResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Owner { get; } = new(
            name: "owner")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Repo { get; } = new(
            name: "repo")
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

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };
        public ActionsListArtifactsForRepoCommand(G.IApi client) : base(
            name: "actions",
            description: @"Lists all artifacts for a repository.

Anyone with read access to the repository can use this endpoint.

OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Options.Add(PerPage);
            Options.Add(Page);
            Options.Add(Name);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var perPage = parseResult.GetRequiredValue(PerPage);
            var page = parseResult.GetRequiredValue(Page);
            var name = parseResult.GetRequiredValue(Name);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                perPage: perPage,
                page: page,
                name: name,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Actions.ActionsListArtifactsForRepoAsync(
                owner: owner,
                repo: repo,
                perPage: perPage,
                page: page,
                name: name,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}