//HintName: G.Commands.AdminApiAdminCreateDeveloperKeyCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AdminApiAdminCreateDeveloperKeyCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? label,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.ApiKey response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> Label { get; } = new(
            name: "label")
        {
            Description = @"API key label. The default value is `DeepL API Key`.",
        };


        public AdminApiAdminCreateDeveloperKeyCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "admin",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Label);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var label = parseResult.GetRequiredValue(Label);

            Validate(
                parseResult: parseResult,
                label: label,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.AdminApi.AdminCreateDeveloperKeyAsync(
                label: label,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}