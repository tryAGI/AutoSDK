using AutoSDK.Extensions;
using AutoSDK.Helpers;
using AutoSDK.Models;
using AutoSDK.Naming.Parameters;
using AutoSDK.TypeMapping;
using Microsoft.OpenApi;

namespace AutoSDK.Serialization.Form;

public static class ParameterSerializer
{
    public static string SerializePathParameters(IList<MethodParameter> parameters, string path)
    {
        path = path ?? throw new ArgumentNullException(nameof(path));

        foreach (var parameter in parameters.Where(x => x.Location == ParameterLocation.Path))
        {
            var valueExpression = GetPathParameterValueExpression(parameter);
            path = path.Replace($"{{{parameter.Id}}}", $"{{{valueExpression}}}");
            path = path.Replace($"{{{parameter.Id}*}}", $"{{{valueExpression}}}");
            path = path.Replace($"{{.{parameter.Id}}}", $"{{.{valueExpression}}}");
            path = path.Replace($"{{.{parameter.Id}*}}", $"{{.{valueExpression}}}");
            path = path.Replace($"{{;{parameter.Id}}}", $"{{;{valueExpression}}}");
            path = path.Replace($"{{;{parameter.Id}*}}", $"{{;{valueExpression}}}");
        }

        return path;
    }

    private static string GetPathParameterValueExpression(MethodParameter parameter)
    {
        if (!parameter.Type.IsEnum || parameter.Type.IsAnyOfLike)
        {
            return parameter.ArgumentName;
        }

        var valueExpression = $"{parameter.ParameterName}{(parameter.Type.CSharpTypeNullability ? "?" : string.Empty)}.ToValueString()";
        if (parameter.Type.CSharpTypeNullability)
        {
            valueExpression = $"{valueExpression} ?? string.Empty";
        }

        return $"(global::System.Uri.EscapeDataString({valueExpression}))";
    }

    public static IList<MethodParameter> SerializeQueryParameters(IList<MethodParameter> parameters)
    {
        parameters = parameters ?? throw new ArgumentNullException(nameof(parameters));

        var serialized = new List<MethodParameter>(parameters.Count);
        AppendSerializedQueryParameters(parameters, serialized);
        return serialized;
    }

    private static void AppendSerializedQueryParameters(
        IList<MethodParameter> parameters,
        ICollection<MethodParameter> serialized)
    {
        for (var i = 0; i < parameters.Count; i++)
        {
            if (parameters[i].Location == ParameterLocation.Query)
            {
                AppendSerializedQueryParameter(parameters[i], serialized);
            }
        }
    }

    public static IReadOnlyCollection<MethodParameter> SerializeQueryParameter(MethodParameter parameter)
    {
        var serialized = new List<MethodParameter>(1);
        AppendSerializedQueryParameter(parameter, serialized);
        return serialized;
    }

