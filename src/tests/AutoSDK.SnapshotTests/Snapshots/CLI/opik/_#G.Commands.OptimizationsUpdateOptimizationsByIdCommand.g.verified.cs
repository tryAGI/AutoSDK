//HintName: G.Commands.OptimizationsUpdateOptimizationsByIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class OptimizationsUpdateOptimizationsByIdCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid id,
            string? name,
            global::G.OptimizationUpdateStatus? status,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> Id { get; } = new(
            name: "id")
        {
            Description = @"",
        };

        private new global::System.CommandLine.Option<string?> Name { get; } = new(
            name: "name")
        {
            Description = @"",
        };

        private global::System.CommandLine.Option<global::G.OptimizationUpdateStatus?> Status { get; } = new(
            name: "status")
        {
            Description = @"",
        };


        public OptimizationsUpdateOptimizationsByIdCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "update",
            description: @"Update optimization by id")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Id);
            Options.Add(Name);
            Options.Add(Status);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var name = parseResult.GetRequiredValue(Name);
            var status = parseResult.GetRequiredValue(Status);

            Validate(
                parseResult: parseResult,
                id: id,
                name: name,
                status: status,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.Optimizations.UpdateOptimizationsByIdAsync(
                id: id,
                name: name,
                status: status,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}