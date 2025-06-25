//HintName: G.Commands.WellKnownCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class WellKnownCommand : global::System.CommandLine.Command
    {
        public WellKnownCommand(
            WeaviateWellknownLivenessCommand command0,
            WeaviateWellknownReadinessCommand command1,
            GetWellKnownOpenidConfigurationCommand command2)
            : base(
                name: "wellknown")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}