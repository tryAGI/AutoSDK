//HintName: G.Commands.ExperimentsFindFeedbackScoreNamesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ExperimentsFindFeedbackScoreNamesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? experimentIds,
            global::System.Guid? projectId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.FeedbackScoreNamesPublic response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> ExperimentIds { get; } = new(
            name: "experimentIds")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Guid?> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = @"",
        };


        public ExperimentsFindFeedbackScoreNamesCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "find",
            description: @"Find Feedback Score names")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(ExperimentIds);
            Options.Add(ProjectId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var experimentIds = parseResult.GetRequiredValue(ExperimentIds);
            var projectId = parseResult.GetRequiredValue(ProjectId);

            Validate(
                parseResult: parseResult,
                experimentIds: experimentIds,
                projectId: projectId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Experiments.FindFeedbackScoreNamesAsync(
                experimentIds: experimentIds,
                projectId: projectId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}