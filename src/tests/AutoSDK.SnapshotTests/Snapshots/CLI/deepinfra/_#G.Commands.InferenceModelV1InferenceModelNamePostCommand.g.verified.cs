//HintName: G.Commands.InferenceModelV1InferenceModelNamePostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class InferenceModelV1InferenceModelNamePostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string modelName,
            string? version,
            string? xDeepinfraSource,
            string? userAgent,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ModelName { get; } = new(
            name: "modelName")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Version { get; } = new(
            name: "version")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XDeepinfraSource { get; } = new(
            name: "xDeepinfraSource")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> UserAgent { get; } = new(
            name: "userAgent")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public InferenceModelV1InferenceModelNamePostCommand(G.IApi client) : base(
            name: "inference",
            description: @"")
        {
            _client = client;

            Arguments.Add(ModelName);
            Options.Add(Version);
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
            var modelName = parseResult.GetRequiredValue(ModelName);
            var version = parseResult.GetRequiredValue(Version);
            var xDeepinfraSource = parseResult.GetRequiredValue(XDeepinfraSource);
            var userAgent = parseResult.GetRequiredValue(UserAgent);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                modelName: modelName,
                version: version,
                xDeepinfraSource: xDeepinfraSource,
                userAgent: userAgent,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.InferenceModelV1InferenceModelNamePostAsync(
                modelName: modelName,
                version: version,
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