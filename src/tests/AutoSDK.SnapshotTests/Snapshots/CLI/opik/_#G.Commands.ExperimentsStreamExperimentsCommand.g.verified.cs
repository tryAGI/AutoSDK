//HintName: G.Commands.ExperimentsStreamExperimentsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ExperimentsStreamExperimentsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string name,
            int? limit,
            global::System.Guid? lastRetrievedId,
            string? projectName,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            byte[] response,
            global::System.Threading.CancellationToken cancellationToken);

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Guid?> LastRetrievedId { get; } = new(
            name: "lastRetrievedId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> ProjectName { get; } = new(
            name: "projectName")
        {
            Description = @"",
        };


        public ExperimentsStreamExperimentsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "stream",
            description: @"Stream experiments")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Name);
            Options.Add(Limit);
            Options.Add(LastRetrievedId);
            Options.Add(ProjectName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var name = parseResult.GetRequiredValue(Name);
            var limit = parseResult.GetRequiredValue(Limit);
            var lastRetrievedId = parseResult.GetRequiredValue(LastRetrievedId);
            var projectName = parseResult.GetRequiredValue(ProjectName);

            Validate(
                parseResult: parseResult,
                name: name,
                limit: limit,
                lastRetrievedId: lastRetrievedId,
                projectName: projectName,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Experiments.StreamExperimentsAsync(
                name: name,
                limit: limit,
                lastRetrievedId: lastRetrievedId,
                projectName: projectName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}