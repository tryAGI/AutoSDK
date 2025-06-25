//HintName: G.Commands.CreateDatasetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateDatasetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string name,
            global::G.DatasetType type,
            bool? keepOriginalFile,
            bool? skipMalformedInput,
            global::System.Collections.Generic.IList<string>? keepFields,
            global::System.Collections.Generic.IList<string>? optionalFields,
            string? textSeparator,
            string? csvDelimiter,
            string? xClientName,
            byte[] data,
            string dataname,
            byte[]? evalData,
            string? evalDataname,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.CreateDatasetResponse response,
            global::System.Threading.CancellationToken cancellationToken);

        private new global::System.CommandLine.Argument<string> Name { get; } = new(
            name: "name")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<global::G.DatasetType> Type { get; } = new(
            name: "type")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<byte[]> Data { get; } = new(
            name: "data")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> Dataname { get; } = new(
            name: "dataname")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> KeepOriginalFile { get; } = new(
            name: "keepOriginalFile")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<bool?> SkipMalformedInput { get; } = new(
            name: "skipMalformedInput")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> KeepFields { get; } = new(
            name: "keepFields")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> OptionalFields { get; } = new(
            name: "optionalFields")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> TextSeparator { get; } = new(
            name: "textSeparator")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> CsvDelimiter { get; } = new(
            name: "csvDelimiter")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> XClientName { get; } = new(
            name: "xClientName")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<byte[]?> EvalData { get; } = new(
            name: "evalData")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> EvalDataname { get; } = new(
            name: "evalDataname")
        {
            Description = "",
        };
        public CreateDatasetCommand(G.IApi client) : base(
            name: "create",
            description: @"Create a dataset by uploading a file. See ['Dataset Creation'](https://docs.cohere.com/docs/datasets#dataset-creation) for more information.")
        {
            _client = client;

            Arguments.Add(Name);
            Arguments.Add(Type);
            Arguments.Add(Data);
            Arguments.Add(Dataname);
            Options.Add(KeepOriginalFile);
            Options.Add(SkipMalformedInput);
            Options.Add(KeepFields);
            Options.Add(OptionalFields);
            Options.Add(TextSeparator);
            Options.Add(CsvDelimiter);
            Options.Add(XClientName);
            Options.Add(EvalData);
            Options.Add(EvalDataname);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var name = parseResult.GetRequiredValue(Name);
            var type = parseResult.GetRequiredValue(Type);
            var keepOriginalFile = parseResult.GetRequiredValue(KeepOriginalFile);
            var skipMalformedInput = parseResult.GetRequiredValue(SkipMalformedInput);
            var keepFields = parseResult.GetRequiredValue(KeepFields);
            var optionalFields = parseResult.GetRequiredValue(OptionalFields);
            var textSeparator = parseResult.GetRequiredValue(TextSeparator);
            var csvDelimiter = parseResult.GetRequiredValue(CsvDelimiter);
            var xClientName = parseResult.GetRequiredValue(XClientName);
            var data = parseResult.GetRequiredValue(Data);
            var dataname = parseResult.GetRequiredValue(Dataname);
            var evalData = parseResult.GetRequiredValue(EvalData);
            var evalDataname = parseResult.GetRequiredValue(EvalDataname);

            Validate(
                parseResult: parseResult,
                name: name,
                type: type,
                keepOriginalFile: keepOriginalFile,
                skipMalformedInput: skipMalformedInput,
                keepFields: keepFields,
                optionalFields: optionalFields,
                textSeparator: textSeparator,
                csvDelimiter: csvDelimiter,
                xClientName: xClientName,
                data: data,
                dataname: dataname,
                evalData: evalData,
                evalDataname: evalDataname,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Datasets.CreateDatasetAsync(
                name: name,
                type: type,
                keepOriginalFile: keepOriginalFile,
                skipMalformedInput: skipMalformedInput,
                keepFields: keepFields,
                optionalFields: optionalFields,
                textSeparator: textSeparator,
                csvDelimiter: csvDelimiter,
                xClientName: xClientName,
                data: data,
                dataname: dataname,
                evalData: evalData,
                evalDataname: evalDataname,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}