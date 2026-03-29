//HintName: G.Commands.GetUsageCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GetUsageCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? xProjectId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.GetUsageResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> XProjectId { get; } = new(
            name: "xProjectId")
        {
            Description = @"Optional project ID to scope the usage query to a specific project",
        };


        public GetUsageCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Get API key and account usage details")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(XProjectId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var xProjectId = parseResult.GetRequiredValue(XProjectId);

            Validate(
                parseResult: parseResult,
                xProjectId: xProjectId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.GetUsageAsync(
                xProjectId: xProjectId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}