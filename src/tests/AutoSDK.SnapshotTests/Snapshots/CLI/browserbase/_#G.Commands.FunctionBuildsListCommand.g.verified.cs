//HintName: G.Commands.FunctionBuildsListCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class FunctionBuildsListCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int? offset,
            int? limit,
            string? status,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.FunctionBuildsListResponse response,
            global::System.Threading.CancellationToken cancellationToken);


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

        private global::System.CommandLine.Option<string?> Status { get; } = new(
            name: "status")
        {
            Description = @"",
        };


        public FunctionBuildsListCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "function",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Offset);
            Options.Add(Limit);
            Options.Add(Status);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var offset = parseResult.GetRequiredValue(Offset);
            var limit = parseResult.GetRequiredValue(Limit);
            var status = parseResult.GetRequiredValue(Status);

            Validate(
                parseResult: parseResult,
                offset: offset,
                limit: limit,
                status: status,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.FunctionBuildsListAsync(
                offset: offset,
                limit: limit,
                status: status,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}