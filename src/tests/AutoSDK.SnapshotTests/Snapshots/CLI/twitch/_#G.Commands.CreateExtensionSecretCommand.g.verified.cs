//HintName: G.Commands.CreateExtensionSecretCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateExtensionSecretCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string extensionId,
            int? delay,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CreateExtensionSecretResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ExtensionId { get; } = new(
            name: "extensionId")
        {
            Description = @"The ID of the extension to apply the shared secret to.",
        };

        private global::System.CommandLine.Option<int?> Delay { get; } = new(
            name: "delay")
        {
            Description = @"The amount of time, in seconds, to delay activating the secret. The delay should provide enough time for instances of the extension to gracefully switch over to the new secret. The minimum delay is 300 seconds (5 minutes). The default is 300 seconds.",
        };
        public CreateExtensionSecretCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Creates a shared secret used to sign and verify JWT tokens. Creating a new secret removes the current secrets from service. Use this function only when you are ready to use the new secret it returns.

__Authorization:__

Requires a signed JSON Web Token (JWT) created by an Extension Backend Service (EBS). For signing requirements, see [Signing the JWT](https://dev.twitch.tv/docs/extensions/building/#signing-the-jwt). The signed JWT must include the `role`, `user_id`, and `exp` fields (see [JWT Schema](https://dev.twitch.tv/docs/extensions/reference/#jwt-schema)). The `role` field must be set to _external_.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ExtensionId);
            Options.Add(Delay);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var extensionId = parseResult.GetRequiredValue(ExtensionId);
            var delay = parseResult.GetRequiredValue(Delay);

            Validate(
                parseResult: parseResult,
                extensionId: extensionId,
                delay: delay,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Extensions.CreateExtensionSecretAsync(
                extensionId: extensionId,
                delay: delay,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}