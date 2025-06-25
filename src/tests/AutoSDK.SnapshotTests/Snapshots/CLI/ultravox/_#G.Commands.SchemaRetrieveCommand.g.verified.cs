//HintName: G.Commands.SchemaRetrieveCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class SchemaRetrieveCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.SchemaRetrieveFormat? format,
            global::G.SchemaRetrieveLang? lang,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::G.SchemaRetrieveFormat?> Format { get; } = new(
            name: "format")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.SchemaRetrieveLang?> Lang { get; } = new(
            name: "lang")
        {
            Description = @"",
        };
        public SchemaRetrieveCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "schema",
            description: @"OpenApi3 schema for this API. Format can be selected via content negotiation.

- YAML: application/vnd.oai.openapi
- JSON: application/vnd.oai.openapi+json")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Format);
            Options.Add(Lang);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var format = parseResult.GetRequiredValue(Format);
            var lang = parseResult.GetRequiredValue(Lang);

            Validate(
                parseResult: parseResult,
                format: format,
                lang: lang,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Schema.SchemaRetrieveAsync(
                format: format,
                lang: lang,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}