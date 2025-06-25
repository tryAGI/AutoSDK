//HintName: G.Commands.UpdateProjectRateLimitsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UpdateProjectRateLimitsCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string projectId,
            string rateLimitId,
            int? maxRequestsPer1Minute,
            int? maxTokensPer1Minute,
            int? maxImagesPer1Minute,
            int? maxAudioMegabytesPer1Minute,
            int? maxRequestsPer1Day,
            int? batch1DayMaxInputTokens,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ProjectRateLimit response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ProjectId { get; } = new(
            name: "projectId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> RateLimitId { get; } = new(
            name: "rateLimitId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> MaxRequestsPer1Minute { get; } = new(
            name: "maxRequestsPer1Minute")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> MaxTokensPer1Minute { get; } = new(
            name: "maxTokensPer1Minute")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> MaxImagesPer1Minute { get; } = new(
            name: "maxImagesPer1Minute")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> MaxAudioMegabytesPer1Minute { get; } = new(
            name: "maxAudioMegabytesPer1Minute")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> MaxRequestsPer1Day { get; } = new(
            name: "maxRequestsPer1Day")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Batch1DayMaxInputTokens { get; } = new(
            name: "batch1DayMaxInputTokens")
        {
            Description = "",
        };
        public UpdateProjectRateLimitsCommand(G.IOpenAiClient client) : base(
            name: "update",
            description: @"")
        {
            _client = client;

            Arguments.Add(ProjectId);
            Arguments.Add(RateLimitId);
            Options.Add(MaxRequestsPer1Minute);
            Options.Add(MaxTokensPer1Minute);
            Options.Add(MaxImagesPer1Minute);
            Options.Add(MaxAudioMegabytesPer1Minute);
            Options.Add(MaxRequestsPer1Day);
            Options.Add(Batch1DayMaxInputTokens);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var projectId = parseResult.GetRequiredValue(ProjectId);
            var rateLimitId = parseResult.GetRequiredValue(RateLimitId);
            var maxRequestsPer1Minute = parseResult.GetRequiredValue(MaxRequestsPer1Minute);
            var maxTokensPer1Minute = parseResult.GetRequiredValue(MaxTokensPer1Minute);
            var maxImagesPer1Minute = parseResult.GetRequiredValue(MaxImagesPer1Minute);
            var maxAudioMegabytesPer1Minute = parseResult.GetRequiredValue(MaxAudioMegabytesPer1Minute);
            var maxRequestsPer1Day = parseResult.GetRequiredValue(MaxRequestsPer1Day);
            var batch1DayMaxInputTokens = parseResult.GetRequiredValue(Batch1DayMaxInputTokens);

            Validate(
                parseResult: parseResult,
                projectId: projectId,
                rateLimitId: rateLimitId,
                maxRequestsPer1Minute: maxRequestsPer1Minute,
                maxTokensPer1Minute: maxTokensPer1Minute,
                maxImagesPer1Minute: maxImagesPer1Minute,
                maxAudioMegabytesPer1Minute: maxAudioMegabytesPer1Minute,
                maxRequestsPer1Day: maxRequestsPer1Day,
                batch1DayMaxInputTokens: batch1DayMaxInputTokens,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Projects.UpdateProjectRateLimitsAsync(
                projectId: projectId,
                rateLimitId: rateLimitId,
                maxRequestsPer1Minute: maxRequestsPer1Minute,
                maxTokensPer1Minute: maxTokensPer1Minute,
                maxImagesPer1Minute: maxImagesPer1Minute,
                maxAudioMegabytesPer1Minute: maxAudioMegabytesPer1Minute,
                maxRequestsPer1Day: maxRequestsPer1Day,
                batch1DayMaxInputTokens: batch1DayMaxInputTokens,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}