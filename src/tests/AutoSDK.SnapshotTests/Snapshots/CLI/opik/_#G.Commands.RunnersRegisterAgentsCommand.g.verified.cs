//HintName: G.Commands.RunnersRegisterAgentsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class RunnersRegisterAgentsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid runnerId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> RunnerId { get; } = new(
            name: "runnerId")
        {
            Description = @"",
        };



        public RunnersRegisterAgentsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "register",
            description: @"Register or update the local runner's agent list")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(RunnerId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var runnerId = parseResult.GetRequiredValue(RunnerId);

            Validate(
                parseResult: parseResult,
                runnerId: runnerId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Runners.RegisterAgentsAsync(
                runnerId: runnerId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}