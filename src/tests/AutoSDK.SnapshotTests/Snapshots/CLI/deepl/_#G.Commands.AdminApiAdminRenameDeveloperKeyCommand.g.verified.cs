//HintName: G.Commands.AdminApiAdminRenameDeveloperKeyCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AdminApiAdminRenameDeveloperKeyCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string keyId,
            string label,
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

        private global::System.CommandLine.Argument<string> Label { get; } = new(
            name: "label")
        {
            Description = @"API key label.",
        };



        public AdminApiAdminRenameDeveloperKeyCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "admin",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(KeyId);
            Arguments.Add(Label);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var keyId = parseResult.GetRequiredValue(KeyId);
            var label = parseResult.GetRequiredValue(Label);

            Validate(
                parseResult: parseResult,
                keyId: keyId,
                label: label,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.AdminApi.AdminRenameDeveloperKeyAsync(
                keyId: keyId,
                label: label,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}