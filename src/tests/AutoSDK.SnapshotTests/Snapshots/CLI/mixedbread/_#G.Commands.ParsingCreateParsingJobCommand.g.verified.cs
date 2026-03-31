//HintName: G.Commands.ParsingCreateParsingJobCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ParsingCreateParsingJobCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string fileId,
            global::System.Collections.Generic.IList<global::G.ElementType>? elementTypes,
            global::G.ChunkingStrategy? chunkingStrategy,
            global::G.ReturnFormat? returnFormat,
            global::G.Mode? mode,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.ParsingJob response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> FileId { get; } = new(
            name: "fileId")
        {
            Description = @"The ID of the file to parse",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.ElementType>?> ElementTypes { get; } = new(
            name: "elementTypes")
        {
            Description = @"The elements to extract from the document",
        };

        private global::System.CommandLine.Option<global::G.ChunkingStrategy?> ChunkingStrategy { get; } = new(
            name: "chunkingStrategy")
        {
            Description = @"The strategy to use for chunking the content",
        };

        private global::System.CommandLine.Option<global::G.ReturnFormat?> ReturnFormat { get; } = new(
            name: "returnFormat")
        {
            Description = @"The format of the returned content",
        };

        private global::System.CommandLine.Option<global::G.Mode?> Mode { get; } = new(
            name: "mode")
        {
            Description = @"The strategy to use for OCR",
        };


        public ParsingCreateParsingJobCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Start a parse job for the provided file.

Args:
    params: The parameters for creating a parse job.

Returns:
    The created parsing job.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(FileId);
            Options.Add(ElementTypes);
            Options.Add(ChunkingStrategy);
            Options.Add(ReturnFormat);
            Options.Add(Mode);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var fileId = parseResult.GetRequiredValue(FileId);
            var elementTypes = parseResult.GetRequiredValue(ElementTypes);
            var chunkingStrategy = parseResult.GetRequiredValue(ChunkingStrategy);
            var returnFormat = parseResult.GetRequiredValue(ReturnFormat);
            var mode = parseResult.GetRequiredValue(Mode);

            Validate(
                parseResult: parseResult,
                fileId: fileId,
                elementTypes: elementTypes,
                chunkingStrategy: chunkingStrategy,
                returnFormat: returnFormat,
                mode: mode,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Parsing.CreateParsingJobAsync(
                fileId: fileId,
                elementTypes: elementTypes,
                chunkingStrategy: chunkingStrategy,
                returnFormat: returnFormat,
                mode: mode,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}