using System.CommandLine;
using System.CommandLine.Binding;
using AutoSDK.Naming.Methods;

namespace AutoSDK.CLI.Commands;

public class GenerateSettingsBinder(
    Argument<string> input,
    Option<string> output,
    Option<string> targetFramework,
    Option<string> @namespace,
    Option<string> clientClassName,
    Option<MethodNamingConvention> methodNamingConvention,
    Option<bool> singleFile,
    Option<bool> excludeDeprecatedOperations,
    Option<string> clsCompliantEnumPrefix
    )
    : BinderBase<GenerateSettings>
{
    protected override GenerateSettings GetBoundValue(BindingContext bindingContext)
    {
        bindingContext = bindingContext ?? throw new ArgumentNullException(nameof(bindingContext));
        
        return new GenerateSettings
        {
            Input = bindingContext.ParseResult.GetValueForArgument(input),
            Output = bindingContext.ParseResult.GetValueForOption(output)!,
            TargetFramework = bindingContext.ParseResult.GetValueForOption(targetFramework)!,
            Namespace = bindingContext.ParseResult.GetValueForOption(@namespace)!,
            ClientClassName = bindingContext.ParseResult.GetValueForOption(clientClassName)!,
            MethodNamingConvention = bindingContext.ParseResult.GetValueForOption(methodNamingConvention),
            SingleFile = bindingContext.ParseResult.GetValueForOption(singleFile),
            ExcludeDeprecatedOperations = bindingContext.ParseResult.GetValueForOption(excludeDeprecatedOperations),
            ClsCompliantEnumPrefix = bindingContext.ParseResult.GetValueForOption(clsCompliantEnumPrefix)!,
        };
    }
}