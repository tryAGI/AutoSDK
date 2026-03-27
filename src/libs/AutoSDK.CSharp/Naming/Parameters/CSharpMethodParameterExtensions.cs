using AutoSDK.Helpers;
using AutoSDK.Models;

namespace AutoSDK.Naming.Parameters;

public static class CSharpMethodParameterExtensions
{
    public static MethodParameter WithCSharpComputedValues(this MethodParameter parameter)
    {
        var hasSchemaDefault =
            !string.IsNullOrWhiteSpace(parameter.DefaultValue) &&
            !parameter.Type.IsAnyOfLike;
        var producesDeprecationWarning =
            parameter.Type.IsAnyOfLike &&
            parameter.Type.SubTypes.Any(static x => x.Unbox<TypeData>().IsDeprecated);

        return parameter with
        {
            HasSchemaDefault = hasSchemaDefault,
            ParameterDefaultValue = hasSchemaDefault
                ? parameter.DefaultValue!
                : "default",
            ProducesDeprecationWarning = producesDeprecationWarning,
            DisableDeprecationWarningIfRequired = producesDeprecationWarning
                ? "#pragma warning disable CS0618 // Type or member is obsolete"
                : " ",
        };
    }
}
