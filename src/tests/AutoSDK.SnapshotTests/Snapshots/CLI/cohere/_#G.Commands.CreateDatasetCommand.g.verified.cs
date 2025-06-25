//HintName: G.Commands.CreateDatasetCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateDatasetCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

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
            Description = @"The name of the uploaded dataset.",
        };

        private global::System.CommandLine.Argument<global::G.DatasetType> Type { get; } = new(
            name: "type")
        {
            Description = @"The dataset type, which is used to validate the data. Valid types are `embed-input`, `reranker-finetune-input`, `single-label-classification-finetune-input`, `chat-finetune-input`, and `multi-label-classification-finetune-input`.",
        };

        private global::System.CommandLine.Argument<byte[]> Data { get; } = new(
            name: "data")
        {
            Description = @"The file to upload",
        };

        private global::System.CommandLine.Argument<string> Dataname { get; } = new(
            name: "dataname")
        {
            Description = @"The file to upload",
        };

        private global::System.CommandLine.Option<bool?> KeepOriginalFile { get; } = new(
            name: "keepOriginalFile")
        {
            Description = @"Indicates if the original file should be stored.",
        };

        private global::System.CommandLine.Option<bool?> SkipMalformedInput { get; } = new(
            name: "skipMalformedInput")
        {
            Description = @"Indicates whether rows with malformed input should be dropped (instead of failing the validation check). Dropped rows will be returned in the warnings field.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> KeepFields { get; } = new(
            name: "keepFields")
        {
            Description = @"List of names of fields that will be persisted in the Dataset. By default the Dataset will retain only the required fields indicated in the [schema for the corresponding Dataset type](https://docs.cohere.com/docs/datasets#dataset-types). For example, datasets of type `embed-input` will drop all fields other than the required `text` field. If any of the fields in `keep_fields` are missing from the uploaded file, Dataset validation will fail.",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<string>?> OptionalFields { get; } = new(
            name: "optionalFields")
        {
            Description = @"List of names of fields that will be persisted in the Dataset. By default the Dataset will retain only the required fields indicated in the [schema for the corresponding Dataset type](https://docs.cohere.com/docs/datasets#dataset-types). For example, Datasets of type `embed-input` will drop all fields other than the required `text` field. If any of the fields in `optional_fields` are missing from the uploaded file, Dataset validation will pass.",
        };

        private global::System.CommandLine.Option<string?> TextSeparator { get; } = new(
            name: "textSeparator")
        {
            Description = @"Raw .txt uploads will be split into entries using the text_separator value.",
        };

        private global::System.CommandLine.Option<string?> CsvDelimiter { get; } = new(
            name: "csvDelimiter")
        {
            Description = @"The delimiter used for .csv uploads.",
        };

        private global::System.CommandLine.Option<string?> XClientName { get; } = new(
            name: "xClientName")
        {
            Description = @"The name of the project that is making the request.",
        };

        private global::System.CommandLine.Option<byte[]?> EvalData { get; } = new(
            name: "evalData")
        {
            Description = @"An optional evaluation file to upload",
        };

        private global::System.CommandLine.Option<string?> EvalDataname { get; } = new(
            name: "evalDataname")
        {
            Description = @"An optional evaluation file to upload",
        };
        public CreateDatasetCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"Create a dataset by uploading a file. See ['Dataset Creation'](https://docs.cohere.com/docs/datasets#dataset-creation) for more information.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

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