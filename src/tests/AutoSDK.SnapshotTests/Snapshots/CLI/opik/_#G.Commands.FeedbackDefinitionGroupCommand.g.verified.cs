//HintName: G.Commands.FeedbackDefinitionGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class FeedbackDefinitionGroupCommand : global::System.CommandLine.Command
    {
        public FeedbackDefinitionGroupCommand(
            FeedbackDefinitionsCreateFeedbackDefinitionCommand command0,
            FeedbackDefinitionsDeleteFeedbackDefinitionByIdCommand command1,
            FeedbackDefinitionsDeleteFeedbackDefinitionsBatchCommand command2,
            FeedbackDefinitionsFindFeedbackDefinitionsCommand command3,
            FeedbackDefinitionsGetFeedbackDefinitionByIdCommand command4,
            FeedbackDefinitionsUpdateFeedbackDefinitionCommand command5)
            : base(
                name: "feedbackdefinition")
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