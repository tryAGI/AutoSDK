//HintName: G.Commands.DeleteModelCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeleteModelCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string model,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Model { get; } = new(
            name: "model")
        {
            Description = "",
        };

        public DeleteModelCommand(G.IApi client) : base(
            name: "delete",
            description: @"")
        {
            _client = client;

            Arguments.Add(Model);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var model = parseResult.GetRequiredValue(Model);

            Validate(
                parseResult: parseResult,
                model: model,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Models.DeleteModelAsync(
                model: model,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}