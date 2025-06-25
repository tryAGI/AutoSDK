//HintName: G.Commands.MetaGetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MetaGetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ApiOverview response,
            global::System.Threading.CancellationToken cancellationToken);


        public MetaGetCommand(G.IApi client) : base(
            name: "meta",
            description: @"Returns meta information about GitHub, including a list of GitHub's IP addresses. For more information, see ""[About GitHub's IP addresses](https://docs.github.com/articles/about-github-s-ip-addresses/).""

The API's response also includes a list of GitHub's domain names.

The values shown in the documentation's response are example values. You must always query the API directly to get the latest values.

> [!NOTE]
> This endpoint returns both IPv4 and IPv6 addresses. However, not all features support IPv6. You should refer to the specific documentation for each feature to determine if IPv6 is supported.")
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
            var response = await _client.Meta.MetaGetAsync(
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}