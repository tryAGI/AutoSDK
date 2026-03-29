//HintName: G.Commands.TemplateGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class TemplateGroupCommand : global::System.CommandLine.Command
    {
        public TemplateGroupCommand(
            TemplateCreateApplicationsByApplicationIdJobsCommand command0,
            TemplateCreateApplicationsJobsByJobIdRetryCommand command1,
            TemplateGetApplicationsByApplicationIdGraphsCommand command2,
            TemplateGetApplicationsByApplicationIdJobsCommand command3,
            TemplateGetApplicationsJobsByJobIdCommand command4,
            TemplatePutApplicationsByApplicationIdGraphsCommand command5)
            : base(
                name: "template")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
        }
    }
}