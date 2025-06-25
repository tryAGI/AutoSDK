//HintName: G.Commands.ClassroomGetAssignmentGradesCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ClassroomGetAssignmentGradesCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int assignmentId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Collections.Generic.IList<global::G.ClassroomAssignmentGrade> response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> AssignmentId { get; } = new(
            name: "assignmentId")
        {
            Description = "",
        };

        public ClassroomGetAssignmentGradesCommand(G.IApi client) : base(
            name: "classroom",
            description: @"Gets grades for a GitHub Classroom assignment. Grades will only be returned if the current user is an administrator of the GitHub Classroom for the assignment.")
        {
            _client = client;

            Arguments.Add(AssignmentId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var assignmentId = parseResult.GetRequiredValue(AssignmentId);

            Validate(
                parseResult: parseResult,
                assignmentId: assignmentId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Classroom.ClassroomGetAssignmentGradesAsync(
                assignmentId: assignmentId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}