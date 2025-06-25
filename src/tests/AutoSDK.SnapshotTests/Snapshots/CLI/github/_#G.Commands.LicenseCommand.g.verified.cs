//HintName: G.Commands.LicenseCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class LicenseCommand : global::System.CommandLine.Command
    {
        public LicenseCommand(
            LicensesGetAllCommonlyUsedCommand command0,
            LicensesGetCommand command1,
            LicensesGetForRepoCommand command2)
            : base(
                name: "license")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}