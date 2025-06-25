//HintName: G.Commands.CreateVoiceV1VoicesAddPostCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateVoiceV1VoicesAddPostCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xiApiKey,
            string name,
            string description,
            global::System.Collections.Generic.IList<byte[]> files,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Voice response,
            global::System.Threading.CancellationToken cancellationToken);

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Argument<string> Description { get; } = new(
            name: "description")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<byte[]>> Files { get; } = new(
            name: "files")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = @"",
        };
        public CreateVoiceV1VoicesAddPostCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Create a new voice")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Name);
            Arguments.Add(Description);
            Arguments.Add(Files);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);
            var name = parseResult.GetRequiredValue(Name);
            var description = parseResult.GetRequiredValue(Description);
            var files = parseResult.GetRequiredValue(Files);

            Validate(
                parseResult: parseResult,
                xiApiKey: xiApiKey,
                name: name,
                description: description,
                files: files,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CreateVoiceV1VoicesAddPostAsync(
                xiApiKey: xiApiKey,
                name: name,
                description: description,
                files: files,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}