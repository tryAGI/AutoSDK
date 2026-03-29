//HintName: G.Commands.TemplateGetApplicationsByApplicationIdGraphsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TemplateGetApplicationsByApplicationIdGraphsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string applicationId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.ApplicationGraphsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ApplicationId { get; } = new(
            name: "applicationId")
        {
            Description = @"The ID of the no-code agent for which to retrieve Knowledge Graphs.",
        };



        public TemplateGetApplicationsByApplicationIdGraphsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Retrieve Knowledge Graphs associated with a no-code agent that has chat capabilities.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ApplicationId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var applicationId = parseResult.GetRequiredValue(ApplicationId);

            Validate(
                parseResult: parseResult,
                applicationId: applicationId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Template.GetApplicationsByApplicationIdGraphsAsync(
                applicationId: applicationId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}