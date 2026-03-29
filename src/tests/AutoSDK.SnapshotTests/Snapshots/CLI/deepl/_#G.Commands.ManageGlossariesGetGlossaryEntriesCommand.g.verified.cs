//HintName: G.Commands.ManageGlossariesGetGlossaryEntriesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ManageGlossariesGetGlossaryEntriesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string glossaryId,
            global::G.GetGlossaryEntriesAccept? accept,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> GlossaryId { get; } = new(
            name: "glossaryId")
        {
            Description = @"A unique ID assigned to the glossary.",
        };

        private global::System.CommandLine.Option<global::G.GetGlossaryEntriesAccept?> Accept { get; } = new(
            name: "accept")
        {
            Description = @"The requested format of the returned glossary entries. Currently, supports only `text/tab-separated-values`.",
        };


        public ManageGlossariesGetGlossaryEntriesCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"List the entries of a single glossary in the format specified by the `Accept` header.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(GlossaryId);
            Options.Add(Accept);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var glossaryId = parseResult.GetRequiredValue(GlossaryId);
            var accept = parseResult.GetRequiredValue(Accept);

            Validate(
                parseResult: parseResult,
                glossaryId: glossaryId,
                accept: accept,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.ManageGlossaries.GetGlossaryEntriesAsync(
                glossaryId: glossaryId,
                accept: accept,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}