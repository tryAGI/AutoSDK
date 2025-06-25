//HintName: G.Commands.MetaGetOctocatCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MetaGetOctocatCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? s,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            string response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> S { get; } = new(
            name: "s")
        {
            Description = "",
        };
        public MetaGetOctocatCommand(G.IApi client) : base(
            name: "meta",
            description: @"Get the octocat as ASCII art")
        {
            _client = client;

            Options.Add(S);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var s = parseResult.GetRequiredValue(S);

            Validate(
                parseResult: parseResult,
                s: s,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Meta.MetaGetOctocatAsync(
                s: s,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}