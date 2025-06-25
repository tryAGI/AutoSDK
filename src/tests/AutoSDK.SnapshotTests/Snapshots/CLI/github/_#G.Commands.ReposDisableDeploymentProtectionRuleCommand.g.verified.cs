//HintName: G.Commands.ReposDisableDeploymentProtectionRuleCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposDisableDeploymentProtectionRuleCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string environmentName,
            string repo,
            string owner,
            int protectionRuleId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> EnvironmentName { get; } = new(
            name: "environmentName")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Repo { get; } = new(
            name: "repo")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Owner { get; } = new(
            name: "owner")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<int> ProtectionRuleId { get; } = new(
            name: "protectionRuleId")
        {
            Description = "",
        };

        public ReposDisableDeploymentProtectionRuleCommand(G.IApi client) : base(
            name: "repos",
            description: @"Disables a custom deployment protection rule for an environment.

The authenticated user must have admin or owner permissions to the repository to use this endpoint.

OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.")
        {
            _client = client;

            Arguments.Add(EnvironmentName);
            Arguments.Add(Repo);
            Arguments.Add(Owner);
            Arguments.Add(ProtectionRuleId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var environmentName = parseResult.GetRequiredValue(EnvironmentName);
            var repo = parseResult.GetRequiredValue(Repo);
            var owner = parseResult.GetRequiredValue(Owner);
            var protectionRuleId = parseResult.GetRequiredValue(ProtectionRuleId);

            Validate(
                parseResult: parseResult,
                environmentName: environmentName,
                repo: repo,
                owner: owner,
                protectionRuleId: protectionRuleId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Repos.ReposDisableDeploymentProtectionRuleAsync(
                environmentName: environmentName,
                repo: repo,
                owner: owner,
                protectionRuleId: protectionRuleId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}