//HintName: G.Commands.CallsDestroyCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CallsDestroyCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid callId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> CallId { get; } = new(
            name: "callId")
        {
            Description = @"",
        };

        public CallsDestroyCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "calls",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CallId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var callId = parseResult.GetRequiredValue(CallId);

            Validate(
                parseResult: parseResult,
                callId: callId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Calls.CallsDestroyAsync(
                callId: callId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}