//HintName: G.Commands.TaskManagementDeleteTasksByIdCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TaskManagementDeleteTasksByIdCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;
        private readonly global::System.IServiceProvider _serviceProvider;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Guid id,
            string xRunwayVersion,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<global::System.Guid> Id { get; } = new(
            name: "id")
        {
            Description = @"The ID of a previously-submitted task that has not been canceled or deleted.",
        };

        private global::System.CommandLine.Argument<string> XRunwayVersion { get; } = new(
            name: "xRunwayVersion")
        {
            Description = @"The version of the RunwayML API being used. You can read more about versioning [here](/api-details/versioning).",
        };



        public TaskManagementDeleteTasksByIdCommand(
            G.IApi client,
            global::System.IServiceProvider serviceProvider) : base(
            name: "delete",
            description: @"Tasks that are running, pending, or throttled can be canceled by invoking this method. Invoking this method for other tasks will delete them.

The output data associated with a deleted task will be deleted from persistent storage in accordance with our data retention policy. Aborted and deleted tasks will not be able to be fetched again in the future.")
        {
            _client = client;
            _serviceProvider = serviceProvider;

            Arguments.Add(Id);
            Arguments.Add(XRunwayVersion);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var id = parseResult.GetRequiredValue(Id);
            var xRunwayVersion = parseResult.GetRequiredValue(XRunwayVersion);

            Validate(
                parseResult: parseResult,
                id: id,
                xRunwayVersion: xRunwayVersion,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            await _client.TaskManagement.DeleteTasksByIdAsync(
                id: id,
                xRunwayVersion: xRunwayVersion,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                cancellationToken: cancellationToken);
        }
    }
}