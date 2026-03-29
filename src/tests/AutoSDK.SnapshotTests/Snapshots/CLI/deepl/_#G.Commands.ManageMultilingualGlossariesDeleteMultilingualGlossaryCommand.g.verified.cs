//HintName: G.Commands.ManageMultilingualGlossariesDeleteMultilingualGlossaryCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ManageMultilingualGlossariesDeleteMultilingualGlossaryCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string glossaryId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> GlossaryId { get; } = new(
            name: "glossaryId")
        {
            Description = @"A unique ID assigned to the glossary.",
        };



        public ManageMultilingualGlossariesDeleteMultilingualGlossaryCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "delete",
            description: @"Deletes the specified glossary.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(GlossaryId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var glossaryId = parseResult.GetRequiredValue(GlossaryId);

            Validate(
                parseResult: parseResult,
                glossaryId: glossaryId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.ManageMultilingualGlossaries.DeleteMultilingualGlossaryAsync(
                glossaryId: glossaryId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}