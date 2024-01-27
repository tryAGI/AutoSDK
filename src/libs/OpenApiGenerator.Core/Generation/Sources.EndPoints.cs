using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Models;

namespace OpenApiGenerator.Core.Generation;

public static partial class Sources
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