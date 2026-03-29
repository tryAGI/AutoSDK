//HintName: G.Commands.FetchCreateCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class FetchCreateCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string url,
            bool? allowRedirects,
            bool? allowInsecureSsl,
            bool? proxies,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.FetchCreateResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> Url { get; } = new(
            name: "url")
        {
            Description = @"The URL to fetch",
        };

        private global::System.CommandLine.Option<bool?> AllowRedirects { get; } = new(
            name: "allowRedirects")
        {
            Description = @"Whether to follow HTTP redirects",
        };

        private global::System.CommandLine.Option<bool?> AllowInsecureSsl { get; } = new(
            name: "allowInsecureSsl")
        {
            Description = @"Whether to bypass TLS certificate verification",
        };

        private global::System.CommandLine.Option<bool?> Proxies { get; } = new(
            name: "proxies")
        {
            Description = @"Whether to enable proxy support for the request",
        };


        public FetchCreateCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "fetch",
            description: @"Fetch a page and return its content, headers, and metadata.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Url);
            Options.Add(AllowRedirects);
            Options.Add(AllowInsecureSsl);
            Options.Add(Proxies);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var url = parseResult.GetRequiredValue(Url);
            var allowRedirects = parseResult.GetRequiredValue(AllowRedirects);
            var allowInsecureSsl = parseResult.GetRequiredValue(AllowInsecureSsl);
            var proxies = parseResult.GetRequiredValue(Proxies);

            Validate(
                parseResult: parseResult,
                url: url,
                allowRedirects: allowRedirects,
                allowInsecureSsl: allowInsecureSsl,
                proxies: proxies,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.FetchCreateAsync(
                url: url,
                allowRedirects: allowRedirects,
                allowInsecureSsl: allowInsecureSsl,
                proxies: proxies,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}