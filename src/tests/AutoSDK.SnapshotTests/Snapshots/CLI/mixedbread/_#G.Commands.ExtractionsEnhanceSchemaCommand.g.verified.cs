//HintName: G.Commands.ExtractionsEnhanceSchemaCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ExtractionsEnhanceSchemaCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            object jsonSchema,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.EnhancedJsonSchema response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<object> JsonSchema { get; } = new(
            name: "jsonSchema")
        {
            Description = @"The JSON schema to enhance",
        };



        public ExtractionsEnhanceSchemaCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "enhance",
            description: @"Enhance a schema by enriching the descriptions to aid extraction.

Args:
    params: The parameters for enhancing a schema.

Returns:
    The enhanced schema.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(JsonSchema);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var jsonSchema = parseResult.GetRequiredValue(JsonSchema);

            Validate(
                parseResult: parseResult,
                jsonSchema: jsonSchema,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Extractions.EnhanceSchemaAsync(
                jsonSchema: jsonSchema,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}