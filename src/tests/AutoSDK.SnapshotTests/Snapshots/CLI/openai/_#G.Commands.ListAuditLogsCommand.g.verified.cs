//HintName: G.Commands.ListAuditLogsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListAuditLogsCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListAuditLogsEffectiveAt? effectiveAt,
            global::System.Collections.Generic.IList<string>? projectIds,
            global::System.Collections.Generic.IList<global::G.AuditLogEventType>? eventTypes,
            global::System.Collections.Generic.IList<string>? actorIds,
            global::System.Collections.Generic.IList<string>? actorEmails,
            global::System.Collections.Generic.IList<string>? resourceIds,
            int? limit,
            string? after,
            string? before,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListAuditLogsResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<global::G.ListAuditLogsEffectiveAt?> EffectiveAt { get; } = new(
            name: "effectiveAt")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> ProjectIds { get; } = new(
            name: "projectIds")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.AuditLogEventType>?> EventTypes { get; } = new(
            name: "eventTypes")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> ActorIds { get; } = new(
            name: "actorIds")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> ActorEmails { get; } = new(
            name: "actorEmails")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> ResourceIds { get; } = new(
            name: "resourceIds")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Before { get; } = new(
            name: "before")
        {
            Description = "",
        };
        public ListAuditLogsCommand(G.IOpenAiClient client) : base(
            name: "list",
            description: @"")
        {
            _client = client;

            Options.Add(EffectiveAt);
            Options.Add(ProjectIds);
            Options.Add(EventTypes);
            Options.Add(ActorIds);
            Options.Add(ActorEmails);
            Options.Add(ResourceIds);
            Options.Add(Limit);
            Options.Add(After);
            Options.Add(Before);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var effectiveAt = parseResult.GetRequiredValue(EffectiveAt);
            var projectIds = parseResult.GetRequiredValue(ProjectIds);
            var eventTypes = parseResult.GetRequiredValue(EventTypes);
            var actorIds = parseResult.GetRequiredValue(ActorIds);
            var actorEmails = parseResult.GetRequiredValue(ActorEmails);
            var resourceIds = parseResult.GetRequiredValue(ResourceIds);
            var limit = parseResult.GetRequiredValue(Limit);
            var after = parseResult.GetRequiredValue(After);
            var before = parseResult.GetRequiredValue(Before);

            Validate(
                parseResult: parseResult,
                effectiveAt: effectiveAt,
                projectIds: projectIds,
                eventTypes: eventTypes,
                actorIds: actorIds,
                actorEmails: actorEmails,
                resourceIds: resourceIds,
                limit: limit,
                after: after,
                before: before,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.AuditLogs.ListAuditLogsAsync(
                effectiveAt: effectiveAt,
                projectIds: projectIds,
                eventTypes: eventTypes,
                actorIds: actorIds,
                actorEmails: actorEmails,
                resourceIds: resourceIds,
                limit: limit,
                after: after,
                before: before,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}