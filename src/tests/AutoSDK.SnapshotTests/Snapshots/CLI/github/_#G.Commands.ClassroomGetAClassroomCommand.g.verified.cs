//HintName: G.Commands.ClassroomGetAClassroomCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ClassroomGetAClassroomCommand : global::System.CommandLine.Command
    {
        private readonly G.IApi _client;

        partial void Initialize();
        partial void Validate(
            global::System.CommandLine.ParseResult parseResult,
            int classroomId,
            global::System.Threading.CancellationToken cancellationToken);
        partial void Complete(
            global::System.CommandLine.ParseResult parseResult,
            global::G.Classroom response,
            global::System.Threading.CancellationToken cancellationToken);

        private global::System.CommandLine.Argument<int> ClassroomId { get; } = new(
            name: "classroomId")
        {
            Description = "",
        };

        public ClassroomGetAClassroomCommand(G.IApi client) : base(
            name: "classroom",
            description: @"Gets a GitHub Classroom classroom for the current user. Classroom will only be returned if the current user is an administrator of the GitHub Classroom.")
        {
            _client = client;

            Arguments.Add(ClassroomId);

            Initialize();

            SetAction(HandleAsync);
        }

        private async global::System.Threading.Tasks.Task HandleAsync(
            global::System.CommandLine.ParseResult parseResult,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var classroomId = parseResult.GetRequiredValue(ClassroomId);

            Validate(
                parseResult: parseResult,
                classroomId: classroomId,
                cancellationToken: cancellationToken);

            // ReSharper disable once RedundantAssignment
            var response = await _client.Classroom.ClassroomGetAClassroomAsync(
                classroomId: classroomId,
                cancellationToken: cancellationToken);

            Complete(
                parseResult: parseResult,
                response: response,
                cancellationToken: cancellationToken);
        }
    }
}