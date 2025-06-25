//HintName: G.Commands.CreateVoicesAddCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateVoicesAddCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            string name,
            global::System.Collections.Generic.IList<byte[]> files,
            bool? removeBackgroundNoise,
            string? description,
            string? labels,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AddVoiceIVCResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<byte[]>> Files { get; } = new(
            name: "files")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> RemoveBackgroundNoise { get; } = new(
            name: "removeBackgroundNoise")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Labels { get; } = new(
            name: "labels")
        {
            Description = "",
        };
        public CreateVoicesAddCommand(G.IApi client) : base(
            name: "create",
            description: @"Add a new voice to your collection of voices in VoiceLab.")
        {
            _client = client;

            Arguments.Add(Name);
            Arguments.Add(Files);
            Options.Add(XiApiKey);
            Options.Add(RemoveBackgroundNoise);
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
            var files = parseResult.GetRequiredValue(Files);
            var removeBackgroundNoise = parseResult.GetRequiredValue(RemoveBackgroundNoise);
            var description = parseResult.GetRequiredValue(Description);
            var labels = parseResult.GetRequiredValue(Labels);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                name: name,
                files: files,
                removeBackgroundNoise: removeBackgroundNoise,
                description: description,
                labels: labels,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Voices.CreateVoicesAddAsync(
                xiApiKey: xiApiKey,
                name: name,
                files: files,
                removeBackgroundNoise: removeBackgroundNoise,
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