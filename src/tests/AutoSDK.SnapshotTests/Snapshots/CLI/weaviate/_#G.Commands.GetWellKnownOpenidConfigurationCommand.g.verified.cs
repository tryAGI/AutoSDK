//HintName: G.Commands.GetWellKnownOpenidConfigurationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetWellKnownOpenidConfigurationCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Response response,
            global::System.Threading.CancellationToken cancellationToken);


        public GetWellKnownOpenidConfigurationCommand(G.IApi client) : base(
            name: "get",
            description: @"OIDC Discovery page, redirects to the token issuer if one is configured")
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
            var response = await _client.WellKnown.GetWellKnownOpenidConfigurationAsync(
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}