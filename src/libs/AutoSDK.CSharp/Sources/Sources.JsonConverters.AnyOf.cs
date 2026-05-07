using AutoSDK.Extensions;
using AutoSDK.Models;
namespace AutoSDK.Generation;

public static partial class Sources
{
    public static string GenerateAnyOfJsonConverter(
        AnyOfData anyOfData,
        CancellationToken cancellationToken = default)
    {
        if (!anyOfData.Settings.UsesSystemTextJson())
        {
            return string.Empty;
        }

        var types = $"<{string.Join(", ", Enumerable.Range(1, anyOfData.Count).Select(x => $"T{x}"))}>";
        var classNameWithTypes = !anyOfData.IsNamed
            ? $"{anyOfData.SubType}JsonConverter{types}"
            : $"{anyOfData.Name}JsonConverter";
        var typeNameWithTypes = !anyOfData.IsNamed
            ? $"global::{anyOfData.Namespace}.{anyOfData.SubType}{types}"
            : $"global::{anyOfData.Namespace}.{anyOfData.Name}";
        var hasDiscriminator = anyOfData.DiscriminatorType != null && anyOfData.Properties.All(x => !string.IsNullOrWhiteSpace(x.DiscriminatorValue));
        var hasPropertyInfo = anyOfData.Properties.Any(x => !x.JsonPropertyNames.IsEmpty);
        var hasNestedPropertyInfo = anyOfData.Properties.Any(x => x.JsonPropertyNames.Any(propName => propName.Contains('.')));

        string read;
        if (hasDiscriminator)
        {
            read = $@" 

            var readerCopy = reader;
{(anyOfData.IsTrimming ? $@" 
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof({anyOfData.DiscriminatorType!.Value.CSharpTypeWithoutNullability}), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<{anyOfData.DiscriminatorType.Value.CSharpTypeWithoutNullability}> ??
                            throw new global::System.InvalidOperationException($""Cannot get type info for {{nameof({anyOfData.DiscriminatorType.Value.CSharpTypeWithoutNullability})}}"");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);
 " : $@" 
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<{anyOfData.DiscriminatorType!.Value.CSharpTypeWithoutNullability}>(ref readerCopy, options);
 ")}

{anyOfData.Properties.Select((x, i) => $@" 
            {x.Type.CSharpTypeWithNullability} {x.ParameterName} = default;
            if (discriminator?.{anyOfData.DiscriminatorPropertyName} == {anyOfData.DiscriminatorType!.Value.CSharpTypeWithoutNullability}{anyOfData.DiscriminatorPropertyName}.{x.DiscriminatorValue})
            {{
{(anyOfData.IsTrimming ? $@" 
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof({x.Type.CSharpTypeWithoutNullability}), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<{x.Type.CSharpTypeWithoutNullability}> ??
                               throw new global::System.InvalidOperationException($""Cannot get type info for {{nameof({x.Type.CSharpTypeWithoutNullability})}}"");
                {x.ParameterName} = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
 " : $@" 
                {x.ParameterName} = global::System.Text.Json.JsonSerializer.Deserialize<{x.Type.CSharpTypeWithoutNullability}>(ref reader, options);
 ")}
            }}
").Inject().TrimEnd(',')}

            var __value = new {typeNameWithTypes}(
                discriminator?.{anyOfData.DiscriminatorPropertyName},
{anyOfData.Properties.Select(x => $@"
                {x.ParameterName},
").Inject().TrimEnd(',')}
                );
{(anyOfData.Settings.ValidateAnyOfs ? @$"
            if (!__value.Validate())
            {{
                throw new global::System.Text.Json.JsonException($""Invalid JSON format for {anyOfData.SubType}<{string.Join(", ", anyOfData.Properties.Select(x => $"{{nameof({x.Type.CSharpTypeWithoutNullability})}}"))}>"");
            }}" : TrimmedLine)}";
        }
        else if (hasPropertyInfo)
        {
            read = $@" 
            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {{
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {{
                    __jsonProps.Add(__jsonProp.Name);
{(hasNestedPropertyInfo ? @"                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + ""."" + __nestedJsonProp.Name);
                        }
                    }
" : string.Empty)}
                }}
            }}

{anyOfData.Properties.Select((x, i) => $@"            var __score{i} = 0;
{x.JsonPropertyNames.Select(propName => $@"            if (__jsonProps.Contains(""{propName}"")) __score{i}++;
").Inject()}
").Inject()}
            var __bestScore = 0;
            var __bestIndex = -1;
{anyOfData.Properties.Select((x, i) => $@"            if (__score{i} > __bestScore) {{ __bestScore = __score{i}; __bestIndex = {i}; }}
").Inject()}

{anyOfData.Properties.Select(x => $@"            {x.Type.CSharpTypeWithNullability} {x.ParameterName} = default;
").Inject()}
            if (__bestIndex >= 0)
            {{
{anyOfData.Properties.Select((x, i) => $@" 
                {(i == 0 ? "" : "else ")}if (__bestIndex == {i})
                {{
                    try
                    {{
{(anyOfData.IsTrimming ? $@" 
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof({x.Type.CSharpTypeWithoutNullability}), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<{x.Type.CSharpTypeWithoutNullability}> ??
                                       throw new global::System.InvalidOperationException($""Cannot get type info for {{typeof({x.Type.CSharpTypeWithoutNullability}).Name}}"");
                        {x.ParameterName} = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
 " : $@" 
                        {x.ParameterName} = global::System.Text.Json.JsonSerializer.Deserialize<{x.Type.CSharpTypeWithoutNullability}>(__rawJson, options);
 ")}
                    }}
                    catch (global::System.Text.Json.JsonException)
                    {{
                    }}
                    catch (global::System.InvalidOperationException)
                    {{
                    }}
                }}
").Inject().TrimEnd(',')}
            }}

            if ({string.Join(" && ", anyOfData.Properties.Select(x => $"{x.ParameterName} == null"))})
            {{
{anyOfData.Properties.Select(x => $@"
                try
                {{
{(anyOfData.IsTrimming ? $@" 
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof({x.Type.CSharpTypeWithoutNullability}), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<{x.Type.CSharpTypeWithoutNullability}> ??
                                   throw new global::System.InvalidOperationException($""Cannot get type info for {{typeof({x.Type.CSharpTypeWithoutNullability}).Name}}"");
                    {x.ParameterName} = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
 " : $@" 
                    {x.ParameterName} = global::System.Text.Json.JsonSerializer.Deserialize<{x.Type.CSharpTypeWithoutNullability}>(__rawJson, options);
 ")}
                }}
                catch (global::System.Text.Json.JsonException)
                {{
                }}
                catch (global::System.InvalidOperationException)
                {{
                }}
").Inject()}
            }}

            var __value = new {typeNameWithTypes}(
{anyOfData.Properties.Select(x => $@"
                {x.ParameterName},
").Inject().TrimEnd(',')}
                );
{(anyOfData.Settings.ValidateAnyOfs ? @$"
            if (!__value.Validate())
            {{
                throw new global::System.Text.Json.JsonException($""Invalid JSON format for {anyOfData.SubType}<{string.Join(", ", anyOfData.Properties.Select(x => $"{{typeof({x.Type.CSharpTypeWithoutNullability}).Name}}"))}>"");
            }}" : TrimmedLine)}";
        }
        else
        {
            read = $@"
            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {{
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {{
                    __jsonProps.Add(__jsonProp.Name);
                }}
            }}

{anyOfData.Properties.Select((x, i) => $@"            var __score{i} = 0;
{(anyOfData.IsTrimming ? $@"            {{
                var __ti = typeInfoResolver.GetTypeInfo(typeof({x.Type.CSharpTypeWithoutNullability}), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {{
                    foreach (var __prop in __ti.Properties)
                    {{
                        if (__jsonProps.Contains(__prop.Name)) __score{i}++;
                    }}
                }}
            }}
" : "")}").Inject()}
            var __bestScore = 0;
            var __bestIndex = -1;
{anyOfData.Properties.Select((x, i) => $@"            if (__score{i} > __bestScore) {{ __bestScore = __score{i}; __bestIndex = {i}; }}
").Inject()}

{anyOfData.Properties.Select(x => $@"            {x.Type.CSharpTypeWithNullability} {x.ParameterName} = default;
").Inject()}
            if (__bestIndex >= 0)
            {{
{anyOfData.Properties.Select((x, i) => $@"
                {(i == 0 ? "" : "else ")}if (__bestIndex == {i})
                {{
                    try
                    {{
{(anyOfData.IsTrimming ? $@"
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof({x.Type.CSharpTypeWithoutNullability}), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<{x.Type.CSharpTypeWithoutNullability}> ??
                                       throw new global::System.InvalidOperationException($""Cannot get type info for {{typeof({x.Type.CSharpTypeWithoutNullability}).Name}}"");
                        {x.ParameterName} = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
 " : $@"
                        {x.ParameterName} = global::System.Text.Json.JsonSerializer.Deserialize<{x.Type.CSharpTypeWithoutNullability}>(__rawJson, options);
 ")}
                    }}
                    catch (global::System.Text.Json.JsonException)
                    {{
                    }}
                    catch (global::System.InvalidOperationException)
                    {{
                    }}
                }}
").Inject().TrimEnd(',')}
            }}

            if ({string.Join(" && ", anyOfData.Properties.Select(x => $"{x.ParameterName} == null"))})
            {{
{anyOfData.Properties.Select(x => $@"
                try
                {{
{(anyOfData.IsTrimming ? $@"
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof({x.Type.CSharpTypeWithoutNullability}), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<{x.Type.CSharpTypeWithoutNullability}> ??
                                   throw new global::System.InvalidOperationException($""Cannot get type info for {{typeof({x.Type.CSharpTypeWithoutNullability}).Name}}"");
                    {x.ParameterName} = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
 " : $@"
                    {x.ParameterName} = global::System.Text.Json.JsonSerializer.Deserialize<{x.Type.CSharpTypeWithoutNullability}>(__rawJson, options);
 ")}
                }}
                catch (global::System.Text.Json.JsonException)
                {{
                }}
                catch (global::System.InvalidOperationException)
                {{
                }}
").Inject()}
            }}

            var __value = new {typeNameWithTypes}(
{anyOfData.Properties.Select(x => $@"
                {x.ParameterName},
").Inject().TrimEnd(',')}
                );
{(anyOfData.Settings.ValidateAnyOfs ? @$"
            if (!__value.Validate())
            {{
                throw new global::System.Text.Json.JsonException($""Invalid JSON format for {anyOfData.SubType}<{string.Join(", ", anyOfData.Properties.Select(x => $"{{typeof({x.Type.CSharpTypeWithoutNullability}).Name}}"))}>"");
            }}" : TrimmedLine)}";
        }

        return $@"#nullable enable
{(anyOfData.IsNamed ? @"#pragma warning disable CS0618 // Type or member is obsolete
" : "")}
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException(""TypeInfoResolver is not set."");" : TrimmedLine)}

{read}

            return __value;
        }}

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            {typeNameWithTypes} value,
            global::System.Text.Json.JsonSerializerOptions options)
        {{
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));{(anyOfData.IsTrimming ? @"
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException(""TypeInfoResolver is not set."");" : TrimmedLine)}
{(anyOfData.Settings.ValidateAnyOfs ? @$"

            if (!value.Validate())
            {{
                throw new global::System.Text.Json.JsonException($""Invalid {anyOfData.SubType}<{string.Join(", ", anyOfData.Properties.Select(x => $"{{typeof({x.Type.CSharpTypeWithoutNullability}).Name}}"))}> object."");
            }}" : TrimmedLine)}

{anyOfData.Properties.Select((x, i) => $@" 
            {(i == 0 ? "" : "else ")}if (value.Is{x.Name})
            {{
{(anyOfData.IsTrimming ? $@" 
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof({x.Type.CSharpTypeWithoutNullability}), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<{x.Type.CSharpTypeWithNullabilityForNonValueTypes}> ??
                               throw new global::System.InvalidOperationException($""Cannot get type info for {{typeof({x.Type.CSharpTypeWithoutNullability}).Name}}"");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.{x.Name}!{(x.Type.IsValueType ? ".Value" : string.Empty)}, typeInfo);
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
        if (anyOfData.Settings.UsesNewtonsoftJson() ||
            anyOfData.IsNamed)
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
