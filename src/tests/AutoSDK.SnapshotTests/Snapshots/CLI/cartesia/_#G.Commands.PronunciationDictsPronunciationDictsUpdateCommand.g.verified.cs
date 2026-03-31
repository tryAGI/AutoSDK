//HintName: G.Commands.PronunciationDictsPronunciationDictsUpdateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PronunciationDictsPronunciationDictsUpdateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.PronunciationDictsUpdateCartesiaVersion cartesiaVersion,
            string id,
            string? name,
            global::System.Collections.Generic.IList<global::G.PronunciationDictItem>? items,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.PronunciationDict response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.PronunciationDictsUpdateCartesiaVersion> CartesiaVersion { get; } = new(
            name: "cartesiaVersion")
        {
            Description = @"API version header. Must be set to the API version, e.g. '2024-06-10'.",
        };

        private global::System.CommandLine.Argument<string> Id { get; } = new(
            name: "id")
        {
            Description = @"ID of the pronunciation dictionary to update",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"New name for the pronunciation dictionary",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.PronunciationDictItem>?> Items { get; } = new(
            name: "items")
        {
            Description = @"Updated list of pronunciation mappings",
        };


        public PronunciationDictsPronunciationDictsUpdateCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "pronunciation",
            description: @"Update a pronunciation dictionary")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(CartesiaVersion);
            Arguments.Add(Id);
            Options.Add(Name);
            Options.Add(Items);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var cartesiaVersion = parseResult.GetRequiredValue(CartesiaVersion);
            var id = parseResult.GetRequiredValue(Id);
            var name = parseResult.GetRequiredValue(Name);
            var items = parseResult.GetRequiredValue(Items);

            Validate(
                parseResult: parseResult,
                cartesiaVersion: cartesiaVersion,
                id: id,
                name: name,
                items: items,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.PronunciationDicts.PronunciationDictsUpdateAsync(
                cartesiaVersion: cartesiaVersion,
                id: id,
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