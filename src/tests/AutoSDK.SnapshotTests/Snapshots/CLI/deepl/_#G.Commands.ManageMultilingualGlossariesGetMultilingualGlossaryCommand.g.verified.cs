//HintName: G.Commands.ManageMultilingualGlossariesGetMultilingualGlossaryCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ManageMultilingualGlossariesGetMultilingualGlossaryCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string glossaryId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.MultilingualGlossary response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> GlossaryId { get; } = new(
            name: "glossaryId")
        {
            Description = @"A unique ID assigned to the glossary.",
        };



        public ManageMultilingualGlossariesGetMultilingualGlossaryCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Retrieve meta information for a single glossary, omitting the glossary entries.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(GlossaryId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var glossaryId = parseResult.GetRequiredValue(GlossaryId);

            Validate(
                parseResult: parseResult,
                glossaryId: glossaryId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ManageMultilingualGlossaries.GetMultilingualGlossaryAsync(
                glossaryId: glossaryId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}