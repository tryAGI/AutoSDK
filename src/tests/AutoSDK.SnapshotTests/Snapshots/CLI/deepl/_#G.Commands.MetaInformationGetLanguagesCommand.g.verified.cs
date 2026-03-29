//HintName: G.Commands.MetaInformationGetLanguagesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MetaInformationGetLanguagesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetLanguagesType? type,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::System.Collections.Generic.IList<global::G.GetLanguagesResponseItem> response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::G.GetLanguagesType?> Type { get; } = new(
            name: "type")
        {
            Description = @"Sets whether source or target languages should be listed. Possible options are:
 * `source` (default): For languages that can be used in the `source_lang` parameter of [translate](https://www.deepl.com/docs-api/translate-text/translate-text) requests.
 * `target`: For languages that can be used in the `target_lang` parameter of [translate](https://www.deepl.com/docs-api/translate-text/translate-text) requests.",
        };


        public MetaInformationGetLanguagesCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Retrieve the list of languages that are currently supported for translation, either as source or target language, respectively.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Type);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var type = parseResult.GetRequiredValue(Type);

            Validate(
                parseResult: parseResult,
                type: type,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.MetaInformation.GetLanguagesAsync(
                type: type,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}