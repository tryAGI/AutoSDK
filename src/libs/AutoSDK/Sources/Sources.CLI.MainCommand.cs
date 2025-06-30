using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Generation;

public static partial class Sources
{
    public static string GenerateMainCommand(
        EquatableArray<Tag> values,
        CancellationToken cancellationToken = default)
    {
        if (values.IsEmpty)
        {
            return string.Empty;
        }
        
        return $@"
#nullable enable

namespace {values[0].GlobalSettings.Namespace}
{{
    internal sealed class MainCommand : global::System.CommandLine.RootCommand
    {{
        public MainCommand(
{values.Select(x => $"{x.SingularizedName}GroupCommand").Distinct().Select((type, i) => @$"
            {type} command{i},").Inject().TrimEnd(',')})
            : base(
                description: ""CLI tool"")
        {{
{values.Select(x => $"{x.SingularizedName}GroupCommand").Distinct().Select((type, i) => @$"
            Subcommands.Add(command{i});").Inject()}
        }}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}