//HintName: G.Commands.MetaInformationGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MetaInformationGroupCommand : global::System.CommandLine.Command
    {
        public MetaInformationGroupCommand(
            MetaInformationGetLanguagesCommand command0,
            MetaInformationGetUsageCommand command1)
            : base(
                name: "metainformation")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}