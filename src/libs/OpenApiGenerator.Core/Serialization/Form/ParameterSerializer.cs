using Microsoft.OpenApi.Models;
using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Models;

namespace OpenApiGenerator.Core.Serialization.Form;

public static class ParameterSerializer
{
    public static string SerializePathParameters(IReadOnlyList<PropertyData> parameters, string path)
    {
        path = path ?? throw new ArgumentNullException(nameof(path));
        
        foreach (var parameter in parameters.Where(x => x.ParameterLocation == ParameterLocation.Path))
        {
            path = path.Replace($"{{{parameter.Id}}}", $"{{{parameter.ArgumentName}}}");
            path = path.Replace($"{{{parameter.Id}*}}", $"{{{parameter.ArgumentName}}}");
            path = path.Replace($"{{.{parameter.Id}}}", $"{{.{parameter.ArgumentName}}}");
            path = path.Replace($"{{.{parameter.Id}*}}", $"{{.{parameter.ArgumentName}}}");
            path = path.Replace($"{{;{parameter.Id}}}", $"{{;{parameter.ArgumentName}}}");
            path = path.Replace($"{{;{parameter.Id}*}}", $"{{;{parameter.ArgumentName}}}");
        }

        return path;
    }
    
    public static string SerializeQueryParameters(IReadOnlyList<PropertyData> parameters)
    {
        var queryParameters = parameters
            .Where(x => x.ParameterLocation == ParameterLocation.Query)
            .Select(SerializeQueryParameter)
            .ToArray();
        
        return queryParameters.Length == 0
            ? string.Empty
            : $"?{string.Join("&", queryParameters)}";
    }

    public static string SerializeQueryParameter(PropertyData parameter)
    {
        if (parameter.ParameterLocation != ParameterLocation.Query)
        {
            return string.Empty;
        }

        if (parameter.Type.IsArray)
        {
            if (parameter.ParameterExplode == true)
            {
                return $"{{string.Join(\"&\", {parameter.ArgumentName}{(parameter.IsRequired ? "" : "?")}.Select(static x => $\"{parameter.Name.ToParameterName()}={{x}}\"){(parameter.IsRequired ? "" : " ?? global::System.Array.Empty<string>()")})}}";
            }
            
            switch (parameter.ParameterStyle)
            {
                case ParameterStyle.Form:
                    return $"{parameter.Name.ToParameterName()}={{string.Join(\",\", {parameter.ArgumentName})}}";
                case ParameterStyle.SpaceDelimited:
                    return $"{parameter.Name.ToParameterName()}={{string.Join(\"%20\", {parameter.ArgumentName})}}";
                case ParameterStyle.PipeDelimited:
                    return $"{parameter.Name.ToParameterName()}={{string.Join(\"|\", {parameter.ArgumentName})}}";
                default:
                    throw new NotSupportedException($"Parameter style '{parameter.ParameterStyle}' is not supported.");
            }
        }

        if (!parameter.Type.IsEnum && parameter.Type.Properties.Length != 0)
        {
            var pairs = parameter.Type.Properties
                .Select(x => (Name: x.ToParameterName(), Value: $"{{{parameter.ArgumentName}}}"))
                .ToArray();
            switch (parameter.ParameterStyle, parameter.ParameterExplode ?? true)
            {
                case (ParameterStyle.Form, true):
                    return $"{string.Join("&", pairs.Select(x => $"{x.Name}={x.Value}"))}";
                case (ParameterStyle.Form, false):
                    return $"{parameter.Name.ToParameterName()}={string.Join(",", pairs.Select(x => $"{x.Name},{x.Value}"))}";
                case (ParameterStyle.DeepObject, true):
                    return $"{string.Join("&", pairs.Select(x => $"{parameter.Name.ToParameterName()}[{x.Name}]={{{x.Value}}}"))}";
                default:
                    throw new NotSupportedException($"Parameter style '{parameter.ParameterStyle}' and explode '{parameter.ParameterExplode}' is not supported.");
            }
        }
        
        if (parameter.Type.IsDate)
        {
            return $"{parameter.Id}={{{parameter.ArgumentName}:yyyy-MM-dd}}";
        }
        if (parameter.Type.IsDateTime)
        {
            return $"{parameter.Id}={{{parameter.ArgumentName}:yyyy-MM-ddTHH:mm:ssZ}}";
        }
        
        return $"{parameter.Id}={{{parameter.ArgumentName}}}";
    }
}