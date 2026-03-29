//HintName: G.Commands.FunctionsListVersionsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class FunctionsListVersionsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? offset,
            int? limit,
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.FunctionsListVersionsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> Offset { get; } = new(
            name: "offset")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = @"",
        };


        public FunctionsListVersionsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "functions",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Id);
            Options.Add(Offset);
            Options.Add(Limit);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var offset = parseResult.GetRequiredValue(Offset);
            var limit = parseResult.GetRequiredValue(Limit);
            var id = parseResult.GetRequiredValue(Id);

            Validate(
                parseResult: parseResult,
                offset: offset,
                limit: limit,
                id: id,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.FunctionsListVersionsAsync(
                offset: offset,
                limit: limit,
                id: id,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}