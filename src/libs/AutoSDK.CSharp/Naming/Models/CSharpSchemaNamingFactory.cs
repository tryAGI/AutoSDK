using AutoSDK.Models;
using AutoSDK.Naming.Properties;

namespace AutoSDK.Naming.Models;

public static class CSharpSchemaNamingFactory
{
    public static string CreateReferenceId(ReferenceNameContext context)
    {
        return CSharpNamespacedTypeNameResolver.GetComponentClassName(context.ReferenceId, context.Settings);
    }

    public static string CreateSchemaId(SchemaNameContext context)
    {
        return ModelNameGenerator.ComputeId(
            settings: context.Settings,
            parent: context.Parent,
            hint: context.Hint,
            operation: context.Operation,
            parameter: context.Parameter,
            propertyName: context.PropertyName,
            componentId: context.ComponentId,
            index: context.Index,
            title: context.Title,
            operationPath: context.OperationPath,
            operationType: context.OperationType);
    }
}
