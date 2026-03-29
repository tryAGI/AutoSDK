//HintName: G.Commands.GenerationApiGetApplicationsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GenerationApiGetApplicationsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetApplicationsOrder? order,
            global::System.Guid? before,
            global::System.Guid? after,
            int? limit,
            global::G.ApplicationType? type,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.GetApplicationsResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::G.GetApplicationsOrder?> Order { get; } = new(
            name: "order")
        {
            Description = @"Sort order for the results based on creation time.",
        };

        private global::System.CommandLine.Option<global::System.Guid?> Before { get; } = new(
            name: "before")
        {
            Description = @"Return results before this application ID for pagination.",
        };

        private global::System.CommandLine.Option<global::System.Guid?> After { get; } = new(
            name: "after")
        {
            Description = @"Return results after this application ID for pagination.",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = @"Maximum number of applications to return in the response.",
        };

        private global::System.CommandLine.Option<global::G.ApplicationType?> Type { get; } = new(
            name: "type")
        {
            Description = @"Filter applications by their type.",
        };


        public GenerationApiGetApplicationsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Retrieves a paginated list of no-code agents (formerly called no-code applications) with optional filtering and sorting capabilities.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Order);
            Options.Add(Before);
            Options.Add(After);
            Options.Add(Limit);
            Options.Add(Type);

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
            var type = parseResult.GetRequiredValue(Type);

            Validate(
                parseResult: parseResult,
                order: order,
                before: before,
                after: after,
                limit: limit,
                type: type,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.GenerationApi.GetApplicationsAsync(
                order: order,
                before: before,
                after: after,
                limit: limit,
                type: type,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}