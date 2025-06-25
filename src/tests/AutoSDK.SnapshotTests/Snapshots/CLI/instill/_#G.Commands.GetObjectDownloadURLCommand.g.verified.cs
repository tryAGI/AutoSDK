//HintName: G.Commands.GetObjectDownloadURLCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetObjectDownloadURLCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string namespaceId,
            string objectUid,
            int? urlExpireDays,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.GetObjectDownloadURLResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<string> NamespaceId { get; } = new(
            name: "namespaceId")
        {
            Description = @"id of the namespace",
        };

        private global::System.CommandLine.Argument<string> ObjectUid { get; } = new(
            name: "objectUid")
        {
            Description = @"uid of the object",
        };

        private global::System.CommandLine.Option<int?> UrlExpireDays { get; } = new(
            name: "urlExpireDays")
        {
            Description = @"expiration time in days for the URL.
maximum is 7 days. if set to 0, URL will not expire.",
        };
        public GetObjectDownloadURLCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Returns the download URL of an object.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(NamespaceId);
            Arguments.Add(ObjectUid);
            Options.Add(UrlExpireDays);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var namespaceId = parseResult.GetRequiredValue(NamespaceId);
            var objectUid = parseResult.GetRequiredValue(ObjectUid);
            var urlExpireDays = parseResult.GetRequiredValue(UrlExpireDays);

            Validate(
                parseResult: parseResult,
                namespaceId: namespaceId,
                objectUid: objectUid,
                urlExpireDays: urlExpireDays,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Artifact.GetObjectDownloadURLAsync(
                namespaceId: namespaceId,
                objectUid: objectUid,
                urlExpireDays: urlExpireDays,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}