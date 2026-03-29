//HintName: G.Commands.TracesUpdateThreadCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TracesUpdateThreadCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid threadModelId,
            global::System.Collections.Generic.IList<string>? tags,
            global::System.Collections.Generic.IList<string>? tagsToAdd,
            global::System.Collections.Generic.IList<string>? tagsToRemove,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> ThreadModelId { get; } = new(
            name: "threadModelId")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> Tags { get; } = new(
            name: "tags")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> TagsToAdd { get; } = new(
            name: "tagsToAdd")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> TagsToRemove { get; } = new(
            name: "tagsToRemove")
        {
            Description = @"",
        };


        public TracesUpdateThreadCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"Update thread")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ThreadModelId);
            Options.Add(Tags);
            Options.Add(TagsToAdd);
            Options.Add(TagsToRemove);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var threadModelId = parseResult.GetRequiredValue(ThreadModelId);
            var tags = parseResult.GetRequiredValue(Tags);
            var tagsToAdd = parseResult.GetRequiredValue(TagsToAdd);
            var tagsToRemove = parseResult.GetRequiredValue(TagsToRemove);

            Validate(
                parseResult: parseResult,
                threadModelId: threadModelId,
                tags: tags,
                tagsToAdd: tagsToAdd,
                tagsToRemove: tagsToRemove,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Traces.UpdateThreadAsync(
                threadModelId: threadModelId,
                tags: tags,
                tagsToAdd: tagsToAdd,
                tagsToRemove: tagsToRemove,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}