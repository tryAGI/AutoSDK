//HintName: G.Commands.CheckCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class CheckCommand : global::System.CommandLine.Command
    {
        public CheckCommand(
            ChecksCreateCommand command0,
            ChecksGetCommand command1,
            ChecksUpdateCommand command2,
            ChecksListAnnotationsCommand command3,
            ChecksRerequestRunCommand command4,
            ChecksCreateSuiteCommand command5,
            ChecksSetSuitesPreferencesCommand command6,
            ChecksGetSuiteCommand command7,
            ChecksListForSuiteCommand command8,
            ChecksRerequestSuiteCommand command9,
            ChecksListForRefCommand command10,
            ChecksListSuitesForRefCommand command11)
            : base(
                name: "check")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
            Subcommands.Add(command6);
            Subcommands.Add(command7);
            Subcommands.Add(command8);
            Subcommands.Add(command9);
            Subcommands.Add(command10);
            Subcommands.Add(command11);
        }
    }
}