using Microsoft.CodeAnalysis;

namespace H.Generators;

[Generator]
public class ModelGenerator : IIncrementalGenerator
{
    #region Constants

    //private const string Id = "MG";

    #endregion

    #region Methods

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        // var settings = context.DetectSettings();
        //
        // context.AdditionalTextsProvider
        //     .Where(static text => text.Path.EndsWith(".yaml", StringComparison.InvariantCultureIgnoreCase))
        //     .Combine(settings)
        //     .SelectAndReportExceptions(GetSourceCode, context, Id)
        //     .AddSource(context);
    }

    // private static EquatableArray<FileWithName> GetSourceCode(
    //     (AdditionalText text, Settings settings) tuple,
    //     CancellationToken cancellationToken = default)
    // {
    //     var (text, settings) = tuple;
    //     
    //     return Sources.GenerateUsingNSwag(text, settings, cancellationToken);
    // }


    #endregion
}
