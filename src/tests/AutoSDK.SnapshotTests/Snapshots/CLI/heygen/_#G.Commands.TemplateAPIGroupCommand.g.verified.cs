//HintName: G.Commands.TemplateAPIGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TemplateAPIGroupCommand : global::System.CommandLine.Command
    {
        public TemplateAPIGroupCommand(
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