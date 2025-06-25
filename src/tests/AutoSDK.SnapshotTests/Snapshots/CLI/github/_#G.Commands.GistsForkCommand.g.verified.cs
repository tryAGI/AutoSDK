//HintName: G.Commands.GistsForkCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GistsForkCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string gistId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.BaseGist response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> GistId { get; } = new(
            name: "gistId")
        {
            Description = "",
        };

        public GistsForkCommand(G.IApi client) : base(
            name: "gists",
            description: @"")
        {
            _client = client;

            Arguments.Add(GistId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var gistId = parseResult.GetRequiredValue(GistId);

            Validate(
                parseResult: parseResult,
                gistId: gistId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Gists.GistsForkAsync(
                gistId: gistId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}