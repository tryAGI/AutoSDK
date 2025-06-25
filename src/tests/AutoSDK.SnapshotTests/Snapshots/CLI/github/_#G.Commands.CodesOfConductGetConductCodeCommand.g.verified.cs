//HintName: G.Commands.CodesOfConductGetConductCodeCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CodesOfConductGetConductCodeCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string key,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CodeOfConduct response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Key { get; } = new(
            name: "key")
        {
            Description = "",
        };

        public CodesOfConductGetConductCodeCommand(G.IApi client) : base(
            name: "codes",
            description: @"Returns information about the specified GitHub code of conduct.")
        {
            _client = client;

            Arguments.Add(Key);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var key = parseResult.GetRequiredValue(Key);

            Validate(
                parseResult: parseResult,
                key: key,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.CodesOfConduct.CodesOfConductGetConductCodeAsync(
                key: key,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}