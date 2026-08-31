using AutoSDK.Extensions;
using AutoSDK.Helpers;
using AutoSDK.Models;
using AutoSDK.Serialization.Json;

namespace AutoSDK.Generation;

public static partial class Sources
{
    public static string GenerateModel(
        ModelData modelData,
        CancellationToken cancellationToken = default)
    {
        var suppressObsoleteWarnings =
            HasDeprecatedTypeReferences(modelData) ||
            HasDeprecatedBaseClass(modelData);

        if (modelData.Settings.NamingConvention == NamingConvention.ConcatNames ||
            modelData.Parents.AsSpan().Length == 0)
        {
            using var builder = new NormalizedPooledStringBuilder(4096);
            builder.Append($@"
{(suppressObsoleteWarnings ? @"#pragma warning disable CS0618 // Type or member is obsolete
" : TrimmedLine)}
#nullable enable

namespace {modelData.Namespace}
{{
");
            switch (modelData.Style)
            {
                case ModelStyle.Class:
                    AppendClassModelCore(builder, modelData, cancellationToken);
                    break;
                case ModelStyle.Enumeration:
                    if (modelData.IsOpenEnum)
                    {
                        builder.Append(GenerateEnumerationModel(modelData, cancellationToken));
                        builder.Append("\n\n");
                        builder.Append(GenerateEnumExtensions(modelData, cancellationToken));
                    }
                    else
                    {
                        AppendClosedEnumerationModel(
                            builder,
                            modelData,
                            includeEnumMemberAttributes: modelData.Settings.UsesNewtonsoftJson());
                        builder.Append("\n\n");
                        AppendClosedEnumExtensions(builder, modelData);
                    }
                    break;
                default:
                    throw new NotSupportedException($"Model style {modelData.Style} is not supported.");
            }
            builder.Append(@"
}");
            return builder.ToString();
        }

        return NormalizedString.Create($@"
{(suppressObsoleteWarnings ? @"#pragma warning disable CS0618 // Type or member is obsolete
" : TrimmedLine)}
#nullable enable

namespace {modelData.Namespace}
{{
{GenerateModel(modelData, level: 0, cancellationToken: cancellationToken)}
}}");
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
                ModelStyle.Class => GenerateClassModelCore(modelData, normalizeOutput: false, cancellationToken),
                ModelStyle.Enumeration =>
                    GenerateEnumerationModel(modelData, cancellationToken) + "\n\n" +
                    GenerateEnumExtensions(modelData, cancellationToken),
                _ => throw new NotSupportedException($"Model style {modelData.Style} is not supported."),
            };
        }

        return NormalizedString.Create($@"{TrimmedLine}
public sealed partial class {modelData.Parents[level].Unbox<ModelData>().ClassName}
{{
{GenerateModel(modelData, level + 1, cancellationToken: cancellationToken)}
}}").AddIndent(level: 1);
    }

    private static bool IsSupported(SdkFeatureUsage usage, string targetFramework)
    {
        return usage switch
        {
            SdkFeatureUsage.Always => true,
            SdkFeatureUsage.InSupportedTargetFrameworks
                when IsNetVersionAtLeast(targetFramework, 8) => true,
            _ => false,
        };
    }

    private static bool IsNetVersionAtLeast(string targetFramework, int minMajor)
    {
        // Match "net" followed by digits (e.g., "net8.0", "net10.0")
        // Exclude "netstandard" and "netcoreapp" prefixes
        if (!targetFramework.StartsWith("net", StringComparison.OrdinalIgnoreCase) ||
            targetFramework.StartsWith("netstandard", StringComparison.OrdinalIgnoreCase) ||
            targetFramework.StartsWith("netcoreapp", StringComparison.OrdinalIgnoreCase))
        {
            return false;
        }

        var versionPart = targetFramework.Substring(3); // Remove "net"
        var dotIndex = versionPart.IndexOf('.');
        var majorStr = dotIndex >= 0 ? versionPart.Substring(0, dotIndex) : versionPart;

        return int.TryParse(majorStr, out var major) && major >= minMajor;
    }

    private static string GetDefaultValue(PropertyData property, bool isRequiredKeywordSupported)
    {
        if (property.IsRequired && !isRequiredKeywordSupported)
        {
            return " = default!;";
        }

        if (!property.Type.IsValueType &&
            !property.Type.CSharpTypeNullability &&
            string.IsNullOrWhiteSpace(property.DefaultValue) &&
            !(property.IsRequired && isRequiredKeywordSupported))
        {
            return " = default!;";
        }

        return property.Type.CSharpTypeNullability || string.IsNullOrWhiteSpace(property.DefaultValue)
            ? string.Empty
            : $" = {property.DefaultValue};";
    }

    private static string GeneratePropertyConverterAttribute(
        IJsonSerializer jsonSerializer,
        EmitterSettings settings,
        PropertyData property)
    {
        if (settings.UsesNewtonsoftJson() &&
            !property.Type.IsEnum &&
            !property.Type.IsUnixTimestamp)
        {
            return string.Empty;
        }

        return jsonSerializer.GenerateConverterAttribute(property.ConverterType);
    }

    private static bool HasDeprecatedTypeReferences(ModelData modelData)
    {
        for (var i = 0; i < modelData.Properties.Length; i++)
        {
            if (TypeUsesDeprecatedMembers(modelData.Properties[i].Type))
            {
                return true;
            }
        }

        return false;
    }

    private static bool TypeUsesDeprecatedMembers(TypeData type)
    {
        if (type.IsDeprecated)
        {
            return true;
        }

        for (var i = 0; i < type.SubTypes.Length; i++)
        {
            if (TypeUsesDeprecatedMembers(type.SubTypes[i].Unbox<TypeData>()))
            {
                return true;
            }
        }

        return false;
    }

    private static bool HasDeprecatedBaseClass(ModelData modelData)
    {
        return modelData.IsDerivedClass && modelData.HasDeprecatedBaseClass;
    }

    private static IEnumerable<PropertyData> GetDirectProperties(SchemaContext context)
    {
        var source = context.IsDerivedClass
            ? context.DerivedClassContext.Children
            : !context.Schema.IsEnum()
                ? context.Children
                : null;

        if (source == null || source.Count == 0)
        {
            yield break;
        }

        var discriminatorPropertyName = context.IsBaseClass
            ? context.Schema.Discriminator?.PropertyName
            : null;
        var hasDiscriminator = !string.IsNullOrWhiteSpace(discriminatorPropertyName);

        for (var i = 0; i < source.Count; i++)
        {
            var child = source[i];
            if (child is not { IsProperty: true, PropertyData: not null })
            {
                continue;
            }

            foreach (var property in child.ComputedProperties)
            {
                if (!hasDiscriminator || property.Id != discriminatorPropertyName)
                {
                    yield return property;
                }
            }
        }
    }

    private static IEnumerable<PropertyData> GetInheritedProperties(ModelData modelData, bool requiredOnly = false)
    {
        if (!modelData.IsDerivedClass)
        {
            yield break;
        }

        var seenNames = new HashSet<string>(StringComparer.Ordinal);
        SchemaContext? current = modelData.SchemaContext;

        while (current is not null && current.IsDerivedClass)
        {
            var baseContext = current.BaseClassContext;
            if (baseContext.ReferenceId is string baseReferenceId &&
                !string.IsNullOrWhiteSpace(baseReferenceId) &&
                current.ComponentSchemas?.TryGetValue(baseReferenceId, out var componentBaseContext) == true)
            {
                baseContext = componentBaseContext;
            }
            else
            {
                baseContext = baseContext.ResolvedReference ?? baseContext;
            }

            foreach (var property in GetDirectProperties(baseContext))
            {
                if ((requiredOnly && !property.IsRequired) || !seenNames.Add(property.Name))
                {
                    continue;
                }

                yield return property;
            }

            current = baseContext;
        }
    }

    private static void AppendConstructorParameter(
        PooledStringBuilder builder,
        PropertyData property,
        bool isRequiredKeywordSupported,
        bool forceRequired = false,
        string? parameterName = null)
    {
        parameterName ??= property.ParameterName;
        builder.Append("\n            ");
        builder.Append(property.Type.CSharpType);
        builder.Append(' ');
        builder.Append(parameterName);
        if (!forceRequired &&
            !property.IsRequired &&
            !property.Type.CSharpTypeNullability &&
            !string.IsNullOrWhiteSpace(property.DefaultValue))
        {
            builder.Append(GetDefaultValue(property, isRequiredKeywordSupported).TrimEnd(';'));
        }
    }

    private static void AppendConstructorAssignment(
        PooledStringBuilder builder,
        string target,
        PropertyData property,
        string? parameterName = null,
        bool forceRequired = false,
        bool prependNewLine = true)
    {
        parameterName ??= property.ParameterName;
        if (prependNewLine)
        {
            builder.Append('\n');
        }
        builder.Append("            ");
        builder.Append(target);
        builder.Append('.');
        builder.Append(property.Name);
        builder.Append(" = ");
        builder.Append(parameterName);
        if ((forceRequired || property.IsRequired) && !property.Type.IsValueType)
        {
            builder.Append(" ?? throw new global::System.ArgumentNullException(nameof(");
            builder.Append(parameterName);
            builder.Append("))");
        }
        builder.Append(';');
    }

    public static string GenerateClassModel(
        ModelData modelData,
        CancellationToken cancellationToken = default)
    {
        return GenerateClassModelCore(modelData, normalizeOutput: true, cancellationToken);
    }

    private static string GenerateClassModelCore(
        ModelData modelData,
        bool normalizeOutput,
        CancellationToken cancellationToken)
    {
        using PooledStringBuilder builder = normalizeOutput
            ? new NormalizedPooledStringBuilder(Math.Max(4096, modelData.Properties.Length * 256))
            : new PooledStringBuilder(Math.Max(4096, modelData.Properties.Length * 256));
        AppendClassModelCore(builder, modelData, cancellationToken);
        return builder.ToString();
    }

    private static void AppendClassModelCore(
        PooledStringBuilder resultBuilder,
        ModelData modelData,
        CancellationToken cancellationToken)
    {
        var jsonSerializer = modelData.Settings.GetSerializer();
        var isRequiredKeywordSupported = IsSupported(modelData.Settings.UseRequiredKeyword, modelData.Settings.TargetFramework);
        var requiredKeyword = isRequiredKeywordSupported
            ? " required"
            : string.Empty;
        var properties = modelData.Properties;
        var hasAdditionalPropertiesProperty = properties.Any(x => x.Name == "AdditionalProperties");
        var additionalPropertiesPostfix = modelData.ClassName == "AdditionalProperties" || hasAdditionalPropertiesProperty
            ? "2"
            : string.Empty;
        var additionalPropertiesValueType = GetAdditionalPropertiesValueType(modelData.Settings);
        var additionalPropertiesSummary = modelData.Settings.GenerateRawModelData
            ? "Raw JSON properties that are not explicitly defined in the schema"
            : "Additional properties that are not explicitly defined in the schema";

        var inheritedPropertyNames = new HashSet<string>(
            modelData.InheritedPropertyNames,
            StringComparer.Ordinal);
        var inheritedRequiredPropertiesByName = modelData.InheritedRequiredProperties
            .ToDictionary(static x => x.Name, static x => x, StringComparer.Ordinal);

        var constructorProperties = properties
            .Where(x => x.IsRequired || !x.IsDeprecated || inheritedRequiredPropertiesByName.ContainsKey(x.Name))
            .ToArray();
        var constructorBaseOnlyRequiredProperties = inheritedRequiredPropertiesByName.Values
            .Where(x => properties.All(y => !string.Equals(y.Name, x.Name, StringComparison.Ordinal)))
            .ToArray();
        var requiredConstructorProperties = constructorProperties
            .Where(x => x.IsRequired || inheritedRequiredPropertiesByName.ContainsKey(x.Name))
            .ToArray();
        var optionalConstructorProperties = constructorProperties
            .Where(x => !x.IsRequired && !inheritedRequiredPropertiesByName.ContainsKey(x.Name))
            .ToArray();
        var optionalConstructorPropertiesWithoutDefaults = optionalConstructorProperties
            .Where(x => x.Type.CSharpTypeNullability || string.IsNullOrWhiteSpace(x.DefaultValue))
            .ToArray();
        var optionalConstructorPropertiesWithDefaults = optionalConstructorProperties
            .Where(x => !x.Type.CSharpTypeNullability && !string.IsNullOrWhiteSpace(x.DefaultValue))
            .ToArray();
        var hasConstructor = constructorProperties.Length > 0 || constructorBaseOnlyRequiredProperties.Length > 0;

        var leafFactory = TryGetCascadingLeafFactory(
            modelData,
            requiredConstructorProperties,
            constructorBaseOnlyRequiredProperties,
            optionalConstructorPropertiesWithDefaults,
            optionalConstructorPropertiesWithoutDefaults);

        resultBuilder.Append("    ");
        AppendXmlDocumentationSummary(resultBuilder, modelData.Summary, level: 4);
        resultBuilder.Append($@"
    {(modelData.IsDeprecated ? $"[global::System.Obsolete(\"{(!string.IsNullOrWhiteSpace(modelData.DeprecationMessage) ? modelData.DeprecationMessage.ClearForCSharp() : "This model marked as deprecated.")}\")]" : TrimmedLine)}
    {(modelData.Settings.UsesSystemTextJson() && modelData.IsBaseClass ? @$" 
    [global::System.Text.Json.Serialization.JsonPolymorphic(
        TypeDiscriminatorPropertyName = ""{modelData.DiscriminatorPropertyName}"",
        IgnoreUnrecognizedTypeDiscriminators = true,
        UnknownDerivedTypeHandling = global::System.Text.Json.Serialization.JsonUnknownDerivedTypeHandling.FallBackToBaseType)]
{modelData.DerivedTypes.Select(x => $@"
    [global::System.Text.Json.Serialization.JsonDerivedType(typeof({x.GlobalClassName}), typeDiscriminator: ""{x.Discriminator}"")]").Inject()}" : TrimmedLine)}
    public{(modelData.IsBaseClass ? "" : " sealed")} partial class {modelData.ClassName}{(!string.IsNullOrWhiteSpace(modelData.BaseClass) ? $" : {modelData.BaseClass}" : string.Empty)}
    {{
");
        AppendPropertyDeclarations(
            resultBuilder,
            modelData,
            jsonSerializer,
            properties,
            inheritedPropertyNames,
            requiredKeyword,
            isRequiredKeywordSupported);
        resultBuilder.Append("\n\n");
        resultBuilder.Append(!modelData.IsDerivedClass ? $@"{TrimmedLine}
        {additionalPropertiesSummary.ToXmlDocumentationSummary(level: 8)}
        {jsonSerializer.GenerateExtensionDataAttribute()}
        public global::System.Collections.Generic.IDictionary<string, {additionalPropertiesValueType}> AdditionalProperties{additionalPropertiesPostfix} {{ get; set; }} = new global::System.Collections.Generic.Dictionary<string, {additionalPropertiesValueType}>();
 " : TrimmedLine);
        resultBuilder.Append("\n \n");
        if (hasConstructor)
        {
            resultBuilder.Append($@"
        /// <summary>
        /// Initializes a new instance of the <see cref=""{modelData.ClassName}"" /> class.
        /// </summary>
");
            AppendConstructorParameterDocumentation(
                resultBuilder,
                requiredConstructorProperties,
                constructorBaseOnlyRequiredProperties,
                optionalConstructorPropertiesWithoutDefaults,
                optionalConstructorPropertiesWithDefaults);
            resultBuilder.Append('\n');
            resultBuilder.Append(modelData.Settings.UseSetsRequiredMembersAttributes is SdkFeatureUsage.Always or SdkFeatureUsage.InSupportedTargetFrameworks ? @$"{TrimmedLine}
{(modelData.Settings.UseExperimentalAttributes is SdkFeatureUsage.InSupportedTargetFrameworks ? @" 
#if NET7_0_OR_GREATER" : TrimmedLine)}
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
{(modelData.Settings.UseExperimentalAttributes is SdkFeatureUsage.InSupportedTargetFrameworks ? @" 
#endif" : TrimmedLine)}
 " : TrimmedLine);
            resultBuilder.Append($@"
        public {modelData.ClassName}(
 ");
            AppendConstructorParameters(
                resultBuilder,
                requiredConstructorProperties,
                constructorBaseOnlyRequiredProperties,
                optionalConstructorPropertiesWithoutDefaults,
                optionalConstructorPropertiesWithDefaults,
                inheritedRequiredPropertiesByName,
                isRequiredKeywordSupported);
            resultBuilder.Append(@")
        {
");
            AppendConstructorAssignments(
                resultBuilder,
                constructorProperties,
                constructorBaseOnlyRequiredProperties,
                inheritedRequiredPropertiesByName);
            resultBuilder.Append(@"
        }
 ");
        }
        else
        {
            resultBuilder.Append(TrimmedLine);
        }
        resultBuilder.Append('\n');
        resultBuilder.Append(properties.Any(static x => !x.IsDeprecated) ? $@"
        /// <summary>
        /// Initializes a new instance of the <see cref=""{modelData.ClassName}"" /> class.
        /// </summary>
        public {modelData.ClassName}()
        {{
        }}
 " : TrimmedLine);
        resultBuilder.Append('\n');
        resultBuilder.Append(leafFactory);
        resultBuilder.Append(@"
    }");
    }

    private static void AppendPropertyDeclarations(
        PooledStringBuilder builder,
        ModelData modelData,
        IJsonSerializer jsonSerializer,
        IReadOnlyList<PropertyData> properties,
        HashSet<string> inheritedPropertyNames,
        string requiredKeyword,
        bool isRequiredKeywordSupported)
    {
        if (properties.Count == 0)
        {
            builder.Append(TrimmedLine);
            return;
        }

        var firstProperty = true;
        foreach (var property in properties)
        {
            if (!firstProperty)
            {
                builder.Append("\n\n");
            }
            firstProperty = false;

            builder.Append("        ");
            AppendXmlDocumentationSummary(builder, property.Summary, level: 8);
            builder.Append("\n        ");
            builder.Append(property.DefaultValue?.ClearForXml().ToXmlDocumentationDefault(level: 8));
            builder.Append("\n        ");
            builder.Append(property.Example?.ToXmlDocumentationExample(level: 8));
            builder.Append("\n        ");
            builder.Append(GenerateValidationAttributes(modelData, property));
            builder.Append("\n        ");
            if (modelData.Settings.UsesSystemTextJson())
            {
                builder.Append("[global::System.Text.Json.Serialization.JsonPropertyName(\"");
                builder.Append(property.Id);
                builder.Append("\")]");
            }
            else
            {
                builder.Append(jsonSerializer.GeneratePropertyAttribute(property.Id, property.IsRequired));
            }
            builder.Append("\n        ");
            if (modelData.Settings.UsesSystemTextJson())
            {
                if (!string.IsNullOrWhiteSpace(property.ConverterType))
                {
                    builder.Append("[global::System.Text.Json.Serialization.JsonConverter(typeof(");
                    builder.Append(property.ConverterType);
                    builder.Append("))]");
                }
            }
            else
            {
                builder.Append(GeneratePropertyConverterAttribute(jsonSerializer, modelData.Settings, property));
            }
            builder.Append("\n        ");
            builder.Append(property.IsRequired ? jsonSerializer.GenerateRequiredAttribute() : string.Empty);
            builder.Append("\n        ");
            builder.Append(modelData.IsDeprecated ||
                           property.Type is { IsDeprecated: true, IsAnyOfLike: false } && !property.IsRequired
                ? $"[global::System.Obsolete(\"{(!string.IsNullOrWhiteSpace(modelData.DeprecationMessage) ? modelData.DeprecationMessage.ClearForCSharp() : "This property marked as deprecated.")}\")]"
                : TrimmedLine);
            builder.Append("\n        public");
            builder.Append(inheritedPropertyNames.Contains(property.Name) ? " new" : string.Empty);
            builder.Append(property.IsRequired ? requiredKeyword : string.Empty);
            builder.Append(' ');
            builder.Append(property.Type.CSharpType);
            builder.Append(' ');
            builder.Append(property.Name);
            builder.Append(" { get; set; }");
            builder.Append(GetDefaultValue(property, isRequiredKeywordSupported));
        }

    }

    private static void AppendConstructorParameterDocumentation(
        PooledStringBuilder builder,
        PropertyData[] requiredProperties,
        PropertyData[] baseOnlyRequiredProperties,
        PropertyData[] optionalPropertiesWithoutDefaults,
        PropertyData[] optionalPropertiesWithDefaults)
    {
        var hasDocumentation = false;
        AppendDocumentation(requiredProperties);
        AppendDocumentation(baseOnlyRequiredProperties);
        AppendDocumentation(optionalPropertiesWithoutDefaults);
        AppendDocumentation(optionalPropertiesWithDefaults);
        if (!hasDocumentation)
        {
            builder.Append(TrimmedLine);
        }

        void AppendDocumentation(PropertyData[] values)
        {
            foreach (var property in values)
            {
                if (hasDocumentation)
                {
                    builder.Append('\n');
                }
                else
                {
                    hasDocumentation = true;
                }
                builder.Append("        ");
                AppendXmlDocumentationForParam(
                    builder,
                    property.Summary,
                    property.ParameterName,
                    level: 8);
            }
        }
    }

    private static void AppendConstructorParameters(
        PooledStringBuilder builder,
        PropertyData[] requiredProperties,
        PropertyData[] baseOnlyRequiredProperties,
        PropertyData[] optionalPropertiesWithoutDefaults,
        PropertyData[] optionalPropertiesWithDefaults,
        Dictionary<string, PropertyData> inheritedRequiredPropertiesByName,
        bool isRequiredKeywordSupported)
    {
        var hasParameter = false;
        foreach (var property in requiredProperties)
        {
            AppendSeparator();
            var shareParameterWithBase = inheritedRequiredPropertiesByName.TryGetValue(property.Name, out var inheritedRequiredProperty) &&
                                         string.Equals(inheritedRequiredProperty.Type.CSharpType, property.Type.CSharpType, StringComparison.Ordinal);
            AppendConstructorParameter(
                builder,
                property,
                isRequiredKeywordSupported,
                forceRequired: property.IsRequired || shareParameterWithBase);
        }

        AppendParameters(baseOnlyRequiredProperties, forceRequired: true);
        AppendParameters(optionalPropertiesWithoutDefaults, forceRequired: false);
        AppendParameters(optionalPropertiesWithDefaults, forceRequired: false);

        void AppendParameters(PropertyData[] values, bool forceRequired)
        {
            foreach (var property in values)
            {
                AppendSeparator();
                AppendConstructorParameter(builder, property, isRequiredKeywordSupported, forceRequired);
            }
        }

        void AppendSeparator()
        {
            if (hasParameter)
            {
                builder.Append(',');
            }
            else
            {
                hasParameter = true;
            }
        }
    }

    private static void AppendConstructorAssignments(
        PooledStringBuilder builder,
        PropertyData[] constructorProperties,
        PropertyData[] baseOnlyRequiredProperties,
        Dictionary<string, PropertyData> inheritedRequiredPropertiesByName)
    {
        var hasAssignment = false;
        foreach (var property in constructorProperties)
        {
            AppendAssignment(
                target: "this",
                property,
                forceRequired: property.IsRequired || inheritedRequiredPropertiesByName.ContainsKey(property.Name));

            if (inheritedRequiredPropertiesByName.TryGetValue(property.Name, out var inheritedRequiredProperty) &&
                string.Equals(inheritedRequiredProperty.Type.CSharpType, property.Type.CSharpType, StringComparison.Ordinal))
            {
                AppendAssignment(
                    target: "base",
                    inheritedRequiredProperty,
                    parameterName: property.ParameterName,
                    forceRequired: true);
            }
        }

        foreach (var property in baseOnlyRequiredProperties)
        {
            AppendAssignment(
                target: "base",
                property,
                forceRequired: true);
        }

        if (!hasAssignment)
        {
            builder.Append(TrimmedLine);
        }

        void AppendAssignment(
            string target,
            PropertyData property,
            string? parameterName = null,
            bool forceRequired = false)
        {
            AppendConstructorAssignment(
                builder,
                target,
                property,
                parameterName,
                forceRequired,
                prependNewLine: hasAssignment);
            hasAssignment = true;
        }
    }

    private static string TryGetCascadingLeafFactory(
        ModelData modelData,
        PropertyData[] requiredConstructorProperties,
        PropertyData[] constructorBaseOnlyRequiredProperties,
        PropertyData[] optionalConstructorPropertiesWithDefaults,
        PropertyData[] optionalConstructorPropertiesWithoutDefaults)
    {
        // Cascading leaf factory: if exactly one constructor parameter is "meaningful"
        // (no const default — the leaf, typically an enum or scalar discriminator value)
        // and at least one is a const-defaulted discriminator, emit a static factory
        // taking only the leaf and hardcoding the discriminator(s). Saves the consumer
        // from rewriting the const discriminator at every call site for nested oneOf
        // wrappers (Runway-style).
        if (modelData.IsBaseClass ||
            modelData.IsDerivedClass ||
            modelData.IsDeprecated)
        {
            return string.Empty;
        }

        // The "leaf" is a constructor parameter without a default value.
        // Const-discriminator fields show up as either required-with-default (rare)
        // or optional-with-default. Both are emitted with `param = default` in the
        // generated constructor, so we treat them uniformly as the const-fields set.
        var leafCandidates = requiredConstructorProperties
            .Concat(constructorBaseOnlyRequiredProperties)
            .Where(static x => string.IsNullOrWhiteSpace(x.DefaultValue))
            .ToArray();
        if (leafCandidates.Length != 1)
        {
            return string.Empty;
        }

        var constFields = requiredConstructorProperties
            .Concat(constructorBaseOnlyRequiredProperties)
            .Concat(optionalConstructorPropertiesWithDefaults)
            .Where(static x => !string.IsNullOrWhiteSpace(x.DefaultValue))
            .ToArray();
        if (constFields.Length == 0)
        {
            return string.Empty;
        }

        var leaf = leafCandidates[0];

        // Skip when the leaf is itself a complex collection or wrapper — the From
        // factory adds no value over the constructor in those cases and risks
        // colliding with factories at deeper nesting levels.
        if (leaf.Type.IsAnyOfLike ||
            leaf.Type.IsArray ||
            leaf.Type.CSharpTypeWithoutNullability.StartsWith(
                "global::System.Collections.Generic.IList",
                StringComparison.Ordinal))
        {
            return string.Empty;
        }

        // Skip when const fields use the C# `required` keyword. The factory body
        // uses an object initializer, which only sets the leaf — `required` const
        // fields would still trigger CS9035 unless the initializer also assigns
        // them. Forcing the consumer to override the discriminator defeats the
        // factory's purpose, so we leave those classes alone.
        if (constFields.Any(static x => x.IsRequired))
        {
            return string.Empty;
        }

        // Use object-initializer syntax instead of the positional constructor.
        // This works whether or not the constructor has [SetsRequiredMembers]
        // because the initializer itself satisfies any required-member contracts,
        // and const-defaulted properties keep their inline default values from
        // the property declarations.
        return $@"
        /// <summary>
        /// Creates a new <see cref=""{modelData.ClassName}""/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static {modelData.ClassName} From{leaf.Name}({leaf.Type.CSharpType} {leaf.ParameterName})
        {{
            return new {modelData.ClassName}
            {{
                {leaf.Name} = {leaf.ParameterName},
            }};
        }}
";
    }

    private static string GetAdditionalPropertiesValueType(
        EmitterSettings settings)
    {
        if (!settings.GenerateRawModelData)
        {
            return "object";
        }

        if (settings.UsesSystemTextJson())
        {
            return "global::System.Text.Json.JsonElement";
        }

        if (settings.UsesNewtonsoftJson())
        {
            return "global::Newtonsoft.Json.Linq.JToken";
        }

        return "object";
    }
}
