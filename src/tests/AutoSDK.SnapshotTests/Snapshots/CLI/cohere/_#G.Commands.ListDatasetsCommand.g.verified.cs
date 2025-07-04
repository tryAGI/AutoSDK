﻿//HintName: G.Commands.ListDatasetsCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ListDatasetsCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? datasetType,
            global::System.DateTime? before,
            global::System.DateTime? after,
            double? limit,
            double? offset,
            global::G.DatasetValidationStatus? validationStatus,
            string? xClientName,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.ListDatasetsResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> DatasetType { get; } = new(
            name: "datasetType")
        {
            Description = @"optional filter by dataset type",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> Before { get; } = new(
            name: "before")
        {
            Description = @"optional filter before a date",
        };

        private global::System.CommandLine.Option<global::System.DateTime?> After { get; } = new(
            name: "after")
        {
            Description = @"optional filter after a date",
        };

        private global::System.CommandLine.Option<double?> Limit { get; } = new(
            name: "limit")
        {
            Description = @"optional limit to number of results",
        };

        private global::System.CommandLine.Option<double?> Offset { get; } = new(
            name: "offset")
        {
            Description = @"optional offset to start of results",
        };

        private global::System.CommandLine.Option<global::G.DatasetValidationStatus?> ValidationStatus { get; } = new(
            name: "validationStatus")
        {
            Description = @"optional filter by validation status",
        };

        private global::System.CommandLine.Option<string?> XClientName { get; } = new(
            name: "xClientName")
        {
            Description = @"The name of the project that is making the request.",
        };
        public ListDatasetsCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "list",
            description: @"List datasets that have been created.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(DatasetType);
            Options.Add(Before);
            Options.Add(After);
            Options.Add(Limit);
            Options.Add(Offset);
            Options.Add(ValidationStatus);
            Options.Add(XClientName);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var datasetType = parseResult.GetRequiredValue(DatasetType);
            var before = parseResult.GetRequiredValue(Before);
            var after = parseResult.GetRequiredValue(After);
            var limit = parseResult.GetRequiredValue(Limit);
            var offset = parseResult.GetRequiredValue(Offset);
            var validationStatus = parseResult.GetRequiredValue(ValidationStatus);
            var xClientName = parseResult.GetRequiredValue(XClientName);

            Validate(
                parseResult: parseResult,
                datasetType: datasetType,
                before: before,
                after: after,
                limit: limit,
                offset: offset,
                validationStatus: validationStatus,
                xClientName: xClientName,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Datasets.ListDatasetsAsync(
                datasetType: datasetType,
                before: before,
                after: after,
                limit: limit,
                offset: offset,
                validationStatus: validationStatus,
                xClientName: xClientName,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}