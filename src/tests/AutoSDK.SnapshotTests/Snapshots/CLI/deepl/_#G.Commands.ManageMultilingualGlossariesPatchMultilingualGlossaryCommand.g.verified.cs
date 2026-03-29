//HintName: G.Commands.ManageMultilingualGlossariesPatchMultilingualGlossaryCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ManageMultilingualGlossariesPatchMultilingualGlossaryCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string glossaryId,
            string? name,
            global::System.Collections.Generic.IList<global::G.GlossaryDictionary>? dictionaries,
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

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"A unique ID assigned to a glossary.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.GlossaryDictionary>?> Dictionaries { get; } = new(
            name: "dictionaries")
        {
            Description = @"Dictionaries to edit the glossary with. Currently only supports 0 or 1 dictionaries in the array.",
        };


        public ManageMultilingualGlossariesPatchMultilingualGlossaryCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "patch",
            description: @"Edit glossary details, such as name or a dictionary for a source and target language.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(GlossaryId);
            Options.Add(Name);
            Options.Add(Dictionaries);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var glossaryId = parseResult.GetRequiredValue(GlossaryId);
            var name = parseResult.GetRequiredValue(Name);
            var dictionaries = parseResult.GetRequiredValue(Dictionaries);

            Validate(
                parseResult: parseResult,
                glossaryId: glossaryId,
                name: name,
                dictionaries: dictionaries,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ManageMultilingualGlossaries.PatchMultilingualGlossaryAsync(
                glossaryId: glossaryId,
                name: name,
                dictionaries: dictionaries,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}