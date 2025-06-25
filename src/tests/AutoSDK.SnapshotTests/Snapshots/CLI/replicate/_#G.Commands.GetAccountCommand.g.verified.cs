//HintName: G.Commands.GetAccountCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetAccountCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AccountGetResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        public GetAccountCommand(G.IApi client) : base(
            name: "get",
            description: @"Returns information about the user or organization associated with the provided API token.

Example cURL request:

```console
curl -s \
  -H ""Authorization: Bearer $REPLICATE_API_TOKEN"" \
  https://api.replicate.com/v1/account
```

The response will be a JSON object describing the account:

```json
{
  ""type"": ""organization"",
  ""username"": ""acme"",
  ""name"": ""Acme Corp, Inc."",
  ""github_url"": ""https://github.com/acme"",
}
```
")
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
            var response = await _client.GetAccountAsync(
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}