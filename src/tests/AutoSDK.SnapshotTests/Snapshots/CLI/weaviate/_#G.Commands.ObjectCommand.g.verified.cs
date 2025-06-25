//HintName: G.Commands.ObjectCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class ObjectCommand : global::System.CommandLine.Command
    {
        public ObjectCommand(
            ObjectsListCommand command0,
            ObjectsCreateCommand command1,
            ObjectsGetCommand command2,
            ObjectsUpdateCommand command3,
            ObjectsDeleteCommand command4,
            ObjectsHeadCommand command5,
            ObjectsPatchCommand command6,
            ObjectsClassGetCommand command7,
            ObjectsClassPutCommand command8,
            ObjectsClassDeleteCommand command9,
            ObjectsClassHeadCommand command10,
            ObjectsClassPatchCommand command11,
            ObjectsReferencesUpdateCommand command12,
            ObjectsReferencesCreateCommand command13,
            ObjectsReferencesDeleteCommand command14,
            ObjectsClassReferencesPutCommand command15,
            ObjectsClassReferencesCreateCommand command16,
            ObjectsClassReferencesDeleteCommand command17,
            ObjectsValidateCommand command18)
            : base(
                name: "object")
        {
            Subcommands.Add(command0);
            Subcommands.Add(command1);
            Subcommands.Add(command2);
            Subcommands.Add(command3);
            Subcommands.Add(command4);
            Subcommands.Add(command5);
            Subcommands.Add(command6);
            Subcommands.Add(command7);
            Subcommands.Add(command8);
            Subcommands.Add(command9);
            Subcommands.Add(command10);
            Subcommands.Add(command11);
            Subcommands.Add(command12);
            Subcommands.Add(command13);
            Subcommands.Add(command14);
            Subcommands.Add(command15);
            Subcommands.Add(command16);
            Subcommands.Add(command17);
            Subcommands.Add(command18);
        }
    }
}