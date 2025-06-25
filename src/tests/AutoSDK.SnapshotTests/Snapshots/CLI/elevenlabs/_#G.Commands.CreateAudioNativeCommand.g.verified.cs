//HintName: G.Commands.CreateAudioNativeCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateAudioNativeCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            string name,
            string? image,
            string? author,
            string? title,
            bool? small,
            string? textColor,
            string? backgroundColor,
            int? sessionization,
            string? voiceId,
            string? modelId,
            byte[]? file,
            string? filename,
            bool? autoConvert,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AudioNativeCreateProjectResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Image { get; } = new(
            name: "image")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Author { get; } = new(
            name: "author")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Title { get; } = new(
            name: "title")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Small { get; } = new(
            name: "small")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> TextColor { get; } = new(
            name: "textColor")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> BackgroundColor { get; } = new(
            name: "backgroundColor")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Sessionization { get; } = new(
            name: "sessionization")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> VoiceId { get; } = new(
            name: "voiceId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> ModelId { get; } = new(
            name: "modelId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<byte[]?> File { get; } = new(
            name: "file")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Filename { get; } = new(
            name: "filename")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> AutoConvert { get; } = new(
            name: "autoConvert")
        {
            Description = "",
        };
        public CreateAudioNativeCommand(G.IApi client) : base(
            name: "create",
            description: @"Creates Audio Native enabled project, optionally starts conversion and returns project ID and embeddable HTML snippet.")
        {
            _client = client;

            Arguments.Add(Name);
            Options.Add(XiApiKey);
            Options.Add(Image);
            Options.Add(Author);
            Options.Add(Title);
            Options.Add(Small);
            Options.Add(TextColor);
            Options.Add(BackgroundColor);
            Options.Add(Sessionization);
            Options.Add(VoiceId);
            Options.Add(ModelId);
            Options.Add(File);
            Options.Add(Filename);
            Options.Add(AutoConvert);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var name = parseResult.GetRequiredValue(Name);
            var image = parseResult.GetRequiredValue(Image);
            var author = parseResult.GetRequiredValue(Author);
            var title = parseResult.GetRequiredValue(Title);
            var small = parseResult.GetRequiredValue(Small);
            var textColor = parseResult.GetRequiredValue(TextColor);
            var backgroundColor = parseResult.GetRequiredValue(BackgroundColor);
            var sessionization = parseResult.GetRequiredValue(Sessionization);
            var voiceId = parseResult.GetRequiredValue(VoiceId);
            var modelId = parseResult.GetRequiredValue(ModelId);
            var file = parseResult.GetRequiredValue(File);
            var filename = parseResult.GetRequiredValue(Filename);
            var autoConvert = parseResult.GetRequiredValue(AutoConvert);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                name: name,
                image: image,
                author: author,
                title: title,
                small: small,
                textColor: textColor,
                backgroundColor: backgroundColor,
                sessionization: sessionization,
                voiceId: voiceId,
                modelId: modelId,
                file: file,
                filename: filename,
                autoConvert: autoConvert,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.AudioNative.CreateAudioNativeAsync(
                xiApiKey: xiApiKey,
                name: name,
                image: image,
                author: author,
                title: title,
                small: small,
                textColor: textColor,
                backgroundColor: backgroundColor,
                sessionization: sessionization,
                voiceId: voiceId,
                modelId: modelId,
                file: file,
                filename: filename,
                autoConvert: autoConvert,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}