//HintName: G.Commands.GroupCommand.g.cs

#nullable enable

namespace G
{
    internal sealed partial class GroupCommand : global::System.CommandLine.Command
    {
        public GroupCommand(
            ContextsCreateCommand command0,
            ContextsDeleteCommand command1,
            ContextsGetCommand command2,
            ContextsUpdateCommand command3,
            ExtensionsDeleteCommand command4,
            ExtensionsGetCommand command5,
            ExtensionsUploadCommand command6,
            FetchCreateCommand command7,
            FunctionBuildsGetCommand command8,
            FunctionBuildsGetLogsCommand command9,
            FunctionBuildsListCommand command10,
            FunctionVersionsGetCommand command11,
            FunctionVersionsListInvocationsCommand command12,
            FunctionsGetCommand command13,
            FunctionsInvokeCommand command14,
            FunctionsListCommand command15,
            FunctionsListVersionsCommand command16,
            InvocationsGetCommand command17,
            InvocationsGetLogsCommand command18,
            ProjectsGetCommand command19,
            ProjectsListCommand command20,
            ProjectsUsageCommand command21,
            SearchWebCommand command22,
            SessionsCreateCommand command23,
            SessionsDeleteDownloadsCommand command24,
            SessionsGetCommand command25,
            SessionsGetDebugCommand command26,
            SessionsGetDownloadsCommand command27,
            SessionsGetLogsCommand command28,
            SessionsGetRecordingCommand command29,
            SessionsListCommand command30,
            SessionsUpdateCommand command31,
            SessionsUploadFileCommand command32)
            : base(
                name: "")
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
            Subcommands.Add(command19);
            Subcommands.Add(command20);
            Subcommands.Add(command21);
            Subcommands.Add(command22);
            Subcommands.Add(command23);
            Subcommands.Add(command24);
            Subcommands.Add(command25);
            Subcommands.Add(command26);
            Subcommands.Add(command27);
            Subcommands.Add(command28);
            Subcommands.Add(command29);
            Subcommands.Add(command30);
            Subcommands.Add(command31);
            Subcommands.Add(command32);
        }
    }
}