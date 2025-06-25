//HintName: G.Commands.CreateVoicesPvcByVoiceIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateVoicesPvcByVoiceIdCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string voiceId,
            string? xiApiKey,
            string? name,
            string? language,
            string? description,
            global::System.Collections.Generic.Dictionary<string, string>? labels,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AddVoiceResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> VoiceId { get; } = new(
            name: "voiceId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Language { get; } = new(
            name: "language")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, string>?> Labels { get; } = new(
            name: "labels")
        {
            Description = "",
        };
        public CreateVoicesPvcByVoiceIdCommand(G.IApi client) : base(
            name: "create",
            description: @"Edit PVC voice metadata")
        {
            _client = client;

            Arguments.Add(VoiceId);
            Options.Add(XiApiKey);
            Options.Add(Name);
            Options.Add(Language);
            Options.Add(Description);
            Options.Add(Labels);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var voiceId = parseResult.GetRequiredValue(VoiceId);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var name = parseResult.GetRequiredValue(Name);
            var language = parseResult.GetRequiredValue(Language);
            var description = parseResult.GetRequiredValue(Description);
            var labels = parseResult.GetRequiredValue(Labels);

            Validate(
                parseResult: parseResult,
                voiceId: voiceId,
                xiApiKey: xiApiKey,
                name: name,
                language: language,
                description: description,
                labels: labels,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.PvcVoices.CreateVoicesPvcByVoiceIdAsync(
                voiceId: voiceId,
                xiApiKey: xiApiKey,
                name: name,
                language: language,
                description: description,
                labels: labels,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}