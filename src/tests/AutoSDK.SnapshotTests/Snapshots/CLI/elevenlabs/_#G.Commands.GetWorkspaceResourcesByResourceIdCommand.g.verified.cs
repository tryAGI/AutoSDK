//HintName: G.Commands.GetWorkspaceResourcesByResourceIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetWorkspaceResourcesByResourceIdCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string resourceId,
            global::G.WorkspaceResourceType resourceType,
            string? xiApiKey,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ResourceMetadataResponseModel response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ResourceId { get; } = new(
            name: "resourceId")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.WorkspaceResourceType> ResourceType { get; } = new(
            name: "resourceType")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XiApiKey { get; } = new(
            name: "xiApiKey")
        {
            Description = "",
        };
        public GetWorkspaceResourcesByResourceIdCommand(G.IApi client) : base(
            name: "get",
            description: @"Gets the metadata of a resource by ID.")
        {
            _client = client;

            Arguments.Add(ResourceId);
            Arguments.Add(ResourceType);
            Options.Add(XiApiKey);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var resourceId = parseResult.GetRequiredValue(ResourceId);
            var resourceType = parseResult.GetRequiredValue(ResourceType);
            var xiApiKey = parseResult.GetRequiredValue(XiApiKey);

            Validate(
                parseResult: parseResult,
                resourceId: resourceId,
                resourceType: resourceType,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Workspace.GetWorkspaceResourcesByResourceIdAsync(
                resourceId: resourceId,
                resourceType: resourceType,
                xiApiKey: xiApiKey,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}