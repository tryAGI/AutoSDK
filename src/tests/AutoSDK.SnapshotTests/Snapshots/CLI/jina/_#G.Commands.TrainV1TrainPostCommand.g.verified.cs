//HintName: G.Commands.TrainV1TrainPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TrainV1TrainPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? model,
            string? classifierId,
            global::G.TrainingAPIInputVisibility? visibility,
            global::G.AnyOf<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.TextExampleDoc, global::G.ImageExampleDoc>>, global::G.TextExampleDoc, global::G.ImageExampleDoc> input,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.TrainingOutput response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.AnyOf<global::System.Collections.Generic.IList<global::G.AnyOf<global::G.TextExampleDoc, global::G.ImageExampleDoc>>, global::G.TextExampleDoc, global::G.ImageExampleDoc>> Input { get; } = new(
            name: "input")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Model { get; } = new(
            name: "model")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> ClassifierId { get; } = new(
            name: "classifierId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.TrainingAPIInputVisibility?> Visibility { get; } = new(
            name: "visibility")
        {
            Description = "",
        };
        public TrainV1TrainPostCommand(G.IApi client) : base(
            name: "train",
            description: @"Rank pairs.")
        {
            _client = client;

            Arguments.Add(Input);
            Options.Add(Model);
            Options.Add(ClassifierId);
            Options.Add(Visibility);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var model = parseResult.GetRequiredValue(Model);
            var classifierId = parseResult.GetRequiredValue(ClassifierId);
            var visibility = parseResult.GetRequiredValue(Visibility);
            var input = parseResult.GetRequiredValue(Input);

            Validate(
                parseResult: parseResult,
                model: model,
                classifierId: classifierId,
                visibility: visibility,
                input: input,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Classification.TrainV1TrainPostAsync(
                model: model,
                classifierId: classifierId,
                visibility: visibility,
                input: input,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}