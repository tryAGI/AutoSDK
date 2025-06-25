//HintName: G.Commands.DeleteStyleCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DeleteStyleCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid styleId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> StyleId { get; } = new(
            name: "styleId")
        {
            Description = @"",
        };

        public DeleteStyleCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "delete",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(StyleId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var styleId = parseResult.GetRequiredValue(StyleId);

            Validate(
                parseResult: parseResult,
                styleId: styleId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Style.DeleteStyleAsync(
                styleId: styleId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}