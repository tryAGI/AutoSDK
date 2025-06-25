//HintName: G.Commands.ReposGetEnvironmentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ReposGetEnvironmentCommand : global::System.CommandLine.Command
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
            global::G.Environment response,
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

        public ReposGetEnvironmentCommand(G.IApi client) : base(
            name: "repos",
            description: @"> [!NOTE]
> To get information about name patterns that branches must match in order to deploy to this environment, see ""[Get a deployment branch policy](/rest/deployments/branch-policies#get-a-deployment-branch-policy).""

Anyone with read access to the repository can use this endpoint.

OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.")
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
            var response = await _client.Repos.ReposGetEnvironmentAsync(
                owner: owner,
                repo: repo,
                environmentName: environmentName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}