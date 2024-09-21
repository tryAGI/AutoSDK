using AutoSDK.Extensions;
using Microsoft.OpenApi.Models;
using AutoSDK.Models;
using AutoSDK.Serialization.Json;

namespace AutoSDK.Serialization.Form;

public static class ParameterSerializer
{
    public static string SerializePathParameters(IList<MethodParameter> parameters, string path)
    {
        path = path ?? throw new ArgumentNullException(nameof(path));
        
        foreach (var parameter in parameters.Where(x => x.Location == ParameterLocation.Path))
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
    public static IList<MethodParameter> SerializeQueryParameters(IList<MethodParameter> parameters)
    {
        parameters = parameters ?? throw new ArgumentNullException(nameof(parameters));
        
        return parameters
            .Where(x => x.Location == ParameterLocation.Query)
            .SelectMany(SerializeQueryParameter)
            .ToList();
    }
    //
    // public static string SerializeQueryParameterOld(MethodParameter parameter)
    // {
    //     if (parameter.Location != ParameterLocation.Query)
    //     {
    //         return string.Empty;
    //     }
    //
    //     if (parameter.Type.IsEnum)
    //     {
    //         return parameter.Settings.JsonSerializerType == JsonSerializerType.SystemTextJson
    //             ? $"{parameter.Id}={{(global::System.Uri.EscapeDataString({parameter.ArgumentName}{(parameter.IsRequired ? "" : "?")}.ToValueString() ?? string.Empty))}}"
    //             : $"{parameter.Id}={{(global::System.Uri.EscapeDataString({parameter.ArgumentName}{(parameter.IsRequired ? "" : "?")}.ToString() ?? string.Empty))}}";
    //     }
    //     if (parameter.Type.IsArray)
    //     {
    //         if (parameter.Explode)
    //         {
    //             return $"{{string.Join(\"&\", {parameter.ArgumentName}{(parameter.IsRequired ? "" : "?")}.Select(static x => $\"{parameter.Name.ToParameterName()}={{x}}\"){(parameter.IsRequired ? "" : " ?? global::System.Array.Empty<string>()")})}}";
    //         }
    //         
    //         switch (parameter.Style)
    //         {
    //             case ParameterStyle.Form:
    //                 return $"{parameter.Name.ToParameterName()}={{string.Join(\",\", {parameter.ArgumentName})}}";
    //             case ParameterStyle.SpaceDelimited:
    //                 return $"{parameter.Name.ToParameterName()}={{string.Join(\"%20\", {parameter.ArgumentName})}}";
    //             case ParameterStyle.PipeDelimited:
    //                 return $"{parameter.Name.ToParameterName()}={{string.Join(\"|\", {parameter.ArgumentName})}}";
    //             default:
    //                 throw new NotSupportedException($"Parameter style '{parameter.Style}' is not supported.");
    //         }
    //     }
    //
    //     if (!parameter.Type.IsEnum && parameter.Type.Properties.Length != 0)
    //     {
    //         var pairs = parameter.Type.Properties
    //             .Select(x => (Name: x.ToParameterName(), Value: $"{{{parameter.ArgumentName}}}"))
    //             .ToArray();
    //         switch (parameter.Style, parameter.Explode)
    //         {
    //             case (ParameterStyle.Form, true):
    //                 return $"{string.Join("&", pairs.Select(x => $"{x.Name}={x.Value}"))}";
    //             case (ParameterStyle.Form, false):
    //                 return $"{parameter.Name.ToParameterName()}={string.Join(",", pairs.Select(x => $"{x.Name},{x.Value}"))}";
    //             case (ParameterStyle.DeepObject, true):
    //                 return $"{string.Join("&", pairs.Select(x => $"{parameter.Name.ToParameterName()}[{x.Name}]={{{x.Value}}}"))}";
    //             default:
    //                 throw new NotSupportedException($"Parameter style '{parameter.Style}' and explode '{parameter.Explode}' is not supported.");
    //         }
    //     }
    //     
    //     if (parameter.Type.IsDate)
    //     {
    //         return $"{parameter.Id}={{{parameter.ArgumentName}:yyyy-MM-dd}}";
    //     }
    //     if (parameter.Type.IsDateTime)
    //     {
    //         return $"{parameter.Id}={{{parameter.ArgumentName}:yyyy-MM-ddTHH:mm:ssZ}}";
    //     }
    //     
    //     return $"{parameter.Id}={{{parameter.ArgumentName}}}";
    // }

    public static IReadOnlyCollection<MethodParameter> SerializeQueryParameter(MethodParameter parameter)
    {
        if (parameter.Location != ParameterLocation.Query)
        {
            return [parameter];
        }

        if (parameter.Type.CSharpTypeWithoutNullability == "string")
        {
            return [parameter with
            {
                Value = parameter.ArgumentName,
            }];
        }
        if (parameter.Type.IsEnum)
        {
            return [parameter with
            {
                Value = parameter.Settings.JsonSerializerType == JsonSerializerType.SystemTextJson
                    ? $"{parameter.ArgumentName}{(parameter.IsRequired ? "" : "?")}.ToValueString()"
                    : $"{parameter.ArgumentName}{(parameter.IsRequired ? "" : "?")}.ToString()",
            }];
        }
        if (parameter.Type.IsArray)
        {
            return [parameter with
            {
                Value = parameter.ArgumentName,
                Selector = SerializeQueryParameter(parameter with {
                    Name = "x",
                    Type = parameter.Type.SubTypes[0],
                    IsRequired = true,
                }).FirstOrDefault().Value ?? "x",
                Delimiter = parameter.Style switch
                {
                    ParameterStyle.Form => ",",
                    ParameterStyle.SpaceDelimited => "%20",
                    ParameterStyle.PipeDelimited => "|",
                    _ => throw new NotSupportedException($"Parameter style '{parameter.Style}' is not supported."),
                },
                Explode = parameter.Explode,
            }];
        }

        if (!parameter.Type.IsEnum && parameter.Type.Properties.Length != 0)
        {
            var pairs = parameter.Properties
                .Select(x => (
                    Name: x.Id.ToParameterName(),
                    Value: $"{parameter.ArgumentName}{(parameter.IsRequired ? "" : "?")}." + SerializeQueryParameter(parameter with {
                        Name = x.Id,
                        Type = x.Type,
                        IsRequired = x.IsRequired,
                    }).FirstOrDefault().Value.ToPropertyName()))
                .ToArray();
            switch (parameter.Style, parameter.Explode)
            {
                case (ParameterStyle.Form, true):
                    return pairs.Select(x => parameter with
                    {
                        Id = x.Name,
                        Name = x.Name,
                        Value = x.Value,
                        Explode = parameter.Explode,
                    }).ToArray();
                case (ParameterStyle.Form, false):
                    return [parameter with
                    {
                        Value = $"{parameter.Name.ToParameterName()}={string.Join(",", pairs.Select(x => $"{x.Name},{x.Value}"))}",
                        Explode = parameter.Explode,
                    }];
                case (ParameterStyle.DeepObject, true):
                    return pairs.Select(x => parameter with
                    {
                        Id = $"{parameter.Name.ToParameterName()}[{x.Name}]",
                        Name = parameter.Name.ToParameterName(),
                        Value = x.Value,
                        Explode = parameter.Explode,
                    }).ToArray();
                default:
                    return [];
            }
        }
        
        if (parameter.Type.IsDate)
        {
            return [parameter with
            {
                Value = $"{parameter.ArgumentName}{(parameter.IsRequired ? "" : "?")}.ToString(\"yyyy-MM-dd\")",
            }];
        }
        if (parameter.Type.IsDateTime)
        {
            return [parameter with
            {
                Value = $"{parameter.ArgumentName}{(parameter.IsRequired ? "" : "?")}.ToString(\"yyyy-MM-ddTHH:mm:ssZ\")",
            }];
        }
        if (parameter.Type.IsAnyOfLike)
        {
            return [parameter with
            {
                Value = $"{parameter.ArgumentName}{(parameter.IsRequired ? "" : "?")}.ToString() ?? string.Empty",
            }];
        }
        
        return [parameter with
        {
            Value = $"{parameter.ArgumentName}{(parameter.IsRequired ? "" : "?")}.ToString()",
        }];
    }
}