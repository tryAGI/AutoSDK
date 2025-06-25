//HintName: G.Commands.CreateContainerCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateContainerCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string name,
            global::System.Collections.Generic.IList<string>? fileIds,
            global::G.CreateContainerBodyExpiresAfter? expiresAfter,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ContainerResource response,
            global::System.Threading.CancellationToken cancellationToken);

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> FileIds { get; } = new(
            name: "fileIds")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CreateContainerBodyExpiresAfter?> ExpiresAfter { get; } = new(
            name: "expiresAfter")
        {
            Description = "",
        };
        public CreateContainerCommand(G.IOpenAiClient client) : base(
            name: "create",
            description: @"Creates a container.")
        {
            _client = client;

            Arguments.Add(Name);
            Options.Add(FileIds);
            Options.Add(ExpiresAfter);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var name = parseResult.GetRequiredValue(Name);
            var fileIds = parseResult.GetRequiredValue(FileIds);
            var expiresAfter = parseResult.GetRequiredValue(ExpiresAfter);

            Validate(
                parseResult: parseResult,
                name: name,
                fileIds: fileIds,
                expiresAfter: expiresAfter,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CreateContainerAsync(
                name: name,
                fileIds: fileIds,
                expiresAfter: expiresAfter,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}