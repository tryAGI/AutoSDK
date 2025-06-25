//HintName: G.Commands.CreateModerationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateModerationCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::G.OneOf<global::G.CreateModerationRequestInputVariant3ItemVariant1, global::G.CreateModerationRequestInputVariant3ItemVariant2>>> input,
            global::G.AnyOf<string, global::G.CreateModerationRequestModel?>? model,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CreateModerationResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.OneOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::G.OneOf<global::G.CreateModerationRequestInputVariant3ItemVariant1, global::G.CreateModerationRequestInputVariant3ItemVariant2>>>> Input { get; } = new(
            name: "input")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.AnyOf<string, global::G.CreateModerationRequestModel?>?> Model { get; } = new(
            name: "model")
        {
            Description = "",
        };
        public CreateModerationCommand(G.IOpenAiClient client) : base(
            name: "create",
            description: @"")
        {
            _client = client;

            Arguments.Add(Input);
            Options.Add(Model);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var input = parseResult.GetRequiredValue(Input);
            var model = parseResult.GetRequiredValue(Model);

            Validate(
                parseResult: parseResult,
                input: input,
                model: model,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Moderations.CreateModerationAsync(
                input: input,
                model: model,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}