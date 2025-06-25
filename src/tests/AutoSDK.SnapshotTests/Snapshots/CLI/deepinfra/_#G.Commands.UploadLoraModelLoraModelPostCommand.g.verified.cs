//HintName: G.Commands.UploadLoraModelLoraModelPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class UploadLoraModelLoraModelPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            string hfModelName,
            string? hfToken,
            string loraModelName,
            string? baseModelName,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.DeploymentOut response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> HfModelName { get; } = new(
            name: "hfModelName")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> LoraModelName { get; } = new(
            name: "loraModelName")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> HfToken { get; } = new(
            name: "hfToken")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> BaseModelName { get; } = new(
            name: "baseModelName")
        {
            Description = @"",
        };
        public UploadLoraModelLoraModelPostCommand(G.IApi client) : base(
            name: "upload",
            description: @"")
        {
            _client = client;

            Arguments.Add(HfModelName);
            Arguments.Add(LoraModelName);
            Options.Add(XiApiKey);
            Options.Add(HfToken);
            Options.Add(BaseModelName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var hfModelName = parseResult.GetRequiredValue(HfModelName);
            var hfToken = parseResult.GetRequiredValue(HfToken);
            var loraModelName = parseResult.GetRequiredValue(LoraModelName);
            var baseModelName = parseResult.GetRequiredValue(BaseModelName);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                hfModelName: hfModelName,
                hfToken: hfToken,
                loraModelName: loraModelName,
                baseModelName: baseModelName,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.UploadLoraModelLoraModelPostAsync(
                xiApiKey: xiApiKey,
                hfModelName: hfModelName,
                hfToken: hfToken,
                loraModelName: loraModelName,
                baseModelName: baseModelName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}