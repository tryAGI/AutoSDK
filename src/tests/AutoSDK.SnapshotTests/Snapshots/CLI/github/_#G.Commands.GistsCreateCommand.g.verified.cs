//HintName: G.Commands.GistsCreateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GistsCreateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? description,
            global::System.Collections.Generic.Dictionary<string, global::G.GistsCreateRequestFiles2> files,
            global::G.OneOf<bool?, global::G.GistsCreateRequestPublic?>? @public,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GistSimple response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.Dictionary<string, global::G.GistsCreateRequestFiles2>> Files { get; } = new(
            name: "files")
        {
            Description = "",
        };

        private new global::System.CommandLine.Option<string?> Description { get; } = new(
            name: "description")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.OneOf<bool?, global::G.GistsCreateRequestPublic?>?> Public { get; } = new(
            name: "@public")
        {
            Description = "",
        };
        public GistsCreateCommand(G.IApi client) : base(
            name: "gists",
            description: @"Allows you to add a new gist with one or more files.

> [!NOTE]
> Don't name your files ""gistfile"" with a numerical suffix. This is the format of the automatic naming scheme that Gist uses internally.")
        {
            _client = client;

            Arguments.Add(Files);
            Options.Add(Description);
            Options.Add(Public);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var description = parseResult.GetRequiredValue(Description);
            var files = parseResult.GetRequiredValue(Files);
            var @public = parseResult.GetRequiredValue(Public);

            Validate(
                parseResult: parseResult,
                description: description,
                files: files,
                @public: @public,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Gists.GistsCreateAsync(
                description: description,
                files: files,
                @public: @public,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}