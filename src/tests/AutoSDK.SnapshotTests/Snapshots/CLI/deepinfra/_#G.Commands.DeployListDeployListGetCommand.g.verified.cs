//HintName: G.Commands.DeployListDeployListGetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeployListDeployListGetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? status,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.DeploymentOut> response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> Status { get; } = new(
            name: "status")
        {
            Description = @"A list of statuses that should be returned, separated by comma. Allowed values in the list are: initializing,deploying,running,failed,deleted",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = @"",
        };
        public DeployListDeployListGetCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "deploy",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Status);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var status = parseResult.GetRequiredValue(Status);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                status: status,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.DeployListDeployListGetAsync(
                status: status,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}