using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using AnyOfTypes;

#nullable enable

// ReSharper disable once CheckNamespace
namespace OpenApiGenerator.JsonConverters;

public sealed class OneOfConverterFactorySystemTextJson : JsonConverterFactory
{
    public override bool CanConvert(Type? typeToConvert)
    {
        return typeToConvert is { IsGenericType: true } && typeToConvert.GetGenericTypeDefinition() == typeof(OneOf<,>);
    }

    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        typeToConvert = typeToConvert ?? throw new ArgumentNullException(nameof(typeToConvert));
        
        return (JsonConverter)Activator.CreateInstance(
            typeof(OneOfConverterSystemTextJson<,>).MakeGenericType(typeToConvert.GenericTypeArguments))!;
    }
}