//HintName: G.Commands.ManageMultilingualGlossariesCreateMultilingualGlossaryCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ManageMultilingualGlossariesCreateMultilingualGlossaryCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string name,
            global::System.Collections.Generic.IList<global::G.GlossaryDictionary> dictionaries,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.MultilingualGlossary response,
            global::System.Threading.CancellationToken cancellationToken);

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = @"Name to be associated with the glossary.",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.GlossaryDictionary>> Dictionaries { get; } = new(
            name: "dictionaries")
        {
            Description = @"Dictionaries to populate the glossary with.",
        };



        public ManageMultilingualGlossariesCreateMultilingualGlossaryCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Name);
            Arguments.Add(Dictionaries);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var name = parseResult.GetRequiredValue(Name);
            var dictionaries = parseResult.GetRequiredValue(Dictionaries);

            Validate(
                parseResult: parseResult,
                name: name,
                dictionaries: dictionaries,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.ManageMultilingualGlossaries.CreateMultilingualGlossaryAsync(
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