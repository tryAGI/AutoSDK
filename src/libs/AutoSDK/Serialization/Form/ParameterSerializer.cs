using Microsoft.OpenApi.Models;
using AutoSDK.Extensions;
using AutoSDK.Models;
using AutoSDK.Serialization.Json;

namespace AutoSDK.Serialization.Form;

public static class ParameterSerializer
{
    public static string SerializePathParameters(IReadOnlyList<MethodParameter> parameters, string path)
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
    
    public static string SerializeQueryParameters(IReadOnlyList<MethodParameter> parameters)
    {
        var queryParameters = parameters
            .Where(x => x.ParameterLocation == ParameterLocation.Query)
            .Select(SerializeQueryParameter)
            .ToArray();
        
        return queryParameters.Length == 0
            ? string.Empty
            : $"?{string.Join("&", queryParameters)}";
    }
    
    public static IReadOnlyDictionary<string, string> SerializeQueryParameters2(IReadOnlyList<MethodParameter> parameters)
    {
        var queryParameters = parameters
            .Where(x => x.ParameterLocation == ParameterLocation.Query)
            .SelectMany(SerializeQueryParameter2)
            .ToDictionary(x => x.Key, x => x.Value);
        
        return queryParameters;
    }

    public static string SerializeQueryParameter(MethodParameter parameter)
    {
        if (parameter.ParameterLocation != ParameterLocation.Query)
        {
            return string.Empty;
        }

        if (parameter.Type.IsEnum)
        {
            return parameter.Settings.JsonSerializerType == JsonSerializerType.SystemTextJson
                ? $"{parameter.Id}={{(global::System.Uri.EscapeDataString({parameter.ArgumentName}{(parameter.IsRequired ? "" : "?")}.ToValueString() ?? string.Empty))}}"
                : $"{parameter.Id}={{(global::System.Uri.EscapeDataString({parameter.ArgumentName}{(parameter.IsRequired ? "" : "?")}.ToString() ?? string.Empty))}}";
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

    public static IReadOnlyCollection<KeyValuePair<string, string>> SerializeQueryParameter2(MethodParameter parameter)
    {
        if (parameter.ParameterLocation != ParameterLocation.Query)
        {
            return [];
        }

        if (parameter.Type.IsEnum)
        {
            return [new KeyValuePair<string, string>(
                parameter.Id,
                parameter.Settings.JsonSerializerType == JsonSerializerType.SystemTextJson
                    ? $"{parameter.ArgumentName}.ToValueString()"
                    : $"{parameter.ArgumentName}.ToString()")];
        }
        if (parameter.Type.IsArray)
        {
            if (parameter.ParameterExplode == true)
            {
                return SerializeQueryParameter2(MethodParameter.Default with
                {
                    Name = parameter.Name,
                    Type = parameter.Type.SubTypes[0],
                    ParameterExplode = parameter.ParameterExplode,
                    ParameterStyle = parameter.ParameterStyle,
                });
            }
            
            return [new KeyValuePair<string, string>(
                parameter.Name.ToParameterName(),
                parameter.ParameterStyle switch
                {
                    ParameterStyle.Form => $"string.Join(\",\", {parameter.ArgumentName})",
                    ParameterStyle.SpaceDelimited => $"string.Join(\"%20\", {parameter.ArgumentName})",
                    ParameterStyle.PipeDelimited => $"string.Join(\"|\", {parameter.ArgumentName})",
                    _ => throw new NotSupportedException($"Parameter style '{parameter.ParameterStyle}' is not supported."),
                })];
        }

        if (!parameter.Type.IsEnum && parameter.Type.Properties.Length != 0)
        {
            return [];
            // var pairs = parameter.Type.Properties
            //     .Select(x => (Name: x.ToParameterName(), Value: $"{{{parameter.ArgumentName}}}"))
            //     .ToArray();
            // switch (parameter.ParameterStyle, parameter.ParameterExplode ?? true)
            // {
            //     case (ParameterStyle.Form, true):
            //         return $"{string.Join("&", pairs.Select(x => $"{x.Name}={x.Value}"))}";
            //     case (ParameterStyle.Form, false):
            //         return $"{parameter.Name.ToParameterName()}={string.Join(",", pairs.Select(x => $"{x.Name},{x.Value}"))}";
            //     case (ParameterStyle.DeepObject, true):
            //         return $"{string.Join("&", pairs.Select(x => $"{parameter.Name.ToParameterName()}[{x.Name}]={{{x.Value}}}"))}";
            //     default:
            //         throw new NotSupportedException($"Parameter style '{parameter.ParameterStyle}' and explode '{parameter.ParameterExplode}' is not supported.");
            // }
        }
        
        if (parameter.Type.IsDate)
        {
            return [new KeyValuePair<string, string>(
                parameter.Id,
                $"{parameter.ArgumentName}.ToString(\"yyyy-MM-dd\")")];
        }
        if (parameter.Type.IsDateTime)
        {
            return [new KeyValuePair<string, string>(
                parameter.Id,
                $"{parameter.ArgumentName}.ToString(\"yyyy-MM-ddTHH:mm:ssZ\")")];
        }
        
        return [new KeyValuePair<string, string>(
            parameter.Id,
            parameter.ArgumentName)];
    }
}