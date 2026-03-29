//HintName: G.Commands.DatasetsGetDatasetItemByIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class DatasetsGetDatasetItemByIdCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid itemId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.DatasetItemPublic response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> ItemId { get; } = new(
            name: "itemId")
        {
            Description = @"",
        };



        public DatasetsGetDatasetItemByIdCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "get",
            description: @"Get dataset item by id")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(ItemId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var itemId = parseResult.GetRequiredValue(ItemId);

            Validate(
                parseResult: parseResult,
                itemId: itemId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Datasets.GetDatasetItemByIdAsync(
                itemId: itemId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}