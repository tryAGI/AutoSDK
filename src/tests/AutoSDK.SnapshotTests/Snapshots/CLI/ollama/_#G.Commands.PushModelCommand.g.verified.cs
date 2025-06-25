//HintName: G.Commands.PushModelCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PushModelCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string model,
            bool? insecure,
            string? username,
            string? password,
            bool? stream,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.PushModelResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Insecure { get; } = new(
            name: "insecure")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Username { get; } = new(
            name: "username")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Password { get; } = new(
            name: "password")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Stream { get; } = new(
            name: "stream")
        {
            Description = "",
        };
        public PushModelCommand(G.IApi client) : base(
            name: "push",
            description: @"Requires registering for ollama.ai and adding a public key first.")
        {
            _client = client;

            Arguments.Add(Model);
            Options.Add(Insecure);
            Options.Add(Username);
            Options.Add(Password);
            Options.Add(Stream);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var model = parseResult.GetRequiredValue(Model);
            var insecure = parseResult.GetRequiredValue(Insecure);
            var username = parseResult.GetRequiredValue(Username);
            var password = parseResult.GetRequiredValue(Password);
            var stream = parseResult.GetRequiredValue(Stream);

            Validate(
                parseResult: parseResult,
                model: model,
                insecure: insecure,
                username: username,
                password: password,
                stream: stream,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Models.PushModelAsync(
                model: model,
                insecure: insecure,
                username: username,
                password: password,
                stream: stream,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}