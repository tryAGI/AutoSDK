//HintName: G.Commands.AdminApiAdminDeactivateDeveloperKeyCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AdminApiAdminDeactivateDeveloperKeyCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string keyId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.ApiKey response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> KeyId { get; } = new(
            name: "keyId")
        {
            Description = @"API key ID. Consists of two valid GUIDs separated by a colon.",
        };



        public AdminApiAdminDeactivateDeveloperKeyCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "admin",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(KeyId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var keyId = parseResult.GetRequiredValue(KeyId);

            Validate(
                parseResult: parseResult,
                keyId: keyId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.AdminApi.AdminDeactivateDeveloperKeyAsync(
                keyId: keyId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}