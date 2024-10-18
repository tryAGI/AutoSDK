using System.Collections.Immutable;
using AutoSDK.Extensions;
using AutoSDK.Models;
using AutoSDK.Serialization.Json;

namespace AutoSDK.Generation;

public static partial class Sources
{
    public static string GenerateAnyOfJsonConverter(
        AnyOfData anyOfData,
        CancellationToken cancellationToken = default)
    {
        if (anyOfData.Settings.JsonSerializerType != JsonSerializerType.SystemTextJson)
        {
            return string.Empty;
        }
        
        var types = $"<{string.Join(", ", Enumerable.Range(1, anyOfData.Count).Select(x => $"T{x}"))}>";
        var classNameWithTypes = string.IsNullOrWhiteSpace(anyOfData.Name)
            ? $"{anyOfData.SubType}JsonConverter{types}"
            : $"{anyOfData.Name}JsonConverter";
        var typeNameWithTypes = string.IsNullOrWhiteSpace(anyOfData.Name)
            ? $"global::{anyOfData.Namespace}.{anyOfData.SubType}{types}"
            : $"global::{anyOfData.Namespace}.{anyOfData.Name}";
        var allTypes = anyOfData.Properties.IsEmpty
            ? Enumerable
                .Range(1, anyOfData.Count)
                .Select(i => PropertyData.Default with
                {
                    Name = $"Value{i}",
                    Type = TypeData.Default with
                    {
                        CSharpTypeRaw = $"T{i}",
                    },
                })
                .ToImmutableArray().AsEquatableArray()
            : anyOfData.Properties;
        var read = anyOfData.DiscriminatorType != null ? $@" 

            var readerCopy = reader;
{(anyOfData.IsTrimming ? $@" 
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof({anyOfData.DiscriminatorType.Value.CSharpTypeWithoutNullability}), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<{anyOfData.DiscriminatorType.Value.CSharpTypeWithoutNullability}> ??
                            throw new global::System.InvalidOperationException($""Cannot get type info for {{nameof({anyOfData.DiscriminatorType.Value.CSharpTypeWithoutNullability})}}"");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);
 " : $@" 
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<{anyOfData.DiscriminatorType.Value.CSharpTypeWithoutNullability}>(ref readerCopy, options);
 ")}

{allTypes.Select((x, i) => $@" 
            {x.Type.CSharpTypeWithNullability} {x.ParameterName} = default;
            if (discriminator?.{anyOfData.DiscriminatorPropertyName} == {anyOfData.DiscriminatorType.Value.CSharpTypeWithoutNullability}{anyOfData.DiscriminatorPropertyName}.{x.DiscriminatorValue})
            {{
{(anyOfData.IsTrimming ? $@" 
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof({x.Type.CSharpTypeWithoutNullability}), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<{x.Type.CSharpTypeWithoutNullability}> ??
                               throw new global::System.InvalidOperationException($""Cannot get type info for {{nameof({x.Type.CSharpTypeWithoutNullability})}}"");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
 " : $@" 
                _ = global::System.Text.Json.JsonSerializer.Deserialize<{x.Type.CSharpTypeWithoutNullability}>(ref reader, options);
 ")}
            }}
").Inject().TrimEnd(',')}

            var result = new {typeNameWithTypes}(
                discriminator?.{anyOfData.DiscriminatorPropertyName},
{allTypes.Select(x => $@" 
                {x.ParameterName},
").Inject().TrimEnd(',')}
                );
{(anyOfData.Settings.ValidateAnyOfs ? @$" 
            if (!result.Validate())
            {{
                throw new global::System.Text.Json.JsonException($""Invalid JSON format for {anyOfData.SubType}<{string.Join(", ", allTypes.Select(x => $"{{nameof({x.Type.CSharpTypeWithoutNullability})}}"))}>"");
            }}" : " ")}" : $@" 
            var
{allTypes.Select(x => $@"
            readerCopy = reader;
            {x.Type.CSharpTypeWithNullability} {x.ParameterName} = default;
            try
            {{
{(anyOfData.IsTrimming ? $@" 
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof({x.Type.CSharpTypeWithoutNullability}), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<{x.Type.CSharpTypeWithoutNullability}> ??
                               throw new global::System.InvalidOperationException($""Cannot get type info for {{typeof({x.Type.CSharpTypeWithoutNullability}).Name}}"");
                {x.ParameterName} = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
 " : $@" 
                {x.ParameterName} = global::System.Text.Json.JsonSerializer.Deserialize<{x.Type.CSharpTypeWithoutNullability}>(ref readerCopy, options);
 ")}
            }}
            catch (global::System.Text.Json.JsonException)
            {{
            }}
").Inject()}

            var result = new {typeNameWithTypes}(
{allTypes.Select(x => $@" 
                {x.ParameterName},
").Inject().TrimEnd(',')}
                );
{(anyOfData.Settings.ValidateAnyOfs ? @$" 
            if (!result.Validate())
            {{
                throw new global::System.Text.Json.JsonException($""Invalid JSON format for {anyOfData.SubType}<{string.Join(", ", allTypes.Select(x => $"{{typeof({x.Type.CSharpTypeWithoutNullability}).Name}}"))}>"");
            }}" : " ")}

{allTypes.Select((x, i) => $@" 
            {(i == 0 ? "" : "else ")}if ({x.ParameterName} != null)
            {{
{(anyOfData.IsTrimming ? $@" 
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof({x.Type.CSharpTypeWithoutNullability}), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<{x.Type.CSharpTypeWithoutNullability}> ??
                               throw new global::System.InvalidOperationException($""Cannot get type info for {{typeof({x.Type.CSharpTypeWithoutNullability}).Name}}"");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
 " : $@" 
                _ = global::System.Text.Json.JsonSerializer.Deserialize<{x.Type.CSharpTypeWithoutNullability}>(ref reader, options);
 ")}
            }}
").Inject().TrimEnd(',')}";
        
        return $@"#nullable enable
{(anyOfData.Properties.IsEmpty ? "" : @"#pragma warning disable CS0618 // Type or member is obsolete
")}
namespace {anyOfData.Namespace}.JsonConverters
{{
    /// <inheritdoc />
    public class {classNameWithTypes} : global::System.Text.Json.Serialization.JsonConverter<{typeNameWithTypes}>
    {{
        /// <inheritdoc />
        public override {typeNameWithTypes} Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {{
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));{(anyOfData.IsTrimming ? @"
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException(""TypeInfoResolver is not set."");" : " ")}

{read}

            return result;
        }}

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            {typeNameWithTypes} value,
            global::System.Text.Json.JsonSerializerOptions options)
        {{
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));{(anyOfData.IsTrimming ? @"
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException(""TypeInfoResolver is not set."");" : " ")}
{(anyOfData.Settings.ValidateAnyOfs ? @$" 

            if (!value.Validate())
            {{
                throw new global::System.Text.Json.JsonException($""Invalid {anyOfData.SubType}<{string.Join(", ", allTypes.Select(x => $"{{typeof({x.Type.CSharpTypeWithoutNullability}).Name}}"))}> object."");
            }}" : " ")}

{allTypes.Select((x, i) => $@" 
            {(i == 0 ? "" : "else ")}if (value.Is{x.Name})
            {{
{(anyOfData.IsTrimming ? $@" 
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof({x.Type.CSharpTypeWithoutNullability}), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<{x.Type.CSharpTypeWithNullability}> ??
                               throw new global::System.InvalidOperationException($""Cannot get type info for {{typeof({x.Type.CSharpTypeWithoutNullability}).Name}}"");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.{x.Name}, typeInfo);
 " : $@" 
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.{x.Name}, typeof({x.Type.CSharpTypeWithoutNullability}), options);
 ")}
            }}
").Inject().TrimEnd(',')}
        }}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }

    public static string GenerateAnyOfJsonConverterFactory(
        AnyOfData anyOfData,
        CancellationToken cancellationToken = default)
    {
        if (anyOfData.Settings.JsonSerializerType == JsonSerializerType.NewtonsoftJson ||
            !anyOfData.Properties.IsEmpty)
        {
            return string.Empty;
        }
        
        var types = $"<{string.Join(",", Enumerable.Range(1, anyOfData.Count).Select(_ => string.Empty))}>";

        return $@"#nullable enable

namespace {anyOfData.Namespace}.JsonConverters
{{
    /// <inheritdoc />
    public sealed class {anyOfData.SubType}JsonConverterFactory{anyOfData.Count} : global::System.Text.Json.Serialization.JsonConverterFactory
    {{
        /// <inheritdoc />
        public override bool CanConvert(global::System.Type? typeToConvert)
        {{
            return typeToConvert is {{ IsGenericType: true }} && typeToConvert.GetGenericTypeDefinition() == typeof(global::{anyOfData.Settings.Namespace}.{anyOfData.SubType}{types});
        }}

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {{
            typeToConvert = typeToConvert ?? throw new global::System.ArgumentNullException(nameof(typeToConvert));
        
            return (global::System.Text.Json.Serialization.JsonConverter)global::System.Activator.CreateInstance(
                typeof({anyOfData.SubType}JsonConverter{types}).MakeGenericType(typeToConvert.GenericTypeArguments))!;
        }}
    }}
}}
";
    }
}