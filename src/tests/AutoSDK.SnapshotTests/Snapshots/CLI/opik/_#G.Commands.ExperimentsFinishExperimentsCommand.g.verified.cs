//HintName: G.Commands.ExperimentsFinishExperimentsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ExperimentsFinishExperimentsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::System.Guid> ids,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::System.Guid>> Ids { get; } = new(
            name: "ids")
        {
            Description = @"",
        };



        public ExperimentsFinishExperimentsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "finish",
            description: @"Finish experiments and trigger alert events")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Ids);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var ids = parseResult.GetRequiredValue(Ids);

            Validate(
                parseResult: parseResult,
                ids: ids,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Experiments.FinishExperimentsAsync(
                ids: ids,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}