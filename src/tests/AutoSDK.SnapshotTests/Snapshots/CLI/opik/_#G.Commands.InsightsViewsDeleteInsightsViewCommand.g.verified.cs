//HintName: G.Commands.InsightsViewsDeleteInsightsViewCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class InsightsViewsDeleteInsightsViewCommand : global::System.CommandLine.Command
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
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> InsightsViewId { get; } = new(
            name: "insightsViewId")
        {
            Description = @"",
        };



        public InsightsViewsDeleteInsightsViewCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "delete",
            description: @"Delete insights view by id")
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
            await _client.InsightsViews.DeleteInsightsViewAsync(
                insightsViewId: insightsViewId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}