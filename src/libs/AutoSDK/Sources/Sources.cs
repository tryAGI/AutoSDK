using AutoSDK.Extensions;
using AutoSDK.Models;
using AutoSDK.Serialization.Json;

namespace AutoSDK.Generation;

public static partial class Sources
{
    public static FileWithName Class(
        ModelData modelData,
        CancellationToken cancellationToken = default)
    {
        return new FileWithName(
            Name: $"{modelData.FileNameWithoutExtension}.g.cs",
            Text: GenerateModel(modelData, cancellationToken: cancellationToken));
    }
    
    public static FileWithName ClassJsonExtensions(
        ModelData modelData,
        CancellationToken cancellationToken = default)
    {
        return new FileWithName(
            Name: $"{modelData.FileNameWithoutExtension}.Json.g.cs",
            Text: GenerateClassFromToJsonMethods(modelData, cancellationToken: cancellationToken));
    }
    
    public static FileWithName ClassValidation(
        ModelData modelData,
        CancellationToken cancellationToken = default)
    {
        if (!modelData.Settings.GenerateModelValidationMethods)
        {
            return FileWithName.Empty;
        }
        
        return new FileWithName(
            Name: $"{modelData.FileNameWithoutExtension}.IValidatableObject.g.cs",
            Text: GenerateClassValidationMethods(modelData, cancellationToken: cancellationToken));
    }
    
    public static FileWithName Enum(
        ModelData modelData,
        CancellationToken cancellationToken = default)
    {
        return new FileWithName(
            Name: $"{modelData.FileNameWithoutExtension}.g.cs",
            Text: GenerateModel(modelData, cancellationToken: cancellationToken));
    }
    
    public static FileWithName Command(
        EndPoint endPoint,
        CancellationToken cancellationToken = default)
    {
        return new FileWithName(
            Name: $"{endPoint.GlobalSettings.Namespace}.Commands.{endPoint.NotAsyncMethodName}Command.g.cs",
            Text: GenerateCommand(endPoint, cancellationToken: cancellationToken));
    }
    
    public static FileWithName TagCommand(
        Tag tag,
        EquatableArray<EndPoint> methods,
        CancellationToken cancellationToken = default)
    {
        if (methods.IsEmpty)
        {
            return FileWithName.Empty;
        }
        
        return new FileWithName(
            Name: $"{methods[0].GlobalSettings.Namespace}.Commands.{tag.SingularizedName}Command.g.cs",
            Text: GenerateTagCommand(tag, methods, cancellationToken: cancellationToken));
    }
    
    public static FileWithName MainCommand(
        EquatableArray<Tag> values,
        CancellationToken cancellationToken = default)
    {
        if (values.IsEmpty)
        {
            return FileWithName.Empty;
        }
        
        return new FileWithName(
            Name: $"{values[0].GlobalSettings.Namespace}.Commands.MainCommand.g.cs",
            Text: GenerateMainCommand(values, cancellationToken: cancellationToken));
    }
    
