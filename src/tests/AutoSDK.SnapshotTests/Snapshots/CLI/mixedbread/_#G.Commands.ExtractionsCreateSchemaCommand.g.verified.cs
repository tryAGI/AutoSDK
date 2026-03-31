//HintName: G.Commands.ExtractionsCreateSchemaCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ExtractionsCreateSchemaCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string description,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.CreatedJsonSchema response,
            global::System.Threading.CancellationToken cancellationToken);

        private new global::System.CommandLine.Argument<string> Description { get; } = new(
            name: "description")
        {
            Description = @"Description of the data to extract",
        };



        public ExtractionsCreateSchemaCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Create a schema with the provided parameters.

Args:
    params: The parameters for creating a schema.

Returns:
    The created schema.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Description);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var description = parseResult.GetRequiredValue(Description);

            Validate(
                parseResult: parseResult,
                description: description,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Extractions.CreateSchemaAsync(
                description: description,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}