using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Generation;

public static partial class Sources
{
    public static string GenerateAddCommands(
        EquatableArray<EndPoint> methods,
        EquatableArray<Tag> tags,
        CancellationToken cancellationToken = default)
    {
        if (methods.IsEmpty || tags.IsEmpty)
        {
            return string.Empty;
        }
        
        return $@"
#nullable enable

namespace {methods[0].Settings.Namespace}
{{
    public static class ServiceCollectionExtensions
    {{
        public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddCommands(
            this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services)
        {{
{methods.Select(x => $"{x.MethodName}Command").Distinct().Select((type, i) => @$"
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                {type}>(services);").Inject()}

{tags.Select(x => $"{x.SingularizedName}Command").Distinct().Select((type, i) => @$"
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                {type}>(services);").Inject()}

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<
                MainCommand>(services);

            return services;
        }}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}