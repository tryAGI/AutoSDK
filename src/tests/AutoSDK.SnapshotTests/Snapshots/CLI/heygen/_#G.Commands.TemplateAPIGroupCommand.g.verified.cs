//HintName: G.Commands.TemplateApiGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TemplateApiGroupCommand : global::System.CommandLine.Command
    {
        public TemplateApiGroupCommand(
            TemplateApiV2TemplatesCommand command0,
            TemplateApiV2TemplateIdCommand command1,
            TemplateApiV2TemplateGenerateCommand command2)
            : base(
                name: "templateapi")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
        }
    }
}