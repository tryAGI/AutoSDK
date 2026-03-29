//HintName: G.Commands.GuardrailGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GuardrailGroupCommand : global::System.CommandLine.Command
    {
        public GuardrailGroupCommand(
            GuardrailsCreateGuardrailsCommand command0)
            : base(
                name: "guardrail")
        {
            Subcommands.Add(command0);
        }
    }
}