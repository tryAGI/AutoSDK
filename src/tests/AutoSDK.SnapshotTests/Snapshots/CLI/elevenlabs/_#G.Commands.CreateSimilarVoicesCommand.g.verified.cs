//HintName: G.Commands.CreateSimilarVoicesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateSimilarVoicesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            byte[]? audioFile,
            string? audioFilename,
            double? similarityThreshold,
            int? topK,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetLibraryVoicesResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<byte[]?> AudioFile { get; } = new(
            name: "audioFile")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> AudioFilename { get; } = new(
            name: "audioFilename")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<double?> SimilarityThreshold { get; } = new(
            name: "similarityThreshold")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> TopK { get; } = new(
            name: "topK")
        {
            Description = "",
        };
        public CreateSimilarVoicesCommand(G.IApi client) : base(
            name: "create",
            description: @"Returns a list of shared voices similar to the provided audio sample. If neither similarity_threshold nor top_k is provided, we will apply default values.")
        {
            _client = client;

            Options.Add(XiApiKey);
            Options.Add(AudioFile);
            Options.Add(AudioFilename);
            Options.Add(SimilarityThreshold);
            Options.Add(TopK);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var audioFile = parseResult.GetRequiredValue(AudioFile);
            var audioFilename = parseResult.GetRequiredValue(AudioFilename);
            var similarityThreshold = parseResult.GetRequiredValue(SimilarityThreshold);
            var topK = parseResult.GetRequiredValue(TopK);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                audioFile: audioFile,
                audioFilename: audioFilename,
                similarityThreshold: similarityThreshold,
                topK: topK,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Voices.CreateSimilarVoicesAsync(
                xiApiKey: xiApiKey,
                audioFile: audioFile,
                audioFilename: audioFilename,
                similarityThreshold: similarityThreshold,
                topK: topK,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}