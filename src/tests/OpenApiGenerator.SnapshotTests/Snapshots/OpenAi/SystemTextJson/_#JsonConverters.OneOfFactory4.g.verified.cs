//HintName: JsonConverters.OneOfFactory4.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    public sealed class OneOfJsonConverterFactory4 : global::System.Text.Json.Serialization.JsonConverterFactory
    {
        public override bool CanConvert(global::System.Type? typeToConvert)
        {
            return typeToConvert is { IsGenericType: true } && typeToConvert.GetGenericTypeDefinition() == typeof(global::System.OneOf<,,,>);
        }

        public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            typeToConvert = typeToConvert ?? throw new global::System.ArgumentNullException(nameof(typeToConvert));
        
            return (global::System.Text.Json.Serialization.JsonConverter)global::System.Activator.CreateInstance(
                typeof(OneOfJsonConverter<,,,>).MakeGenericType(typeToConvert.GenericTypeArguments))!;
        }
    }
}
