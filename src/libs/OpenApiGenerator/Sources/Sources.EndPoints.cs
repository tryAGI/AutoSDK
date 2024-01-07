using H.Generators.Extensions;
using OpenApiGenerator.Models;

namespace OpenApiGenerator;

internal static partial class Sources
{
    public static string GenerateEndPoint(
        EndPoint endPoint,
        CancellationToken cancellationToken = default)
    {
        return $@"
#nullable enable

namespace {endPoint.Namespace}
{{
    public partial class {endPoint.ClassName}
    {{
        public void {endPoint.MethodName}()
        {{
        }}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}