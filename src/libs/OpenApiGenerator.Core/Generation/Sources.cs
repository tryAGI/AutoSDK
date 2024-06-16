using OpenApiGenerator.Core.Json;
using OpenApiGenerator.Core.Models;

namespace OpenApiGenerator.Core.Generation;

public static partial class Sources
{
    public static FileWithName Model(
        ModelData modelData,
        CancellationToken cancellationToken = default)
    {
        return new FileWithName(
            Name: $"{modelData.FileNameWithoutExtension}.g.cs",
            Text: GenerateModel(modelData, cancellationToken: cancellationToken));
    }
    
    public static FileWithName AnyOf(
        AnyOfData data,
        CancellationToken cancellationToken = default)
    {
        var name = string.IsNullOrWhiteSpace(data.Name)
            ? $"{data.SubType}.{data.Count}"
            : $"{data.Namespace}.Models.{data.Name}";
        
        return new FileWithName(
            Name: $"{name}.g.cs",
            Text: GenerateAnyOf(data, cancellationToken: cancellationToken));
    }
    
    public static FileWithName AnyOfJsonConverter(
        AnyOfData data,
        CancellationToken cancellationToken = default)
    {
        if (data.JsonSerializerType == JsonSerializerType.NewtonsoftJson)
        {
            return FileWithName.Empty;
        }
        
        var name = string.IsNullOrWhiteSpace(data.Name)
            ? $"{data.SubType}{data.Count}"
            : data.Name;

        return new FileWithName(
            Name: $"JsonConverters.{name}.g.cs",
            Text: GenerateAnyOfJsonConverter(data, cancellationToken: cancellationToken));
    }
    
    public static FileWithName EnumJsonConverter(
        ModelData data,
        CancellationToken cancellationToken = default)
    {
        if (data.Style != ModelStyle.Enumeration ||
            data.Settings.JsonSerializerType == JsonSerializerType.NewtonsoftJson)
        {
            return FileWithName.Empty;
        }
        
        return new FileWithName(
            Name: $"JsonConverters.{data.ClassName}.g.cs",
            Text: GenerateEnumJsonConverter(data, cancellationToken: cancellationToken));
    }
    
    public static FileWithName EnumNullableJsonConverter(
        ModelData data,
        CancellationToken cancellationToken = default)
    {
        if (data.Style != ModelStyle.Enumeration ||
            data.Settings.JsonSerializerType == JsonSerializerType.NewtonsoftJson)
        {
            return FileWithName.Empty;
        }
        
        return new FileWithName(
            Name: $"JsonConverters.{data.ClassName}Nullable.g.cs",
            Text: GenerateEnumNullableJsonConverter(data, cancellationToken: cancellationToken));
    }

    public static FileWithName AnyOfJsonConverterFactory(
        AnyOfData anyOf,
        CancellationToken cancellationToken = default)
    {
        if (anyOf.JsonSerializerType == JsonSerializerType.NewtonsoftJson ||
            !anyOf.Properties.IsEmpty)
        {
            return FileWithName.Empty;
        }
        
        return new FileWithName(
            Name: $"JsonConverters.{anyOf.SubType}Factory{anyOf.Count}.g.cs",
            Text: GenerateAnyOfJsonConverterFactory(anyOf, cancellationToken: cancellationToken));
    }
    
    public static FileWithName JsonSerializerContextTypes(
        EquatableArray<TypeData> types,
        CancellationToken cancellationToken = default)
    {
        if (types.IsEmpty ||
            !types[0].GenerateJsonSerializerContextTypes ||
            types[0].JsonSerializerType == JsonSerializerType.NewtonsoftJson)
        {
            return FileWithName.Empty;
        }
        
        return new FileWithName(
            Name: "JsonSerializerContextTypes.g.cs",
            Text: GenerateJsonSerializerContextTypes(types, cancellationToken: cancellationToken));
    }
    
    public static FileWithName JsonSerializerContext(
        EndPoint endPoint,
        EquatableArray<TypeData> types,
        CancellationToken cancellationToken = default)
    {
        if (!endPoint.Settings.FromCli ||
            !endPoint.Settings.GenerateJsonSerializerContextTypes ||
            endPoint.Settings.JsonSerializerType == JsonSerializerType.NewtonsoftJson)
        {
            return FileWithName.Empty;
        }
        
        return new FileWithName(
            Name: "JsonSerializerContext.g.cs",
            Text: GenerateJsonSerializerContext(endPoint, types, cancellationToken: cancellationToken));
    }
    
    public static FileWithName JsonSerializerContextConverters(
        EndPoint endPoint,
        CancellationToken cancellationToken = default)
    {
        if (!endPoint.Settings.GenerateJsonSerializerContextTypes ||
            endPoint.Settings.JsonSerializerType == JsonSerializerType.NewtonsoftJson)
        {
            return FileWithName.Empty;
        }
        
        return new FileWithName(
            Name: "JsonSerializerContextConverters.g.cs",
            Text: GenerateJsonSerializerContextConverters(endPoint));
    }
    
    public static FileWithName Method(
        EndPoint endPoint,
        CancellationToken cancellationToken = default)
    {
        return new FileWithName(
            Name: $"{endPoint.FileNameWithoutExtension}.g.cs",
            Text: GenerateEndPoint(endPoint, cancellationToken: cancellationToken));
    }
}
