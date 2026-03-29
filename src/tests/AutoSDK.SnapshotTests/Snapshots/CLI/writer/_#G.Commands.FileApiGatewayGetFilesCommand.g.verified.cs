//HintName: G.Commands.FileApiGatewayGetFilesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class FileApiGatewayGetFilesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? before,
            string? after,
            int? limit,
            global::G.GatewayGetFilesOrder? order,
            global::System.Guid? graphId,
            global::G.GatewayGetFilesStatus? status,
            string? fileTypes,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.FilesResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> Before { get; } = new(
            name: "before")
        {
            Description = @"The ID of the first object in the previous page. This parameter instructs the API to return the previous page of results.",
        };

        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = @"The ID of the last object in the previous page. This parameter instructs the API to return the next page of results.",
        };

        private global::System.CommandLine.Option<int?> Limit { get; } = new(
            name: "limit")
        {
            Description = @"Specifies the maximum number of objects returned in a page. The default value is 50. The minimum value is 1, and the maximum value is 100.",
        };

        private global::System.CommandLine.Option<global::G.GatewayGetFilesOrder?> Order { get; } = new(
            name: "order")
        {
            Description = @"Specifies the order of the results. Valid values are asc for ascending and desc for descending.",
        };

        private global::System.CommandLine.Option<global::System.Guid?> GraphId { get; } = new(
            name: "graphId")
        {
            Description = @"The unique identifier of the graph to which the files belong.",
        };

        private global::System.CommandLine.Option<global::G.GatewayGetFilesStatus?> Status { get; } = new(
            name: "status")
        {
            Description = @"Specifies the status of the files to retrieve. Valid values are in_progress, completed or failed.",
        };

        private global::System.CommandLine.Option<string?> FileTypes { get; } = new(
            name: "fileTypes")
        {
            Description = @"The extensions of the files to retrieve. Separate multiple extensions with a comma. For example: `pdf,jpg,docx`.",
        };


        public FileApiGatewayGetFilesCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "gateway",
            description: @"Retrieve a paginated list of files with optional filtering by status, graph association, and file type.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(Before);
            Options.Add(After);
            Options.Add(Limit);
            Options.Add(Order);
            Options.Add(GraphId);
            Options.Add(Status);
            Options.Add(FileTypes);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var before = parseResult.GetRequiredValue(Before);
            var after = parseResult.GetRequiredValue(After);
            var limit = parseResult.GetRequiredValue(Limit);
            var order = parseResult.GetRequiredValue(Order);
            var graphId = parseResult.GetRequiredValue(GraphId);
            var status = parseResult.GetRequiredValue(Status);
            var fileTypes = parseResult.GetRequiredValue(FileTypes);

            Validate(
                parseResult: parseResult,
                before: before,
                after: after,
                limit: limit,
                order: order,
                graphId: graphId,
                status: status,
                fileTypes: fileTypes,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.FileApi.GatewayGetFilesAsync(
                before: before,
                after: after,
                limit: limit,
                order: order,
                graphId: graphId,
                status: status,
                fileTypes: fileTypes,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}