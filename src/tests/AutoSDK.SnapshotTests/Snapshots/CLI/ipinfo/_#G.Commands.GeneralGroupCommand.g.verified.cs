//HintName: G.Commands.GeneralGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GeneralGroupCommand : global::System.CommandLine.Command
    {
        public GeneralGroupCommand(
            GetCurrentInformationCommand command0,
            BatchCommand command1,
            GetInformationByIpCommand command2)
            : base(
                name: "general")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}