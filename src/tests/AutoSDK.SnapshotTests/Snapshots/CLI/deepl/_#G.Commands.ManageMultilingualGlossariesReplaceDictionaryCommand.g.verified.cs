//HintName: G.Commands.ManageMultilingualGlossariesReplaceDictionaryCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ManageMultilingualGlossariesReplaceDictionaryCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string glossaryId,
            global::G.GlossarySourceLanguage? sourceLang,
            global::G.GlossaryTargetLanguage? targetLang,
            string? entries,
            global::G.GlossaryEntriesFormat? entriesFormat,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.MultilingualGlossaryEntriesInformation response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> GlossaryId { get; } = new(
            name: "glossaryId")
        {
            Description = @"A unique ID assigned to the glossary.",
        };

        private global::System.CommandLine.Option<global::G.GlossarySourceLanguage?> SourceLang { get; } = new(
            name: "sourceLang")
        {
            Description = @"The language in which the source texts in the glossary are specified.",
        };

        private global::System.CommandLine.Option<global::G.GlossaryTargetLanguage?> TargetLang { get; } = new(
            name: "targetLang")
        {
            Description = @"The language in which the target texts in the glossary are specified.",
        };

        private global::System.CommandLine.Option<string?> Entries { get; } = new(
            name: "entries")
        {
            Description = @"The entries of the glossary. The entries have to be specified in the format provided by the `entries_format` parameter.",
        };

        private global::System.CommandLine.Option<global::G.GlossaryEntriesFormat?> EntriesFormat { get; } = new(
            name: "entriesFormat")
        {
            Description = @"The format in which the glossary entries are provided. Formats currently available:
- `tsv` (default) - tab-separated values
- `csv` - comma-separated values

See [Supported Glossary Formats](https://www.deepl.com/docs-api/glossaries/formats) for details about each format.",
        };


        public ManageMultilingualGlossariesReplaceDictionaryCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "replace",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(GlossaryId);
            Options.Add(SourceLang);
            Options.Add(TargetLang);
            Options.Add(Entries);
            Options.Add(EntriesFormat);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var glossaryId = parseResult.GetRequiredValue(GlossaryId);
            var sourceLang = parseResult.GetRequiredValue(SourceLang);
            var targetLang = parseResult.GetRequiredValue(TargetLang);
            var entries = parseResult.GetRequiredValue(Entries);
            var entriesFormat = parseResult.GetRequiredValue(EntriesFormat);

            Validate(
                parseResult: parseResult,
                glossaryId: glossaryId,
                sourceLang: sourceLang,
                targetLang: targetLang,
                entries: entries,
                entriesFormat: entriesFormat,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ManageMultilingualGlossaries.ReplaceDictionaryAsync(
                glossaryId: glossaryId,
                sourceLang: sourceLang,
                targetLang: targetLang,
                entries: entries,
                entriesFormat: entriesFormat,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}