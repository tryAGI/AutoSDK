//HintName: G.Commands.DeleteContainerCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeleteContainerCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string containerId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ContainerId { get; } = new(
            name: "containerId")
        {
            Description = "",
        };

        public DeleteContainerCommand(G.IOpenAiClient client) : base(
            name: "delete",
            description: @"Delete a container.")
        {
            _client = client;

            Arguments.Add(ContainerId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var containerId = parseResult.GetRequiredValue(ContainerId);

            Validate(
                parseResult: parseResult,
                containerId: containerId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.DeleteContainerAsync(
                containerId: containerId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}