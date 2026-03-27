using AutoSDK.Models;
using AutoSDK.Serialization.Form;
using Microsoft.OpenApi;

namespace AutoSDK.Extensions;

public static class OpenApiPathExtensions
{
    public static string PreparePath(this string path, IList<MethodParameter> parameters)
    {
        path = path ?? throw new ArgumentNullException(nameof(path));
        parameters = parameters ?? throw new ArgumentNullException(nameof(parameters));

        path = ParameterSerializer.SerializePathParameters(parameters, path);

        path = $"\"{path}\"";
        if (parameters.Any(x => x.Location is ParameterLocation.Path))
        {
            path = $"${path}";
        }

        return path;
    }
}
