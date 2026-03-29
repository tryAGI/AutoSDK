//HintName: G.Commands.AnnotationQueueGroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class AnnotationQueueGroupCommand : global::System.CommandLine.Command
    {
        public AnnotationQueueGroupCommand(
            AnnotationQueuesAddItemsToAnnotationQueueCommand command0,
            AnnotationQueuesCreateAnnotationQueueCommand command1,
            AnnotationQueuesCreateAnnotationQueueBatchCommand command2,
            AnnotationQueuesDeleteAnnotationQueueBatchCommand command3,
            AnnotationQueuesFindAnnotationQueuesCommand command4,
            AnnotationQueuesGetAnnotationQueueByIdCommand command5,
            AnnotationQueuesRemoveItemsFromAnnotationQueueCommand command6,
            AnnotationQueuesUpdateAnnotationQueueCommand command7)
            : base(
                name: "annotationqueue")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
            Subcommands.Add(command6);
            Subcommands.Add(command7);
        }
    }
}