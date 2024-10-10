using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public partial class DataTests : VerifyBase
{
    private Settings DefaultSettings => Settings.Default with
    {
        TargetFramework = "netstandard2.0",
        Namespace = "G",
        ClassName = "Api",
        ClsCompliantEnumPrefix = "x",
    };

    private Task VerifyAsync(
        Data data,
        string resourceName)
    {
        // var classesTask =
        //     Verify(data.Classes
        //             .Select(x => x with { Parents = [] })
        //             .ToArray())
        //         .UseDirectory($"Snapshots/{callerName}/Classes")
        //         .UseFileName("_");
        // var enumsTask =
        //     Verify(data.Enums
        //             .Select(x => x with { Parents = [] })
        //             .ToArray())
        //         .UseDirectory($"Snapshots/{callerName}/Enums")
        //         .UseFileName("_");
        // var methodsTask =
        //     Verify(data.Methods)
        //         .UseDirectory($"Snapshots/{callerName}/Methods")
        //         .UseFileName("_");
        // var anyOfsTask =
        //     Verify(data.AnyOfs)
        //         .UseDirectory($"Snapshots/{callerName}/AnyOfs")
        //         .UseFileName("_");
        // var typesTask =
        //     Verify(data.Types)
        //         .UseDirectory($"Snapshots/{callerName}/Types")
        //         .UseFileName("_");
        var schemasTask =
            Verify(data.Schemas.Select(x => $"{GetMargin(x)}{x.Id}({x.Type})"))
                .UseDirectory($"Snapshots/{resourceName}/Schemas")
                .UseFileName("_");
        var resolvedSchemasTask =
            Verify(ToResolvedStrings(data.FilteredSchemas.Where(x => x.Parent == null)))
                .UseDirectory($"Snapshots/{resourceName}/ResolvedSchemas")
                .UseFileName("_");
        
        // classesTask = classesTask.AutoVerify();
        // enumsTask = enumsTask.AutoVerify();
        // methodsTask = methodsTask.AutoVerify();
        // anyOfsTask = anyOfsTask.AutoVerify();
        // typesTask = typesTask.AutoVerify();
        schemasTask = schemasTask.AutoVerify();
        resolvedSchemasTask = resolvedSchemasTask.AutoVerify();

        Console.WriteLine($"Number of schemas: {data.Schemas.Count}");
        Console.WriteLine($"Total: {data.Times.Total}");
        Console.WriteLine($"TraversalTree: {data.Times.TraversalTree}");
        Console.WriteLine($"Naming: {data.Times.Naming}");
        Console.WriteLine($"ResolveReferences: {data.Times.ResolveReferences}");
        Console.WriteLine($"Filtering: {data.Times.Filtering}");
        Console.WriteLine($"ComputeData: {data.Times.ComputeData}");
        Console.WriteLine($"ComputeDataClasses: {data.Times.ComputeDataClasses}");
        
        return Task.WhenAll(schemasTask, resolvedSchemasTask); // classesTask, enumsTask, methodsTask, anyOfsTask, typesTask, 
    }

    private static string GetMargin(SchemaContext context)
    {
        var margin = string.Empty;

        while (context.Parent != null)
        {
            margin += "  ";
            context = context.Parent;
        }
        
        return margin;
    }

    private static List<string> ToResolvedStrings(IEnumerable<SchemaContext> contexts, string margin = "")
    {
        var result = new List<string>();
        foreach (var context in contexts)
        {
            result.Add($"{margin}{context.Id}({context.Type})[{string.Join(", ", context.Tags)}]");
            
            result.AddRange(ToResolvedStrings(context.Children, margin + "  "));
        }
        
        return result;
    }
}