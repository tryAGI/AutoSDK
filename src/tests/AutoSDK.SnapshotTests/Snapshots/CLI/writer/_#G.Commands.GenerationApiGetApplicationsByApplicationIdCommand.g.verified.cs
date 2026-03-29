//HintName: G.Commands.GenerationApiGetApplicationsByApplicationIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GenerationApiGetApplicationsByApplicationIdCommand : global::System.CommandLine.Command
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

            global::G.ApplicationWithInputs response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ApplicationId { get; } = new(
            name: "applicationId")
        {
            Description = @"Unique identifier of the application to retrieve.",
        };



        public GenerationApiGetApplicationsByApplicationIdCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Retrieves detailed information for a specific no-code agent (formerly called no-code applications), including its configuration and current status.")
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
            var response = await _client.GenerationApi.GetApplicationsByApplicationIdAsync(
                applicationId: applicationId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}