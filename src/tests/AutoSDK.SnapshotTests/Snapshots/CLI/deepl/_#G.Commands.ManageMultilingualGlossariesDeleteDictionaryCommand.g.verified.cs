//HintName: G.Commands.ManageMultilingualGlossariesDeleteDictionaryCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ManageMultilingualGlossariesDeleteDictionaryCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string glossaryId,
            global::G.GlossarySourceLanguage sourceLang,
            global::G.GlossaryTargetLanguage targetLang,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> GlossaryId { get; } = new(
            name: "glossaryId")
        {
            Description = @"A unique ID assigned to the glossary.",
        };

        private global::System.CommandLine.Argument<global::G.GlossarySourceLanguage> SourceLang { get; } = new(
            name: "sourceLang")
        {
            Description = @"The language in which the source texts in the glossary are specified.",
        };

        private global::System.CommandLine.Argument<global::G.GlossaryTargetLanguage> TargetLang { get; } = new(
            name: "targetLang")
        {
            Description = @"The language in which the target texts in the glossary are specified.",
        };



        public ManageMultilingualGlossariesDeleteDictionaryCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "delete",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(GlossaryId);
            Arguments.Add(SourceLang);
            Arguments.Add(TargetLang);

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

            Validate(
                parseResult: parseResult,
                glossaryId: glossaryId,
                sourceLang: sourceLang,
                targetLang: targetLang,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.ManageMultilingualGlossaries.DeleteDictionaryAsync(
                glossaryId: glossaryId,
                sourceLang: sourceLang,
                targetLang: targetLang,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}