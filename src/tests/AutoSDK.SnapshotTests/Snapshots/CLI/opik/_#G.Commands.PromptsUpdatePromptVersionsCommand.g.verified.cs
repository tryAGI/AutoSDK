//HintName: G.Commands.PromptsUpdatePromptVersionsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class PromptsUpdatePromptVersionsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::System.Guid> ids,
            global::G.PromptVersionUpdate update,
            bool? mergeTags,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::System.Guid>> Ids { get; } = new(
            name: "ids")
        {
            Description = @"IDs of prompt versions to update",
        };

        private global::System.CommandLine.Argument<global::G.PromptVersionUpdate> Update { get; } = new(
            name: "update")
        {
            Description = @"Update to apply to prompt versions.
Note: Prompt versions are immutable by design.
Only organizational properties (such as tags etc.) can be updated.
Core properties like template, metadata etc. cannot be modified after creation.",
        };

        private global::System.CommandLine.Option<bool?> MergeTags { get; } = new(
            name: "mergeTags")
        {
            Description = @"Tag merge behavior:
- true: Add new tags to existing tags (union)
- false: Replace all existing tags with new tags (default behaviour if not provided)",
        };


        public PromptsUpdatePromptVersionsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"Update one or more prompt versions.

Note: Prompt versions are immutable by design.
Only organizational properties, such as tags etc., can be updated.
Core properties like template and metadata cannot be modified after creation.

PATCH semantics:
- non-empty values update the field
- null values preserve existing field values (no change)
- empty values explicitly clear the field")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Ids);
            Arguments.Add(Update);
            Options.Add(MergeTags);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var ids = parseResult.GetRequiredValue(Ids);
            var update = parseResult.GetRequiredValue(Update);
            var mergeTags = parseResult.GetRequiredValue(MergeTags);

            Validate(
                parseResult: parseResult,
                ids: ids,
                update: update,
                mergeTags: mergeTags,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Prompts.UpdatePromptVersionsAsync(
                ids: ids,
                update: update,
                mergeTags: mergeTags,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}