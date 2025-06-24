using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Generation;

#pragma warning disable CA1308

public static partial class Sources
{
    public static string GenerateTagCommand(
        Tag tag,
        EquatableArray<EndPoint> values,
        CancellationToken cancellationToken = default)
    {
        if (values.IsEmpty)
        {
            return string.Empty;
        }
        
        return $@"
#nullable enable

namespace {values[0].Settings.Namespace}
{{
    internal sealed partial class {tag.SingularizedName}Command : global::System.CommandLine.Command
    {{
        public {tag.SingularizedName}Command(
{values.Select(x => $"{x.MethodName}Command").Distinct().Select((type, i) => @$"
            {type} command{i},").Inject().TrimEnd(',')})
            : base(
                name: ""{tag.SingularizedName.ToLowerInvariant()}"")
        {{
{values.Select(x => $"{x.MethodName}Command").Distinct().Select((type, i) => @$"
            Subcommands.Add(command{i});").Inject()}
        }}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}