    private static void AppendSerializedQueryParameter(
        MethodParameter parameter,
        ICollection<MethodParameter> serialized)
    {
        if (parameter.Location != ParameterLocation.Query)
        {
            serialized.Add(parameter);
            return;
        }

        if (parameter.Type.CSharpTypeWithoutNullability == "string")
        {
            serialized.Add(parameter with
            {
                Value = parameter.ArgumentName,
            });
            return;
        }

        if (parameter.Type.IsAnyOfLike)
        {
            serialized.Add(parameter with
            {
                Value = $"{parameter.ArgumentName}{(parameter.Type.CSharpTypeNullability ? "?" : "")}.ToString(){(parameter.IsRequired ? " ?? string.Empty" : "")}",
            });
            return;
        }

        if (parameter.Type.IsEnum)
        {
            serialized.Add(parameter with
            {
                Value = $"{parameter.ParameterName}{(parameter.Type.CSharpTypeNullability ? "?" : "")}.ToValueString()",
            });
            return;
        }

        if (parameter.Type.IsArray)
        {
            var itemParameter = (parameter with
            {
                Name = "x",
                ParameterName = string.Empty,
                ArgumentName = string.Empty,
                Type = (parameter.Type.SubTypes[0].Unbox<TypeData>() with { CSharpTypeNullability = false }).WithCSharpComputedValues(),
                IsRequired = true,
            }).WithCSharpParameterNames();
            serialized.Add(parameter with
            {
                Value = parameter.ArgumentName,
                Selector = GetFirstSerializedValue(itemParameter) ?? "x",
                Delimiter = parameter.Style switch
                {
                    ParameterStyle.Form => ",",
                    ParameterStyle.SpaceDelimited => "%20",
                    ParameterStyle.PipeDelimited => "|",
                    _ => throw new NotSupportedException($"Parameter style '{parameter.Style}' is not supported."),
                },
                Explode = parameter.Explode,
            });
            return;
        }

        if (!parameter.Type.IsEnum && parameter.Type.Properties.Length != 0)
        {
            var pairs = parameter.Properties
                .Select(x => (
                    Name: x.Id.ToParameterName(),
                    Value: $"{parameter.ArgumentName}{(parameter.Type.CSharpTypeNullability ? "?" : "")}." + SerializeQueryParameter((parameter with
                    {
                        Name = x.Id,
                        ParameterName = string.Empty,
                        ArgumentName = string.Empty,
                        Type = x.Type,
                        IsRequired = x.IsRequired,
                    }).WithCSharpParameterNames()).FirstOrDefault().Value.ToPropertyName()))
                .ToArray();

            switch (parameter.Style, parameter.Explode)
            {
                case (ParameterStyle.Form, true):
                    foreach (var pair in pairs)
                    {
                        serialized.Add((parameter with
                        {
                            Id = pair.Name,
                            Name = pair.Name,
                            ParameterName = string.Empty,
                            ArgumentName = string.Empty,
                            Value = pair.Value,
                            Explode = parameter.Explode,
                        }).WithCSharpParameterNames());
                    }
                    return;
                case (ParameterStyle.Form, false):
                    serialized.Add(parameter with
                    {
                        Value = $"{parameter.Name.ToParameterName()}={string.Join(",", pairs.Select(x => $"{x.Name},{x.Value}"))}",
                        Explode = parameter.Explode,
                    });
                    return;
                case (ParameterStyle.DeepObject, true):
                    foreach (var pair in pairs)
                    {
                        serialized.Add((parameter with
                        {
                            Id = $"{parameter.Name.ToParameterName()}[{pair.Name}]",
                            Name = parameter.Name.ToParameterName(),
                            ParameterName = string.Empty,
                            ArgumentName = string.Empty,
                            Value = pair.Value,
                            Explode = parameter.Explode,
                        }).WithCSharpParameterNames());
                    }
                    return;
                default:
                    return;
            }
        }

        if (parameter.Type.IsDate)
        {
            serialized.Add(parameter with
            {
                Value = $"{parameter.ArgumentName}{(parameter.Type.CSharpTypeNullability ? "?" : "")}.ToString(\"yyyy-MM-dd\")",
            });
            return;
        }

        if (parameter.Type.IsDateTime)
        {
            serialized.Add(parameter with
            {
                Value = $"{parameter.ArgumentName}{(parameter.Type.CSharpTypeNullability ? "?" : "")}.ToString(\"yyyy-MM-ddTHH:mm:ssZ\")",
            });
            return;
        }

        if (parameter.Type.CSharpTypeWithoutNullability == "bool")
        {
            serialized.Add(parameter with
            {
                Value = $"{parameter.ArgumentName}{(parameter.Type.CSharpTypeNullability ? "?" : "")}.ToString().ToLowerInvariant()",
            });
            return;
        }

        serialized.Add(parameter with
        {
            Value = $"{parameter.ArgumentName}{(parameter.Type.CSharpTypeNullability ? "?" : "")}.ToString(){(parameter.IsRequired ? "!" : "")}",
        });
    }

    private static string? GetFirstSerializedValue(MethodParameter parameter)
    {
        var serialized = new List<MethodParameter>(1);
        AppendSerializedQueryParameter(parameter, serialized);
        return serialized.Count == 0 ? null : serialized[0].Value;
    }
}
