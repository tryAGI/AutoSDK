//HintName: G.Commands.AppPublicServiceDeleteAppCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AppPublicServiceDeleteAppCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string appId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> NamespaceId { get; } = new(
            name: "namespaceId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> AppId { get; } = new(
            name: "appId")
        {
            Description = "",
        };

        public AppPublicServiceDeleteAppCommand(G.IApi client) : base(
            name: "app",
            description: @"Deletes an app.")
        {
            _client = client;

            Arguments.Add(NamespaceId);
            Arguments.Add(AppId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var namespaceId = parseResult.GetRequiredValue(NamespaceId);
            var appId = parseResult.GetRequiredValue(AppId);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                appId: appId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.App.AppPublicServiceDeleteAppAsync(
                namespaceId: namespaceId,
                appId: appId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}