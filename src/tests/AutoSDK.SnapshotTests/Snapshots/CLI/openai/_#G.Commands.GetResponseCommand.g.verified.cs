//HintName: G.Commands.GetResponseCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetResponseCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string responseId,
            global::System.Collections.Generic.IList<global::G.Includable>? include,
            bool? stream,
            int? startingAfter,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Response response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> ResponseId { get; } = new(
            name: "responseId")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.Includable>?> Include { get; } = new(
            name: "include")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> Stream { get; } = new(
            name: "stream")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> StartingAfter { get; } = new(
            name: "startingAfter")
        {
            Description = "",
        };
        public GetResponseCommand(G.IOpenAiClient client) : base(
            name: "get",
            description: @"")
        {
            _client = client;

            Arguments.Add(ResponseId);
            Options.Add(Include);
            Options.Add(Stream);
            Options.Add(StartingAfter);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var responseId = parseResult.GetRequiredValue(ResponseId);
            var include = parseResult.GetRequiredValue(Include);
            var stream = parseResult.GetRequiredValue(Stream);
            var startingAfter = parseResult.GetRequiredValue(StartingAfter);

            Validate(
                parseResult: parseResult,
                responseId: responseId,
                include: include,
                stream: stream,
                startingAfter: startingAfter,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Responses.GetResponseAsync(
                responseId: responseId,
                include: include,
                stream: stream,
                startingAfter: startingAfter,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}