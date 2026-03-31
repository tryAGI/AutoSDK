//HintName: G.Commands.ExtractionsCreateExtractionJobCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ExtractionsCreateExtractionJobCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string fileId,
            object jsonSchema,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.ExtractionJob response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> FileId { get; } = new(
            name: "fileId")
        {
            Description = @"The ID of the file to extract from",
        };

        private global::System.CommandLine.Argument<object> JsonSchema { get; } = new(
            name: "jsonSchema")
        {
            Description = @"The JSON schema to use for extraction",
        };



        public ExtractionsCreateExtractionJobCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Start an extraction job for the provided file and schema.

Args:
    params: The parameters for creating an extraction job.

Returns:
    The created extraction job.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(FileId);
            Arguments.Add(JsonSchema);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var fileId = parseResult.GetRequiredValue(FileId);
            var jsonSchema = parseResult.GetRequiredValue(JsonSchema);

            Validate(
                parseResult: parseResult,
                fileId: fileId,
                jsonSchema: jsonSchema,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Extractions.CreateExtractionJobAsync(
                fileId: fileId,
                jsonSchema: jsonSchema,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}