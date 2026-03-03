//HintName: G.Commands.BatchCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class BatchCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,

            global::System.Collections.Generic.IList<string> request,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::System.Collections.Generic.Dictionary<string, object> response,
            global::System.Threading.CancellationToken cancellationToken);




        private global::System.CommandLine.Argument<string> RequestBody { get; } = new(
            name: "request-body")
        {
            Description = @"The request body as JSON.",
        };


        public BatchCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "batch",
            description: @"Returns information about the selected values.")
        {
            _client = client;
            _serviceProvider = serviceProvider;


            Arguments.Add(RequestBody);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var __requestBodyJson = parseResult.GetRequiredValue(RequestBody);
            var request = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<string>>(__requestBodyJson) ??
                throw new global::System.InvalidOperationException("Failed to deserialize request body.");

            Validate(
                parseResult: parseResult,

                request: request,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.General.BatchAsync(

                request: request,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}