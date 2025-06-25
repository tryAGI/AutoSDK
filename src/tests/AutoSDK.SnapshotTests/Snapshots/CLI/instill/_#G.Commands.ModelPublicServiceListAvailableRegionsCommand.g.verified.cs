//HintName: G.Commands.ModelPublicServiceListAvailableRegionsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModelPublicServiceListAvailableRegionsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListAvailableRegionsResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        public ModelPublicServiceListAvailableRegionsCommand(G.IApi client) : base(
            name: "model",
            description: @"Returns a paginated list of available regions.")
        {
            _client = client;


            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            Validate(
                parseResult: parseResult,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Model.ModelPublicServiceListAvailableRegionsAsync(
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}