//HintName: G.Commands.FunctionGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class FunctionGroupCommand : global::System.CommandLine.Command
    {
        public FunctionGroupCommand(
            FunctionAttachFunctionCommand command0,
            FunctionDetachFunctionCommand command1,
            FunctionGetAttachedFunctionCommand command2)
            : base(
                name: "function")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}