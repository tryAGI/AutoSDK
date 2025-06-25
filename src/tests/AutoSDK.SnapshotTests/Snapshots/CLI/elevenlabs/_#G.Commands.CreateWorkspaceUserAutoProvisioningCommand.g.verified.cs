//HintName: G.Commands.CreateWorkspaceUserAutoProvisioningCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateWorkspaceUserAutoProvisioningCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            bool enabled,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<bool> Enabled { get; } = new(
            name: "enabled")
        {
            Description = "",
        };

        public CreateWorkspaceUserAutoProvisioningCommand(G.IApi client) : base(
            name: "create",
            description: @"Update user auto provisioning settings for the workspace.")
        {
            _client = client;

            Arguments.Add(Enabled);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var enabled = parseResult.GetRequiredValue(Enabled);

            Validate(
                parseResult: parseResult,
                enabled: enabled,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Workspace.CreateWorkspaceUserAutoProvisioningAsync(
                enabled: enabled,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}