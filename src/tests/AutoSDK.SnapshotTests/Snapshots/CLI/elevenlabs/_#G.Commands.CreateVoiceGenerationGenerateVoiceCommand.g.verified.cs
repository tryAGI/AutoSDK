//HintName: G.Commands.CreateVoiceGenerationGenerateVoiceCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateVoiceGenerationGenerateVoiceCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            global::G.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostGender gender,
            string accent,
            global::G.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostAge age,
            double accentStrength,
            string text,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostGender> Gender { get; } = new(
            name: "gender")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Accent { get; } = new(
            name: "accent")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.BodyGenerateARandomVoiceV1VoiceGenerationGenerateVoicePostAge> Age { get; } = new(
            name: "age")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<double> AccentStrength { get; } = new(
            name: "accentStrength")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Text { get; } = new(
            name: "text")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public CreateVoiceGenerationGenerateVoiceCommand(G.IApi client) : base(
            name: "create",
            description: @"Generate a random voice based on parameters. This method returns a generated_voice_id in the response header, and a sample of the voice in the body. If you like the generated voice call /v1/voice-generation/create-voice with the generated_voice_id to create the voice.")
        {
            _client = client;

            Arguments.Add(Gender);
            Arguments.Add(Accent);
            Arguments.Add(Age);
            Arguments.Add(AccentStrength);
            Arguments.Add(Text);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var gender = parseResult.GetRequiredValue(Gender);
            var accent = parseResult.GetRequiredValue(Accent);
            var age = parseResult.GetRequiredValue(Age);
            var accentStrength = parseResult.GetRequiredValue(AccentStrength);
            var text = parseResult.GetRequiredValue(Text);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                gender: gender,
                accent: accent,
                age: age,
                accentStrength: accentStrength,
                text: text,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.VoiceGeneration.CreateVoiceGenerationGenerateVoiceAsync(
                xiApiKey: xiApiKey,
                gender: gender,
                accent: accent,
                age: age,
                accentStrength: accentStrength,
                text: text,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}