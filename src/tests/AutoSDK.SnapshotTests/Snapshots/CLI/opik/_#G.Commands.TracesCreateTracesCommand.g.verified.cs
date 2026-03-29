//HintName: G.Commands.TracesCreateTracesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TracesCreateTracesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.TraceWrite> traces,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Collections.Generic.IList<global::G.TraceWrite>> Traces { get; } = new(
            name: "traces")
        {
            Description = @"",
        };



        public TracesCreateTracesCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Create traces")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Traces);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var traces = parseResult.GetRequiredValue(Traces);

            Validate(
                parseResult: parseResult,
                traces: traces,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Traces.CreateTracesAsync(
                traces: traces,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}