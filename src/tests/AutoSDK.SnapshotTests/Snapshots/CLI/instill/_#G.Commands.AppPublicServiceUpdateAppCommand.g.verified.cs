//HintName: G.Commands.AppPublicServiceUpdateAppCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AppPublicServiceUpdateAppCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

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
            Description = @"Namespace id.",
        };

        private global::System.CommandLine.Argument<string> AppId { get; } = new(
            name: "appId")
        {
            Description = @"App id.",
        };

        private global::System.CommandLine.Option<string?> NewAppId { get; } = new(
            name: "newAppId")
        {
            Description = @"The app id needs to follow the kebab case format.
if the new app id is not provided, the app id will not be updated.",
        };

        private global::System.CommandLine.Option<string?> NewDescription { get; } = new(
            name: "newDescription")
        {
            Description = @"The app description.
If the new description is empty, the description will be set to empty.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> NewTags { get; } = new(
            name: "newTags")
        {
            Description = @"The app tags.
If the new tags is empty, the tags will be set to empty.",
        };

        private global::System.CommandLine.Option<string?> LastAiAssistantAppCatalogUid { get; } = new(
            name: "lastAiAssistantAppCatalogUid")
        {
            Description = @"last AI assistant app catalog uid
If the last AI assistant app catalog uid is empty, the last AI assistant app catalog uid will be set to empty.",
        };

        private global::System.CommandLine.Option<int?> LastAiAssistantAppTopK { get; } = new(
            name: "lastAiAssistantAppTopK")
        {
            Description = @"last AI assistant app top k
If the last AI assistant app top k is empty, the last AI assistant app top k will be set to empty.",
        };
        public AppPublicServiceUpdateAppCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "app",
            description: @"Updates the information of an app.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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