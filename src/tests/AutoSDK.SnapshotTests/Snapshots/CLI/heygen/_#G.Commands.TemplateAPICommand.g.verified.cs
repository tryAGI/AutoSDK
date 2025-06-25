//HintName: G.Commands.TemplateAPICommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TemplateAPICommand : global::System.CommandLine.Command
    {
        public TemplateAPICommand(
            V2TemplatesCommand command0,
            V2TemplateIdCommand command1,
            V2TemplateGenerateCommand command2)
            : base(
                name: "templateapi")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}