//HintName: G.Commands.ListContainerFilesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListContainerFilesCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string containerId,
            int? limit,
            global::G.ListContainerFilesOrder? order,
            string? after,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ContainerFileListResource response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ContainerId { get; } = new(
            name: "containerId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ListContainerFilesOrder?> Order { get; } = new(
            name: "order")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = "",
        };
        public ListContainerFilesCommand(G.IOpenAiClient client) : base(
            name: "list",
            description: @"Lists container files.")
        {
            _client = client;

            Arguments.Add(ContainerId);
            Options.Add(Limit);
            Options.Add(Order);
            Options.Add(After);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var containerId = parseResult.GetRequiredValue(ContainerId);
            var limit = parseResult.GetRequiredValue(Limit);
            var order = parseResult.GetRequiredValue(Order);
            var after = parseResult.GetRequiredValue(After);

            Validate(
                parseResult: parseResult,
                containerId: containerId,
                limit: limit,
                order: order,
                after: after,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ListContainerFilesAsync(
                containerId: containerId,
                limit: limit,
                order: order,
                after: after,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}