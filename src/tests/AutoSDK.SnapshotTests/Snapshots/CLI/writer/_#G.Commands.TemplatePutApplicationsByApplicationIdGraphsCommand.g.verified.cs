//HintName: G.Commands.TemplatePutApplicationsByApplicationIdGraphsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TemplatePutApplicationsByApplicationIdGraphsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string applicationId,
            global::System.Collections.Generic.IList<global::System.Guid> graphIds,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.ApplicationGraphsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ApplicationId { get; } = new(
            name: "applicationId")
        {
            Description = @"The ID of the no-code agent to update.

Only no-code agents with chat capabilities can have associated Knowledge Graphs. No-code agents with text generation and research capabilities do not support Knowledge Graphs.",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::System.Guid>> GraphIds { get; } = new(
            name: "graphIds")
        {
            Description = @"A list of Knowledge Graph IDs to associate with the application. Note that this will replace the existing list of Knowledge Graphs associated with the application, not add to it.",
        };



        public TemplatePutApplicationsByApplicationIdGraphsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "put",
            description: @"Updates the list of Knowledge Graphs associated with a no-code chat agent.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ApplicationId);
            Arguments.Add(GraphIds);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var applicationId = parseResult.GetRequiredValue(ApplicationId);
            var graphIds = parseResult.GetRequiredValue(GraphIds);

            Validate(
                parseResult: parseResult,
                applicationId: applicationId,
                graphIds: graphIds,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Template.PutApplicationsByApplicationIdGraphsAsync(
                applicationId: applicationId,
                graphIds: graphIds,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}