//HintName: G.Commands.OpenaiEmbeddingsV1OpenaiEmbeddingsPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OpenaiEmbeddingsV1OpenaiEmbeddingsPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xDeepinfraSource,
            string? userAgent,
            string? xiApiKey,
            string model,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, string> input,
            global::G.OpenAIEmbeddingsInEncodingFormat? encodingFormat,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = @"model name",
        };

        private global::System.CommandLine.Argument<global::G.AnyOf<global::System.Collections.Generic.IList<string>, string>> Input { get; } = new(
            name: "input")
        {
            Description = @"sequences to embed",
        };

        private global::System.CommandLine.Option<string?> XDeepinfraSource { get; } = new(
            name: "xDeepinfraSource")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> UserAgent { get; } = new(
            name: "userAgent")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.OpenAIEmbeddingsInEncodingFormat?> EncodingFormat { get; } = new(
            name: "encodingFormat")
        {
            Description = @"format used when encoding",
        };
        public OpenaiEmbeddingsV1OpenaiEmbeddingsPostCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "openai",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Model);
            Arguments.Add(Input);
            Options.Add(XDeepinfraSource);
            Options.Add(UserAgent);
            Options.Add(XiApiKey);
            Options.Add(EncodingFormat);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xDeepinfraSource = parseResult.GetRequiredValue(XDeepinfraSource);
            var userAgent = parseResult.GetRequiredValue(UserAgent);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var model = parseResult.GetRequiredValue(Model);
            var input = parseResult.GetRequiredValue(Input);
            var encodingFormat = parseResult.GetRequiredValue(EncodingFormat);

            Validate(
                parseResult: parseResult,
                xDeepinfraSource: xDeepinfraSource,
                userAgent: userAgent,
                xiApiKey: xiApiKey,
                model: model,
                input: input,
                encodingFormat: encodingFormat,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.OpenaiEmbeddingsV1OpenaiEmbeddingsPostAsync(
                xDeepinfraSource: xDeepinfraSource,
                userAgent: userAgent,
                xiApiKey: xiApiKey,
                model: model,
                input: input,
                encodingFormat: encodingFormat,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}