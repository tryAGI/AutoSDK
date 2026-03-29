//HintName: G.Commands.WorkspacesUpsertWorkspaceConfigurationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class WorkspacesUpsertWorkspaceConfigurationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? timeoutToMarkThreadAsInactive,
            bool? truncationOnTables,
            global::System.Collections.Generic.Dictionary<string, string>? colorMap,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.WorkspaceConfiguration response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> TimeoutToMarkThreadAsInactive { get; } = new(
            name: "timeoutToMarkThreadAsInactive")
        {
            Description = @"Duration in ISO-8601 format (e.g., PT30M for 30 minutes, PT2H for 2 hours, P1D for 1 day). Minimum precision supported is seconds, please use a duration with seconds precision or higher. Also, the max duration allowed is 7 days.",
        };

        private global::System.CommandLine.Option<bool?> TruncationOnTables { get; } = new(
            name: "truncationOnTables")
        {
            Description = @"Enable or disable data truncation in table views. When disabled, the frontend will limit pagination to prevent performance issues. Default: true (truncation enabled).",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, string>?> ColorMap { get; } = new(
            name: "colorMap")
        {
            Description = @"Workspace-level color map. Maps label names to hex color values (e.g. #FF0000). Max 10000 entries.",
        };


        public WorkspacesUpsertWorkspaceConfigurationCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "upsert",
            description: @"Upsert workspace configuration")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(TimeoutToMarkThreadAsInactive);
            Options.Add(TruncationOnTables);
            Options.Add(ColorMap);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var timeoutToMarkThreadAsInactive = parseResult.GetRequiredValue(TimeoutToMarkThreadAsInactive);
            var truncationOnTables = parseResult.GetRequiredValue(TruncationOnTables);
            var colorMap = parseResult.GetRequiredValue(ColorMap);

            Validate(
                parseResult: parseResult,
                timeoutToMarkThreadAsInactive: timeoutToMarkThreadAsInactive,
                truncationOnTables: truncationOnTables,
                colorMap: colorMap,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Workspaces.UpsertWorkspaceConfigurationAsync(
                timeoutToMarkThreadAsInactive: timeoutToMarkThreadAsInactive,
                truncationOnTables: truncationOnTables,
                colorMap: colorMap,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}