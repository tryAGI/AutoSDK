//HintName: G.Commands.CompletionsCreateChatCompletionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CompletionsCreateChatCompletionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            string response,
            global::System.Threading.CancellationToken cancellationToken);




        public CompletionsCreateChatCompletionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Create a chat completion using the provided parameters.

Generates a completion response based on the chat messages and model parameters provided.
The response can be either a full completion or streamed chunks depending on the request parameters.

Args:
    params: Parameters for creating the chat completion including messages, model selection,
           and generation settings
    user: The authenticated user making the request

Returns:
    Either a ChatCompletion containing the full response, or ChatCompletionChunk for streaming

Raises:
    HTTPException: If there is an error creating the completion (500)")
        {
            _client = client;
            _serviceProvider = serviceProvider;


            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            Validate(
                parseResult: parseResult,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Completions.CreateChatCompletionAsync(
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}