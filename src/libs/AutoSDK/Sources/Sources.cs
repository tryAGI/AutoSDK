﻿using AutoSDK.Extensions;
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
    
    public static FileWithName Enum(
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
        if (data.Settings.JsonSerializerType == JsonSerializerType.NewtonsoftJson)
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
        if (anyOf.Settings.JsonSerializerType == JsonSerializerType.NewtonsoftJson ||
            !anyOf.Properties.IsEmpty)
        {
            return FileWithName.Empty;
        }
        
        return new FileWithName(
            Name: $"JsonConverters.{anyOf.SubType}Factory{anyOf.Count}.g.cs",
            Text: GenerateAnyOfJsonConverterFactory(anyOf, cancellationToken: cancellationToken));
    }
    
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
            Name: "JsonSerializerContextTypes.g.cs",
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
            Name: "JsonSerializerContext.g.cs",
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
            Name: "JsonSerializerContextConverters.g.cs",
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
    
    public static FileWithName PathBuilder(
        Settings settings,
        CancellationToken cancellationToken = default)
    {
        return new FileWithName(
            Name: $"{settings.Namespace}.PathBuilder.g.cs",
            Text: GeneratePathBuilder(settings, cancellationToken: cancellationToken));
    }
}
