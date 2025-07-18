﻿//HintName: G.Commands.ReposDeleteAnEnvironmentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposDeleteAnEnvironmentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string owner,
            string repo,
            string environmentName,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
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

        private global::System.CommandLine.Argument<string> EnvironmentName { get; } = new(
            name: "environmentName")
        {
            Description = "",
        };

        public ReposDeleteAnEnvironmentCommand(G.IApi client) : base(
            name: "repos",
            description: @"OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(Owner);
            Arguments.Add(Repo);
            Arguments.Add(EnvironmentName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var owner = parseResult.GetRequiredValue(Owner);
            var repo = parseResult.GetRequiredValue(Repo);
            var environmentName = parseResult.GetRequiredValue(EnvironmentName);

            Validate(
                parseResult: parseResult,
                owner: owner,
                repo: repo,
                environmentName: environmentName,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Repos.ReposDeleteAnEnvironmentAsync(
                owner: owner,
                repo: repo,
                environmentName: environmentName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}