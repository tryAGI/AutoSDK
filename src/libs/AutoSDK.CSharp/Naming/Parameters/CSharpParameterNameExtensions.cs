using AutoSDK.Extensions;
using AutoSDK.Helpers;
using AutoSDK.Models;
namespace AutoSDK.Naming.Parameters;

public static class CSharpParameterNameExtensions
{
    public static PropertyData WithCSharpParameterName(this PropertyData property)
    {
        return property with
        {
            ParameterName = GenerateParameterName(property.Name),
        };
    }

    public static MethodParameter WithCSharpParameterNames(this MethodParameter parameter)
    {
        var parameterName = GenerateParameterName(parameter.Name);

        return parameter with
        {
            ParameterName = parameterName,
            ArgumentName = GenerateArgumentName(parameterName, parameter.Type, parameter.Settings),
        };
    }

    private static string GenerateParameterName(string name)
    {
        return name
            .Replace(".", string.Empty)
            .ToParameterName()
            .EscapeCSharpKeyword();
    }

    private static string GenerateArgumentName(string parameterName, TypeData type, EmitterSettings settings)
    {
        if (type.EnumValues.Length != 0 &&
            !type.IsAnyOfLike &&
            settings.UsesNewtonsoftJson())
        {
            return parameterName + "Value";
        }

        return parameterName;
    }
}
