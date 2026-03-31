//HintName: G.Commands.PronunciationDictsPronunciationDictsCreateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PronunciationDictsPronunciationDictsCreateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.PronunciationDictsCreateCartesiaVersion cartesiaVersion,
            string name,
            global::System.Collections.Generic.IList<global::G.PronunciationDictItem>? items,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.PronunciationDict response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.PronunciationDictsCreateCartesiaVersion> CartesiaVersion { get; } = new(
            name: "cartesiaVersion")
        {
            Description = @"API version header. Must be set to the API version, e.g. '2024-06-10'.",
        };

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = @"Name for the new pronunciation dictionary",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.PronunciationDictItem>?> Items { get; } = new(
            name: "items")
        {
            Description = @"Optional initial list of pronunciation mappings",
        };


        public PronunciationDictsPronunciationDictsCreateCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "pronunciation",
            description: @"Create a new pronunciation dictionary")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CartesiaVersion);
            Arguments.Add(Name);
            Options.Add(Items);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var cartesiaVersion = parseResult.GetRequiredValue(CartesiaVersion);
            var name = parseResult.GetRequiredValue(Name);
            var items = parseResult.GetRequiredValue(Items);

            Validate(
                parseResult: parseResult,
                cartesiaVersion: cartesiaVersion,
                name: name,
                items: items,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.PronunciationDicts.PronunciationDictsCreateAsync(
                cartesiaVersion: cartesiaVersion,
                name: name,
                items: items,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}