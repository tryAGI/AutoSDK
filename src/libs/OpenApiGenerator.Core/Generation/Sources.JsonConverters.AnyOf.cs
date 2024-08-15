using System.Collections.Immutable;
using OpenApiGenerator.Core.Extensions;
using OpenApiGenerator.Core.Json;
using OpenApiGenerator.Core.Models;

namespace OpenApiGenerator.Core.Generation;

public static partial class Sources
{
    public static string GenerateAnyOfJsonConverter(
        AnyOfData anyOfData,
        CancellationToken cancellationToken = default)
    {
        var (subType, count, jsonSerializerType, isTrimming, @namespace, name, _, fixedTypes, _) = anyOfData;
        if (jsonSerializerType != JsonSerializerType.SystemTextJson)
        {
            return string.Empty;
        }
        
        var types = $"<{string.Join(", ", Enumerable.Range(1, count).Select(x => $"T{x}"))}>";
        var classNameWithTypes = string.IsNullOrWhiteSpace(name)
            ? $"{subType}JsonConverter{types}"
            : $"{name}JsonConverter";
        var typeNameWithTypes = string.IsNullOrWhiteSpace(name)
            ? $"global::System.{subType}{types}"
            : $"global::{@namespace}.{name}";
        var allTypes = fixedTypes.IsEmpty
            ? Enumerable
                .Range(1, count)
                .Select(i => PropertyData.Default with
                {
                    Name = $"Value{i}",
                    Type = TypeData.Default with
                    {
                        CSharpType = $"T{i}",
                    },
                })
                .ToImmutableArray()
            : fixedTypes;
        
        return $@"#nullable enable
{(fixedTypes.IsEmpty ? "" : @"#pragma warning disable CS0618 // Type or member is obsolete
")}
namespace OpenApiGenerator.JsonConverters
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
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));{(isTrimming ? @"
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException(""TypeInfoResolver is not set."");" : " ")}

            var
{allTypes.Select(x => $@"
            readerCopy = reader;
            {x.Type.CSharpTypeWithNullability} {x.ParameterName} = default;
            try
            {{
{(isTrimming ? $@" 
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
                throw new global::System.Text.Json.JsonException($""Invalid JSON format for {subType}<{string.Join(", ", allTypes.Select(x => $"{{typeof({x.Type.CSharpTypeWithoutNullability}).Name}}"))}>"");
            }}" : " ")}

{allTypes.Select((x, i) => $@" 
            {(i == 0 ? "" : "else ")}if ({x.ParameterName} != null)
            {{
{(isTrimming ? $@" 
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof({x.Type.CSharpTypeWithoutNullability}), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<{x.Type.CSharpTypeWithoutNullability}> ??
                               throw new global::System.InvalidOperationException($""Cannot get type info for {{typeof({x.Type.CSharpTypeWithoutNullability}).Name}}"");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
 " : $@" 
                _ = global::System.Text.Json.JsonSerializer.Deserialize<{x.Type.CSharpTypeWithoutNullability}>(ref reader, options);
 ")}
            }}
").Inject().TrimEnd(',')}

            return result;
        }}

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            {typeNameWithTypes} value,
            global::System.Text.Json.JsonSerializerOptions options)
        {{
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));{(isTrimming ? @"
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException(""TypeInfoResolver is not set."");" : " ")}
{(anyOfData.Settings.ValidateAnyOfs ? @$" 

            if (!value.Validate())
            {{
                throw new global::System.Text.Json.JsonException($""Invalid {subType}<{string.Join(", ", allTypes.Select(x => $"{{typeof({x.Type.CSharpTypeWithoutNullability}).Name}}"))}> object."");
            }}" : " ")}

{allTypes.Select((x, i) => $@" 
            {(i == 0 ? "" : "else ")}if (value.Is{x.Name})
            {{
{(isTrimming ? $@" 
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
        var (subType, count, jsonSerializerType, _, _, _, _, fixedTypes, _) = anyOfData;
        if (jsonSerializerType == JsonSerializerType.NewtonsoftJson ||
            !fixedTypes.IsEmpty)
        {
            return string.Empty;
        }
        
        var types = $"<{string.Join(",", Enumerable.Range(1, count).Select(_ => string.Empty))}>";

        return $@"#nullable enable

namespace OpenApiGenerator.JsonConverters
{{
    /// <inheritdoc />
    public sealed class {subType}JsonConverterFactory{count} : global::System.Text.Json.Serialization.JsonConverterFactory
    {{
        /// <inheritdoc />
        public override bool CanConvert(global::System.Type? typeToConvert)
        {{
            return typeToConvert is {{ IsGenericType: true }} && typeToConvert.GetGenericTypeDefinition() == typeof(global::System.{subType}{types});
        }}

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {{
            typeToConvert = typeToConvert ?? throw new global::System.ArgumentNullException(nameof(typeToConvert));
        
            return (global::System.Text.Json.Serialization.JsonConverter)global::System.Activator.CreateInstance(
                typeof({subType}JsonConverter{types}).MakeGenericType(typeToConvert.GenericTypeArguments))!;
        }}
    }}
}}
";
    }
}