//HintName: G.Commands.AliasesUpdateAliasesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AliasesUpdateAliasesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? timeout,
            global::System.Collections.Generic.IList<global::G.AliasOperations> actions,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.UpdateAliasesResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.AliasOperations>> Actions { get; } = new(
            name: "actions")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> Timeout { get; } = new(
            name: "timeout")
        {
            Description = @"Wait for operation commit timeout in seconds.
If timeout is reached - request will return with service error.",
        };


        public AliasesUpdateAliasesCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Actions);
            Options.Add(Timeout);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var timeout = parseResult.GetRequiredValue(Timeout);
            var actions = parseResult.GetRequiredValue(Actions);

            Validate(
                parseResult: parseResult,
                timeout: timeout,
                actions: actions,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Aliases.UpdateAliasesAsync(
                timeout: timeout,
                actions: actions,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}