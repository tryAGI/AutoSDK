//HintName: G.Commands.ListFilesV1OpenaiFilesGetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListFilesV1OpenaiFilesGetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? after,
            string? purpose,
            string? order,
            int? limit,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Purpose { get; } = new(
            name: "purpose")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> Order { get; } = new(
            name: "order")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = @"",
        };
        public ListFilesV1OpenaiFilesGetCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "list",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(After);
            Options.Add(Purpose);
            Options.Add(Order);
            Options.Add(Limit);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var after = parseResult.GetRequiredValue(After);
            var purpose = parseResult.GetRequiredValue(Purpose);
            var order = parseResult.GetRequiredValue(Order);
            var limit = parseResult.GetRequiredValue(Limit);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                after: after,
                purpose: purpose,
                order: order,
                limit: limit,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ListFilesV1OpenaiFilesGetAsync(
                after: after,
                purpose: purpose,
                order: order,
                limit: limit,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}