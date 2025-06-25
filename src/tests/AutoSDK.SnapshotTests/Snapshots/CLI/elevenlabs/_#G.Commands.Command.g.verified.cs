//HintName: G.Commands.Command.g.cs

#nullable enable

namespace G
{
    internal sealed partial class Command : global::System.CommandLine.Command
    {
        public Command(
            GetConvaiSecretsCommand command0,
            GetDocsCommand command1)
            : base(
                name: "")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
        }
    }
}