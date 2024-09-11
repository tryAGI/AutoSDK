using AutoSDK.Naming.Methods;

namespace AutoSDK.CLI.Commands;

public class GenerateSettings
{
    public required string Input { get; set; }
    public required string Output { get; set; }
    public required string TargetFramework { get; set; }
    public required string Namespace { get; set; }
    public required string ClientClassName { get; set; }
    public required MethodNamingConvention MethodNamingConvention { get; set; }
    public required bool SingleFile { get; set; }
    public required bool ExcludeDeprecatedOperations { get; set; }
    public required string ClsCompliantEnumPrefix { get; set; }
}