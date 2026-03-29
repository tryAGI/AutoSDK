//HintName: G.Commands.KgApiFindGraphsWithFileStatusCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class KgApiFindGraphsWithFileStatusCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.FindGraphsWithFileStatusOrder? order,
            global::System.Guid? before,
            global::System.Guid? after,
            int? limit,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.GraphsResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::G.FindGraphsWithFileStatusOrder?> Order { get; } = new(
            name: "order")
        {
            Description = @"Specifies the order of the results. Valid values are asc for ascending and desc for descending.",
        };

        private global::System.CommandLine.Option<global::System.Guid?> Before { get; } = new(
            name: "before")
        {
            Description = @"The ID of the first object in the previous page. This parameter instructs the API to return the previous page of results.",
        };

        private global::System.CommandLine.Option<global::System.Guid?> After { get; } = new(
            name: "after")
        {
            Description = @"The ID of the last object in the previous page. This parameter instructs the API to return the next page of results.",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = @"Specifies the maximum number of objects returned in a page. The default value is 50. The minimum value is 1, and the maximum value is 100.",
        };


        public KgApiFindGraphsWithFileStatusCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "find",
            description: @"Retrieve a list of Knowledge Graphs.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Order);
            Options.Add(Before);
            Options.Add(After);
            Options.Add(Limit);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var order = parseResult.GetRequiredValue(Order);
            var before = parseResult.GetRequiredValue(Before);
            var after = parseResult.GetRequiredValue(After);
            var limit = parseResult.GetRequiredValue(Limit);

            Validate(
                parseResult: parseResult,
                order: order,
                before: before,
                after: after,
                limit: limit,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.KgApi.FindGraphsWithFileStatusAsync(
                order: order,
                before: before,
                after: after,
                limit: limit,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}