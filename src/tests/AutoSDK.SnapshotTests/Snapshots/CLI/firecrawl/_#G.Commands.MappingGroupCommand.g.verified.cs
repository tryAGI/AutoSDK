//HintName: G.Commands.MappingGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class MappingGroupCommand : global::System.CommandLine.Command
    {
        public MappingGroupCommand(
            MappingMapUrlsCommand command0)
            : base(
                name: "mapping")
        {
            Subcommands.Add(command0);
        }
    }
}