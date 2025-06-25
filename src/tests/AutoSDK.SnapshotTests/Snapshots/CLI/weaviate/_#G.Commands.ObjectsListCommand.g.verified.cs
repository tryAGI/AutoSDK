//HintName: G.Commands.ObjectsListCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ObjectsListCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? after,
            long? offset,
            long? limit,
            string? include,
            string? sort,
            global::G.ObjectsListOrder? order,
            string? @class,
            string? tenant,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ObjectsListResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> After { get; } = new(
            name: "after")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<long?> Offset { get; } = new(
            name: "offset")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<long?> Limit { get; } = new(
            name: "limit")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Include { get; } = new(
            name: "include")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Sort { get; } = new(
            name: "sort")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.ObjectsListOrder?> Order { get; } = new(
            name: "order")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Class { get; } = new(
            name: "@class")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Tenant { get; } = new(
            name: "tenant")
        {
            Description = "",
        };
        public ObjectsListCommand(G.IApi client) : base(
            name: "objects",
            description: @"Lists all objects in reverse order of creation. The data will be returned as an array of objects. <br/><br/>Tip: If you are looking to list all objects in a collection, use the `after` parameter.")
        {
            _client = client;

            Options.Add(After);
            Options.Add(Offset);
            Options.Add(Limit);
            Options.Add(Include);
            Options.Add(Sort);
            Options.Add(Order);
            Options.Add(Class);
            Options.Add(Tenant);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var after = parseResult.GetRequiredValue(After);
            var offset = parseResult.GetRequiredValue(Offset);
            var limit = parseResult.GetRequiredValue(Limit);
            var include = parseResult.GetRequiredValue(Include);
            var sort = parseResult.GetRequiredValue(Sort);
            var order = parseResult.GetRequiredValue(Order);
            var @class = parseResult.GetRequiredValue(Class);
            var tenant = parseResult.GetRequiredValue(Tenant);

            Validate(
                parseResult: parseResult,
                after: after,
                offset: offset,
                limit: limit,
                include: include,
                sort: sort,
                order: order,
                @class: @class,
                tenant: tenant,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Objects.ObjectsListAsync(
                after: after,
                offset: offset,
                limit: limit,
                include: include,
                sort: sort,
                order: order,
                @class: @class,
                tenant: tenant,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}