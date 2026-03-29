//HintName: G.Commands.WorkspacesGetWorkspaceVersionCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class WorkspacesGetWorkspaceVersionCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.WorkspaceVersion response,
            global::System.Threading.CancellationToken cancellationToken);




        public WorkspacesGetWorkspaceVersionCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Determines whether the workspace should use Opik V1 (legacy workspace-scoped)
or Opik V2 (project-first) navigation. The backend is the single authority for this
determination, clients must never derive the version themselves.

Determination logic (priority order):
1) Feature flag override (TOGGLE_FORCE_WORKSPACE_VERSION)
2) Auth one-way V2 gate (authenticated mode only, not yet implemented)
3) Version 1 entity check (entities without project_id)
4) Fallback on failure

In unauthenticated mode (authentication.enabled=false), auth steps are skipped.
Called by the frontend on workspace load.")
        {
            _client = client;
            _serviceProvider = serviceProvider;


            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            Validate(
                parseResult: parseResult,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Workspaces.GetWorkspaceVersionAsync(
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}