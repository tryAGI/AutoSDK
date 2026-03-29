//HintName: G.Commands.InsightsViewsUpdateInsightsViewCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class InsightsViewsUpdateInsightsViewCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid insightsViewId,
            string? name,
            global::G.DashboardUpdatePublicType? type,
            string? description,
            global::G.JsonNodePublic? config,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.DashboardPublic response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> InsightsViewId { get; } = new(
            name: "insightsViewId")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.DashboardUpdatePublicType?> Type { get; } = new(
            name: "type")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.JsonNodePublic?> Config { get; } = new(
            name: "config")
        {
            Description = @"",
        };


        public InsightsViewsUpdateInsightsViewCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"Update insights view by id. Partial updates are supported - only provided fields will be updated.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(InsightsViewId);
            Options.Add(Name);
            Options.Add(Type);
            Options.Add(Description);
            Options.Add(Config);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var insightsViewId = parseResult.GetRequiredValue(InsightsViewId);
            var name = parseResult.GetRequiredValue(Name);
            var type = parseResult.GetRequiredValue(Type);
            var description = parseResult.GetRequiredValue(Description);
            var config = parseResult.GetRequiredValue(Config);

            Validate(
                parseResult: parseResult,
                insightsViewId: insightsViewId,
                name: name,
                type: type,
                description: description,
                config: config,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.InsightsViews.UpdateInsightsViewAsync(
                insightsViewId: insightsViewId,
                name: name,
                type: type,
                description: description,
                config: config,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}