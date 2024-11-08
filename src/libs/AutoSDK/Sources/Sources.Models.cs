using AutoSDK.Extensions;
using AutoSDK.Models;
using AutoSDK.Serialization.Json;

namespace AutoSDK.Generation;

public static partial class Sources
{
    public static string GenerateModel(
        ModelData modelData,
        CancellationToken cancellationToken = default)
    {
        return $@"
{(modelData.Properties.Any(x => x.Type.CSharpType.Contains("AnyOf<") || x.Type.CSharpType.Contains("OneOf<") || x.Type.CSharpType.Contains("AllOf<")) ? @"#pragma warning disable CS0618 // Type or member is obsolete
" : " ")}
#nullable enable

namespace {modelData.Namespace}
{{
{GenerateModel(modelData, level: 0, cancellationToken: cancellationToken)}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
    
    private static string GenerateModel(
        ModelData modelData,
        int level,
        CancellationToken cancellationToken = default)
    {
        if (modelData.Settings.NamingConvention == NamingConvention.ConcatNames ||
            level == modelData.Parents.AsSpan().Length)
        {
            return modelData.Style switch
            {
                ModelStyle.Class => GenerateClassModel(modelData, cancellationToken),
                ModelStyle.Enumeration =>
                    GenerateEnumerationModel(modelData, cancellationToken) + "\n\n" +
                    GenerateEnumExtensions(modelData, cancellationToken),
                _ => throw new NotSupportedException($"Model style {modelData.Style} is not supported."),
            };
        }
        
        return $@" 
public sealed partial class {modelData.Parents[level].ClassName}
{{
{GenerateModel(modelData, level + 1, cancellationToken: cancellationToken)}
}}".RemoveBlankLinesWhereOnlyWhitespaces().AddIndent(level: 1);
    }
    
    private static bool IsSupported(SdkFeatureUsage usage, string targetFramework)
    {
        return usage switch
        {
            SdkFeatureUsage.Always => true,
            SdkFeatureUsage.InSupportedTargetFrameworks
                when targetFramework.StartsWith("net8", StringComparison.OrdinalIgnoreCase) => true,
            _ => false,
        };
    }

    private static string GetDefaultValue(PropertyData property, bool isRequiredKeywordSupported)
    {
        if (property.IsRequired && !isRequiredKeywordSupported)
        {
            return " = default!;";
        }
        
        return property.Type.CSharpTypeNullability || string.IsNullOrWhiteSpace(property.DefaultValue)
            ? string.Empty
            : $" = {property.DefaultValue};";
    }
    
    public static string GenerateClassModel(
        ModelData modelData,
        CancellationToken cancellationToken = default)
    {
        var jsonSerializer = modelData.Settings.JsonSerializerType.GetSerializer();
        var isRequiredKeywordSupported = IsSupported(modelData.Settings.UseRequiredKeyword, modelData.Settings.TargetFramework);
        var requiredKeyword = isRequiredKeywordSupported
            ? " required"
            : string.Empty;
        var additionalPropertiesPostfix = modelData.ClassName == "AdditionalProperties"
            ? "2"
            : string.Empty;
        var json = GenerateFromToJsonMethods(modelData.Namespace, modelData.ClassName, modelData.Settings, isValueType: false, cancellationToken);
        
        return $@" 
    {modelData.Summary.ToXmlDocumentationSummary(level: 4)}
    {(modelData.IsDeprecated ? "[global::System.Obsolete(\"This model marked as deprecated.\")]" : " ")}
    public sealed partial class {modelData.ClassName}
    {{
{modelData.Properties.Select(property => @$"
        {property.Summary.ToXmlDocumentationSummary(level: 8)}
        {jsonSerializer.GeneratePropertyAttribute(property.Id, property.IsRequired)}
        {jsonSerializer.GenerateConverterAttribute(property.ConverterType)}
        {(property.IsRequired ? jsonSerializer.GenerateRequiredAttribute() : string.Empty)}
        {(modelData.IsDeprecated || (property.Type is { IsDeprecated: true, IsAnyOfLike: false } && !property.IsRequired) ? "[global::System.Obsolete(\"This property marked as deprecated.\")]" : " ")}
        public{(property.IsRequired ? requiredKeyword : "")} {property.Type.CSharpType} {property.Name} {{ get; set; }}{GetDefaultValue(property, isRequiredKeywordSupported)}
").Inject()}

        {"Additional properties that are not explicitly defined in the schema".ToXmlDocumentationSummary(level: 8)}
        {jsonSerializer.GenerateExtensionDataAttribute()}
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties{additionalPropertiesPostfix} {{ get; set; }} = new global::System.Collections.Generic.Dictionary<string, object>();

{json}
    }}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
    
    
    public static string GenerateFromToJsonMethods(
        string @namespace,
        string className,
        Settings settings,
        bool isValueType,
        CancellationToken cancellationToken = default)
    {
        var typeName = $"global::{@namespace}.{className}";
        
        return settings.JsonSerializerType == JsonSerializerType.SystemTextJson
            ? @$"
        {"Serializes the current instance to a JSON string using the provided JsonSerializerContext.".ToXmlDocumentationSummary(level: 8)}
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {{
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }}

        {"Serializes the current instance to a JSON string using the provided JsonSerializerOptions.".ToXmlDocumentationSummary(level: 8)}
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode(""JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved."")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode(""JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications."")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {{
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }}

        {"Deserializes a JSON string using the provided JsonSerializerContext.".ToXmlDocumentationSummary(level: 8)}
        public static {typeName}? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {{
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof({typeName}),
                jsonSerializerContext) as {typeName}{(isValueType ? "?" : "")};
        }}

        {"Deserializes a JSON string using the provided JsonSerializerOptions.".ToXmlDocumentationSummary(level: 8)}
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode(""JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved."")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode(""JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications."")]
#endif
        public static {typeName}? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {{
            return global::System.Text.Json.JsonSerializer.Deserialize<{typeName}>(
                json,
                jsonSerializerOptions);
        }}

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<{typeName}?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {{
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof({typeName}),
                jsonSerializerContext).ConfigureAwait(false)) as {typeName}{(isValueType ? "?" : "")};
        }}

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode(""JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved."")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode(""JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications."")]
#endif
        public static global::System.Threading.Tasks.ValueTask<{typeName}?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {{
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<{typeName}?>(
                jsonStream,
                jsonSerializerOptions);
        }}
"
            : @$"
        {"Serializes the current instance to a JSON string using the provided JsonSerializerOptions.".ToXmlDocumentationSummary(level: 8)}
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode(""JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved."")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode(""JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications."")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {{
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }}

        {"Deserializes a JSON string using the provided JsonSerializerOptions.".ToXmlDocumentationSummary(level: 8)}
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode(""JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved."")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode(""JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications."")]
#endif
        public static {typeName}? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {{
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<{typeName}>(
                json,
                jsonSerializerOptions);
        }}

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode(""JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved."")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode(""JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications."")]
#endif
        public static global::System.Threading.Tasks.ValueTask<{typeName}?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {{
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<{typeName}?>(serializer.Deserialize<{typeName}>(jsonReader));
        }}
";
    }
}