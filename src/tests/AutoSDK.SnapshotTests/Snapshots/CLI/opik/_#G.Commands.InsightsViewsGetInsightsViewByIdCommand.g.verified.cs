//HintName: G.Commands.InsightsViewsGetInsightsViewByIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class InsightsViewsGetInsightsViewByIdCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid insightsViewId,
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



        public InsightsViewsGetInsightsViewByIdCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Get insights view by id")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(InsightsViewId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var insightsViewId = parseResult.GetRequiredValue(InsightsViewId);

            Validate(
                parseResult: parseResult,
                insightsViewId: insightsViewId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.InsightsViews.GetInsightsViewByIdAsync(
                insightsViewId: insightsViewId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}