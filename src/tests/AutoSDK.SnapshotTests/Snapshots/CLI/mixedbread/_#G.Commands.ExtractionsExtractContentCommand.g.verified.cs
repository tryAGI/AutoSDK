//HintName: G.Commands.ExtractionsExtractContentCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ExtractionsExtractContentCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.TextInput, global::G.ImageUrlInput2>>> content,
            object jsonSchema,
            string? instructions,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.ExtractionResult response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.AnyOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<global::G.AnyOf<global::G.TextInput, global::G.ImageUrlInput2>>>> Content { get; } = new(
            name: "content")
        {
            Description = @"The content to extract from",
        };

        private global::System.CommandLine.Argument<object> JsonSchema { get; } = new(
            name: "jsonSchema")
        {
            Description = @"The JSON schema to use for extraction",
        };

        private global::System.CommandLine.Option<string?> Instructions { get; } = new(
            name: "instructions")
        {
            Description = @"Additional instructions for the extraction",
        };


        public ExtractionsExtractContentCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "extract",
            description: @"Extract content from a string using the provided schema.

Args:
    params: The parameters for extracting content from a string.

Returns:
    The extracted content.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Content);
            Arguments.Add(JsonSchema);
            Options.Add(Instructions);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var content = parseResult.GetRequiredValue(Content);
            var jsonSchema = parseResult.GetRequiredValue(JsonSchema);
            var instructions = parseResult.GetRequiredValue(Instructions);

            Validate(
                parseResult: parseResult,
                content: content,
                jsonSchema: jsonSchema,
                instructions: instructions,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Extractions.ExtractContentAsync(
                content: content,
                jsonSchema: jsonSchema,
                instructions: instructions,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}