//HintName: G.Commands.ClassroomCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ClassroomCommand : global::System.CommandLine.Command
    {
        public ClassroomCommand(
            ClassroomGetAnAssignmentCommand command0,
            ClassroomListAcceptedAssignmentsForAnAssignmentCommand command1,
            ClassroomGetAssignmentGradesCommand command2,
            ClassroomListClassroomsCommand command3,
            ClassroomGetAClassroomCommand command4,
            ClassroomListAssignmentsForAClassroomCommand command5)
            : base(
                name: "classroom")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
        }
    }
}