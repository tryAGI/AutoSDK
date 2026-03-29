//HintName: G.Commands.FunctionsInvokeCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class FunctionsInvokeCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid id,
            object? @params,
            global::G.FunctionsInvokeRequestSessionCreateParams? sessionCreateParams,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.Invocation response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<object?> Params { get; } = new(
            name: "@params")
        {
            Description = @"JSON object that can be stored in a JSONB column",
        };

        private global::System.CommandLine.Option<global::G.FunctionsInvokeRequestSessionCreateParams?> SessionCreateParams { get; } = new(
            name: "sessionCreateParams")
        {
            Description = @"",
        };


        public FunctionsInvokeCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "functions",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Id);
            Options.Add(Params);
            Options.Add(SessionCreateParams);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var @params = parseResult.GetRequiredValue(Params);
            var sessionCreateParams = parseResult.GetRequiredValue(SessionCreateParams);

            Validate(
                parseResult: parseResult,
                id: id,
                @params: @params,
                sessionCreateParams: sessionCreateParams,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.FunctionsInvokeAsync(
                id: id,
                @params: @params,
                sessionCreateParams: sessionCreateParams,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}