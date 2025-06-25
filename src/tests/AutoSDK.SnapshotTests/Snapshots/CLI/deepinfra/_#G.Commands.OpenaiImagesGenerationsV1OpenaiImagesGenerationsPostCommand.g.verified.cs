//HintName: G.Commands.OpenaiImagesGenerationsV1OpenaiImagesGenerationsPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OpenaiImagesGenerationsV1OpenaiImagesGenerationsPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xDeepinfraSource,
            string? userAgent,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.OpenAIImagesOut response,
            global::System.Threading.CancellationToken cancellationToken);


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
        public OpenaiImagesGenerationsV1OpenaiImagesGenerationsPostCommand(G.IApi client) : base(
            name: "openai",
            description: @"Generate image using OpenAI Images API")
        {
            _client = client;

            Options.Add(XDeepinfraSource);
            Options.Add(UserAgent);
            Options.Add(XiApiKey);

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

            Validate(
                parseResult: parseResult,
                xDeepinfraSource: xDeepinfraSource,
                userAgent: userAgent,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.OpenaiImagesGenerationsV1OpenaiImagesGenerationsPostAsync(
                xDeepinfraSource: xDeepinfraSource,
                userAgent: userAgent,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}