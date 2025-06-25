//HintName: G.Commands.InferenceDeployV1InferenceDeployDeployIdPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class InferenceDeployV1InferenceDeployDeployIdPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string deployId,
            string? xDeepinfraSource,
            string? userAgent,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> DeployId { get; } = new(
            name: "deployId")
        {
            Description = @"",
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
        public InferenceDeployV1InferenceDeployDeployIdPostCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "inference",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(DeployId);
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
            var deployId = parseResult.GetRequiredValue(DeployId);
            var xDeepinfraSource = parseResult.GetRequiredValue(XDeepinfraSource);
            var userAgent = parseResult.GetRequiredValue(UserAgent);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                deployId: deployId,
                xDeepinfraSource: xDeepinfraSource,
                userAgent: userAgent,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.InferenceDeployV1InferenceDeployDeployIdPostAsync(
                deployId: deployId,
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