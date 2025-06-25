//HintName: G.Commands.GeneralCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GeneralCommand : global::System.CommandLine.Command
    {
        public GeneralCommand(
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