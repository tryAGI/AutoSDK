//HintName: G.Commands.GenerateChatCompletionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GenerateChatCompletionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string model,
            global::System.Collections.Generic.IList<global::G.Message> messages,
            global::G.ResponseFormat? format,
            global::G.RequestOptions? options,
            bool? stream,
            int? keepAlive,
            global::System.Collections.Generic.IList<global::G.Tool>? tools,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GenerateChatCompletionResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.Message>> Messages { get; } = new(
            name: "messages")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ResponseFormat?> Format { get; } = new(
            name: "format")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.RequestOptions?> Options { get; } = new(
            name: "options")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Stream { get; } = new(
            name: "stream")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> KeepAlive { get; } = new(
            name: "keepAlive")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.Tool>?> Tools { get; } = new(
            name: "tools")
        {
            Description = "",
        };
        public GenerateChatCompletionCommand(G.IApi client) : base(
            name: "generate",
            description: @"This is a streaming endpoint, so there will be a series of responses. The final response object will include statistics and additional data from the request.")
        {
            _client = client;

            Arguments.Add(Model);
            Arguments.Add(Messages);
            Options.Add(Format);
            Options.Add(Options);
            Options.Add(Stream);
            Options.Add(KeepAlive);
            Options.Add(Tools);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var model = parseResult.GetRequiredValue(Model);
            var messages = parseResult.GetRequiredValue(Messages);
            var format = parseResult.GetRequiredValue(Format);
            var options = parseResult.GetRequiredValue(Options);
            var stream = parseResult.GetRequiredValue(Stream);
            var keepAlive = parseResult.GetRequiredValue(KeepAlive);
            var tools = parseResult.GetRequiredValue(Tools);

            Validate(
                parseResult: parseResult,
                model: model,
                messages: messages,
                format: format,
                options: options,
                stream: stream,
                keepAlive: keepAlive,
                tools: tools,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Chat.GenerateChatCompletionAsync(
                model: model,
                messages: messages,
                format: format,
                options: options,
                stream: stream,
                keepAlive: keepAlive,
                tools: tools,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}