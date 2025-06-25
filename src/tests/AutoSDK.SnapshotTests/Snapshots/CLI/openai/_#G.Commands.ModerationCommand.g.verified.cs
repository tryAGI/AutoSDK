//HintName: G.Commands.ModerationCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ModerationCommand : global::System.CommandLine.Command
    {
        public ModerationCommand(
            CreateModerationCommand command0)
            : base(
                name: "moderation")
        {
            Subcommands.Add(command0);
        }
    }
}