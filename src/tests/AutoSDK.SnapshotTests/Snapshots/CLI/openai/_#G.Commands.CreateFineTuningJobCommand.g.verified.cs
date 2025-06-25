//HintName: G.Commands.CreateFineTuningJobCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CreateFineTuningJobCommand : global::System.CommandLine.Command
    {
        private readonly G.IOpenAiClient _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::G.AnyOf<string, global::G.CreateFineTuningJobRequestModel?> model,
            string trainingFile,
            global::G.CreateFineTuningJobRequestHyperparameters? hyperparameters,
            string? suffix,
            string? validationFile,
            global::System.Collections.Generic.IList<global::G.CreateFineTuningJobRequestIntegration>? integrations,
            int? seed,
            global::G.FineTuneMethod? method,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.FineTuningJob response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::G.AnyOf<string, global::G.CreateFineTuningJobRequestModel?>> Model { get; } = new(
            name: "model")
        {
            Description = "",
        };

        private global::System.CommandLine.Argument<string> TrainingFile { get; } = new(
            name: "trainingFile")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.CreateFineTuningJobRequestHyperparameters?> Hyperparameters { get; } = new(
            name: "hyperparameters")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> Suffix { get; } = new(
            name: "suffix")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<string?> ValidationFile { get; } = new(
            name: "validationFile")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.IList<global::G.CreateFineTuningJobRequestIntegration>?> Integrations { get; } = new(
            name: "integrations")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<int?> Seed { get; } = new(
            name: "seed")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::G.FineTuneMethod?> Method { get; } = new(
            name: "method")
        {
            Description = "",
        };

        private global::System.CommandLine.Option<global::System.Collections.Generic.Dictionary<string, string>?> Metadata { get; } = new(
            name: "metadata")
        {
            Description = "",
        };
        public CreateFineTuningJobCommand(G.IOpenAiClient client) : base(
            name: "create",
            description: @"")
        {
            _client = client;

            Arguments.Add(Model);
            Arguments.Add(TrainingFile);
            Options.Add(Hyperparameters);
            Options.Add(Suffix);
            Options.Add(ValidationFile);
            Options.Add(Integrations);
            Options.Add(Seed);
            Options.Add(Method);
            Options.Add(Metadata);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var model = parseResult.GetRequiredValue(Model);
            var trainingFile = parseResult.GetRequiredValue(TrainingFile);
            var hyperparameters = parseResult.GetRequiredValue(Hyperparameters);
            var suffix = parseResult.GetRequiredValue(Suffix);
            var validationFile = parseResult.GetRequiredValue(ValidationFile);
            var integrations = parseResult.GetRequiredValue(Integrations);
            var seed = parseResult.GetRequiredValue(Seed);
            var method = parseResult.GetRequiredValue(Method);
            var metadata = parseResult.GetRequiredValue(Metadata);

            Validate(
                parseResult: parseResult,
                model: model,
                trainingFile: trainingFile,
                hyperparameters: hyperparameters,
                suffix: suffix,
                validationFile: validationFile,
                integrations: integrations,
                seed: seed,
                method: method,
                metadata: metadata,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.FineTuning.CreateFineTuningJobAsync(
                model: model,
                trainingFile: trainingFile,
                hyperparameters: hyperparameters,
                suffix: suffix,
                validationFile: validationFile,
                integrations: integrations,
                seed: seed,
                method: method,
                metadata: metadata,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}