//HintName: G.Commands.FineTuningCreateFineTuningCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class FineTuningCreateFineTuningCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            string? baseModel,
            string? inputFileId,
            string? name,
            string? type,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,

            global::G.ReadFineTuningResponse response,
            global::System.Threading.CancellationToken cancellationToken);


        private global::System.CommandLine.Option<string?> BaseModel { get; } = new(
            name: "baseModel")
        {
            Description = @"BaseModel is the model that the fine tune was originally trained on.",
        };

        private global::System.CommandLine.Option<string?> InputFileId { get; } = new(
            name: "inputFileId")
        {
            Description = @"InputFileID is the id of the file that was uploaded via the /files api.",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"Name is the given name to a fine tuned model.",
        };

        private global::System.CommandLine.Option<string?> Type { get; } = new(
            name: "type")
        {
            Description = @"Type is the type of fine tuning format such as ""lora"".",
        };


        public FineTuningCreateFineTuningCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "create",
            description: @"")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Options.Add(BaseModel);
            Options.Add(InputFileId);
            Options.Add(Name);
            Options.Add(Type);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var baseModel = parseResult.GetRequiredValue(BaseModel);
            var inputFileId = parseResult.GetRequiredValue(InputFileId);
            var name = parseResult.GetRequiredValue(Name);
            var type = parseResult.GetRequiredValue(Type);

            Validate(
                parseResult: parseResult,
                baseModel: baseModel,
                inputFileId: inputFileId,
                name: name,
                type: type,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.FineTuning.CreateFineTuningAsync(
                baseModel: baseModel,
                inputFileId: inputFileId,
                name: name,
                type: type,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,

                response: response,
                cancellationToken: cancellationToken);
        }
    }
}