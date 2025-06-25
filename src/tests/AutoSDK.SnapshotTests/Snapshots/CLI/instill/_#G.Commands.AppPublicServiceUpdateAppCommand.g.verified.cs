//HintName: G.Commands.AppPublicServiceUpdateAppCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AppPublicServiceUpdateAppCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string appId,
            string? newAppId,
            string? newDescription,
            global::System.Collections.Generic.IList<string>? newTags,
            string? lastAiAssistantAppCatalogUid,
            int? lastAiAssistantAppTopK,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.UpdateAppResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> NamespaceId { get; } = new(
            name: "namespaceId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Argument<string> AppId { get; } = new(
            name: "appId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> NewAppId { get; } = new(
            name: "newAppId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> NewDescription { get; } = new(
            name: "newDescription")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> NewTags { get; } = new(
            name: "newTags")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<string?> LastAiAssistantAppCatalogUid { get; } = new(
            name: "lastAiAssistantAppCatalogUid")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<int?> LastAiAssistantAppTopK { get; } = new(
            name: "lastAiAssistantAppTopK")
        {
            Description = @"",
        };
        public AppPublicServiceUpdateAppCommand(G.IApi client) : base(
            name: "app",
            description: @"Updates the information of an app.")
        {
            _client = client;

            Arguments.Add(NamespaceId);
            Arguments.Add(AppId);
            Options.Add(NewAppId);
            Options.Add(NewDescription);
            Options.Add(NewTags);
            Options.Add(LastAiAssistantAppCatalogUid);
            Options.Add(LastAiAssistantAppTopK);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var namespaceId = parseResult.GetRequiredValue(NamespaceId);
            var appId = parseResult.GetRequiredValue(AppId);
            var newAppId = parseResult.GetRequiredValue(NewAppId);
            var newDescription = parseResult.GetRequiredValue(NewDescription);
            var newTags = parseResult.GetRequiredValue(NewTags);
            var lastAiAssistantAppCatalogUid = parseResult.GetRequiredValue(LastAiAssistantAppCatalogUid);
            var lastAiAssistantAppTopK = parseResult.GetRequiredValue(LastAiAssistantAppTopK);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                appId: appId,
                newAppId: newAppId,
                newDescription: newDescription,
                newTags: newTags,
                lastAiAssistantAppCatalogUid: lastAiAssistantAppCatalogUid,
                lastAiAssistantAppTopK: lastAiAssistantAppTopK,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.App.AppPublicServiceUpdateAppAsync(
                namespaceId: namespaceId,
                appId: appId,
                newAppId: newAppId,
                newDescription: newDescription,
                newTags: newTags,
                lastAiAssistantAppCatalogUid: lastAiAssistantAppCatalogUid,
                lastAiAssistantAppTopK: lastAiAssistantAppTopK,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}