    public static FileWithName AddCommands(
        EquatableArray<EndPoint> methods,
        EquatableArray<Tag> tags,
        CancellationToken cancellationToken = default)
    {
        if (methods.IsEmpty || tags.IsEmpty)
        {
            return FileWithName.Empty;
        }
        
        return new FileWithName(
            Name: $"{methods[0].Settings.Namespace}.ServiceCollectionExtensions.AddCommands.g.cs",
            Text: GenerateAddCommands(methods, tags, cancellationToken: cancellationToken));
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
    
    public static FileWithName AnyOfJsonExtensions(
        AnyOfData data,
        CancellationToken cancellationToken = default)
    {
        var name = string.IsNullOrWhiteSpace(data.Name)
            ? $"{data.SubType}.{data.Count}"
            : $"{data.Namespace}.Models.{data.Name}";
        
        return new FileWithName(
            Name: $"{name}.Json.g.cs",
            Text: GenerateAnyOfFromToJsonMethods(data, cancellationToken: cancellationToken));
    }
    
    public static FileWithName AnyOfValidation(
        AnyOfData data,
        CancellationToken cancellationToken = default)
    {
        if (!data.Settings.GenerateModelValidationMethods)
        {
            return FileWithName.Empty;
        }

        var name = string.IsNullOrWhiteSpace(data.Name)
            ? $"{data.SubType}.{data.Count}"
            : $"{data.Namespace}.Models.{data.Name}";
        
        return new FileWithName(
            Name: $"{name}.IValidatableObject.g.cs",
            Text: GenerateAnyOfValidationMethods(data, cancellationToken: cancellationToken));
    }
    
    public static FileWithName AnyOfJsonConverter(
        AnyOfData data,
        CancellationToken cancellationToken = default)
    {
        if (data.Settings.JsonSerializerType == JsonSerializerType.NewtonsoftJson)
        {
            return FileWithName.Empty;
        }
        
        var name = string.IsNullOrWhiteSpace(data.Name)
            ? $"{data.SubType}{data.Count}"
            : data.Name;

        return new FileWithName(
            Name: $"{data.Namespace}.JsonConverters.{name}.g.cs",
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
            Name: $"{data.Namespace}.JsonConverters.{data.ClassName}.g.cs",
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
            Name: $"{data.Namespace}.JsonConverters.{data.ClassName}Nullable.g.cs",
            Text: GenerateEnumNullableJsonConverter(data, cancellationToken: cancellationToken));
    }

    // Not used in the current implementation because not compatible with NativeAOT
    // public static FileWithName AnyOfJsonConverterFactory(
    //     AnyOfData anyOf,
    //     CancellationToken cancellationToken = default)
    // {
    //     if (anyOf.Settings.JsonSerializerType == JsonSerializerType.NewtonsoftJson ||
    //         anyOf.IsNamed)
    //     {
    //         return FileWithName.Empty;
    //     }
    //     
    //     return new FileWithName(
    //         Name: $"JsonConverters.{anyOf.SubType}Factory{anyOf.Count}.g.cs",
    //         Text: GenerateAnyOfJsonConverterFactory(anyOf, cancellationToken: cancellationToken));
    // }
    
    public static FileWithName UnixTimestampJsonConverter(
        Settings settings,
        CancellationToken cancellationToken = default)
    {
        return new FileWithName(
            Name: "JsonConverters.UnixTimestamp.g.cs",
            Text: GenerateUnixTimestampJsonConverter(settings, cancellationToken: cancellationToken));
    }
    
    public static FileWithName JsonSerializerContextTypes(
        EquatableArray<TypeData> types,
        CancellationToken cancellationToken = default)
    {
        if (types.IsEmpty ||
            !types[0].Settings.GenerateJsonSerializerContextTypes ||
            types[0].Settings.JsonSerializerType == JsonSerializerType.NewtonsoftJson)
        {
            return FileWithName.Empty;
        }
        
        return new FileWithName(
            Name: $"{types[0].Settings.Namespace}.JsonSerializerContextTypes.g.cs",
            Text: GenerateJsonSerializerContextTypes(types, cancellationToken: cancellationToken));
    }
    
    public static FileWithName JsonSerializerContext(
        Client client,
        EquatableArray<TypeData> types,
        CancellationToken cancellationToken = default)
    {
        if (!client.Settings.FromCli ||
            !client.Settings.GenerateJsonSerializerContextTypes ||
            client.Settings.JsonSerializerType == JsonSerializerType.NewtonsoftJson)
        {
            return FileWithName.Empty;
        }
        
        return new FileWithName(
            Name: $"{client.FileNameWithoutExtension}.JsonSerializerContext.g.cs",
            Text: GenerateJsonSerializerContext(client, types, cancellationToken: cancellationToken));
    }
    
    public static FileWithName JsonSerializerContextConverters(
        Client client,
        CancellationToken cancellationToken = default)
    {
        if (!client.Settings.GenerateJsonSerializerContextTypes ||
            client.Settings.JsonSerializerType == JsonSerializerType.NewtonsoftJson)
        {
            return FileWithName.Empty;
        }
        
        return new FileWithName(
            Name: $"{client.Settings.Namespace}.JsonSerializerContextConverters.g.cs",
            Text: GenerateJsonSerializerContextConverters(client));
    }
    
    public static FileWithName Client(
        Client client,
        CancellationToken cancellationToken = default)
    {
        return new FileWithName(
            Name: $"{client.FileNameWithoutExtension}.g.cs",
            Text: GenerateClient(client));
    }
    
    public static FileWithName ClientInterface(
        Client client,
        CancellationToken cancellationToken = default)
    {
        return new FileWithName(
            Name: $"{client.InterfaceFileNameWithoutExtension}.g.cs",
            Text: GenerateClientInterface(client));
    }
    
    public static FileWithName Method(
        EndPoint endPoint,
        CancellationToken cancellationToken = default)
    {
        return new FileWithName(
            Name: $"{endPoint.FileNameWithoutExtension}.g.cs",
            Text: GenerateEndPoint(endPoint, cancellationToken: cancellationToken));
    }
    
    public static FileWithName MethodInterface(
        EndPoint endPoint,
        CancellationToken cancellationToken = default)
    {
        return new FileWithName(
            Name: $"{endPoint.InterfaceFileNameWithoutExtension}.g.cs",
            Text: GenerateEndPointInterface(endPoint, cancellationToken: cancellationToken));
    }
    
    public static FileWithName Authorization(
        Authorization authorization,
        CancellationToken cancellationToken = default)
    {
        return new FileWithName(
            Name: $"{authorization.Settings.Namespace}.{authorization.Settings.ClassName}.Authorizations.{authorization.FriendlyName}.g.cs",
            Text: GenerateAuthorization(authorization));
    }
    
    public static FileWithName AuthorizationInterface(
        Authorization authorization,
        CancellationToken cancellationToken = default)
    {
        return new FileWithName(
            Name: $"{authorization.Settings.Namespace}.I{authorization.Settings.ClassName}.Authorizations.{authorization.FriendlyName}.g.cs",
            Text: GenerateAuthorizationInterface(authorization));
    }
    
    public static FileWithName MainAuthorizationConstructor(
        EquatableArray<Authorization> authorizations,
        CancellationToken cancellationToken = default)
    {
        if (authorizations.IsEmpty)
        {
            return FileWithName.Empty;
        }
        
        var mainAuthorization = authorizations[0];
        
        return new FileWithName(
            Name: $"{mainAuthorization.Settings.Namespace}.{mainAuthorization.Settings.ClassName}.Constructors.{mainAuthorization.Scheme.ToPropertyName()}.g.cs",
            Text: GenerateMainAuthorizationConstructor(mainAuthorization));
    }
    
    public static FileWithName Polyfills(
        Settings settings,
        CancellationToken cancellationToken = default)
    {
        return new FileWithName(
            Name: $"{settings.Namespace}.Polyfills.g.cs",
            Text: GeneratePolyfills(settings));
    }
    
    public static FileWithName Exceptions(
        Settings settings,
        CancellationToken cancellationToken = default)
    {
        return new FileWithName(
            Name: $"{settings.Namespace}.Exceptions.g.cs",
            Text: GenerateExceptions(settings));
    }
    
    public static FileWithName PathBuilder(
        Settings settings,
        CancellationToken cancellationToken = default)
    {
        return new FileWithName(
            Name: $"{settings.Namespace}.PathBuilder.g.cs",
            Text: GeneratePathBuilder(settings, cancellationToken: cancellationToken));
    }
}
