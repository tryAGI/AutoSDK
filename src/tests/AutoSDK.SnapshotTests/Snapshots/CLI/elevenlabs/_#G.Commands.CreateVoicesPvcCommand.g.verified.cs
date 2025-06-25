//HintName: G.Commands.CreateVoicesPvcCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateVoicesPvcCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            string name,
            string language,
            string? description,
            global::System.Collections.Generic.Dictionary<string, string>? labels,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AddVoiceResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Language { get; } = new(
            name: "language")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
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
        public CreateVoicesPvcCommand(G.IApi client) : base(
            name: "create",
            description: @"Creates a new PVC voice with metadata but no samples")
        {
            _client = client;

            Arguments.Add(Name);
            Arguments.Add(Language);
            Options.Add(XiApiKey);
            Options.Add(Description);
            Options.Add(Labels);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var name = parseResult.GetRequiredValue(Name);
            var language = parseResult.GetRequiredValue(Language);
            var description = parseResult.GetRequiredValue(Description);
            var labels = parseResult.GetRequiredValue(Labels);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                name: name,
                language: language,
                description: description,
                labels: labels,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.PvcVoices.CreateVoicesPvcAsync(
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