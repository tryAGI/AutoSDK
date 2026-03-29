//HintName: G.Commands.TemplateGetApplicationsByApplicationIdJobsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TemplateGetApplicationsByApplicationIdJobsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string applicationId,
            global::G.ApiJobStatus? status,
            long? offset,
            int? limit,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.GetAsyncApplicationJobsResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ApplicationId { get; } = new(
            name: "applicationId")
        {
            Description = @"The ID of the no-code app for which to retrieve jobs.",
        };

        private global::System.CommandLine.Option<global::G.ApiJobStatus?> Status { get; } = new(
            name: "status")
        {
            Description = @"The status of the job.",
        };

        private global::System.CommandLine.Option<long?> Offset { get; } = new(
            name: "offset")
        {
            Description = @"The pagination offset for retrieving the jobs.",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = @"The pagination limit for retrieving the jobs.",
        };


        public TemplateGetApplicationsByApplicationIdJobsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Retrieve all jobs created via the async API, linked to the provided application ID (or alias).")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ApplicationId);
            Options.Add(Status);
            Options.Add(Offset);
            Options.Add(Limit);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var applicationId = parseResult.GetRequiredValue(ApplicationId);
            var status = parseResult.GetRequiredValue(Status);
            var offset = parseResult.GetRequiredValue(Offset);
            var limit = parseResult.GetRequiredValue(Limit);

            Validate(
                parseResult: parseResult,
                applicationId: applicationId,
                status: status,
                offset: offset,
                limit: limit,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Template.GetApplicationsByApplicationIdJobsAsync(
                applicationId: applicationId,
                status: status,
                offset: offset,
                limit: limit,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}