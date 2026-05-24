using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.Generation;

public static partial class Sources
{
    public static FileWithName PolymorphicArrayHelpers(
        CSharpSettings settings,
        CancellationToken cancellationToken = default)
    {
        if (!settings.GeneratePolymorphicArrayHelpers)
        {
            return FileWithName.Empty;
        }

        return new FileWithName(
            Name: $"{settings.Namespace}.AutoSDKPolymorphicFormat.g.cs",
            Text: GeneratePolymorphicArrayHelpers(settings, cancellationToken));
    }

    public static string GeneratePolymorphicArrayHelpers(
        CSharpSettings settings,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        return $@"#pragma warning disable CS1591
#nullable enable

namespace {settings.Namespace}
{{
    /// <summary>
    /// Base class for array items shaped as <c>oneOf{{string-enum, object-with-type-const}}</c>
    /// in OpenAPI/JSON Schema. Each variant carries a <see cref=""Type""/> discriminator: bare
    /// enum strings round-trip through the same property as object variants (Firecrawl v2
    /// scrape <c>formats</c>, OpenAI Responses <c>tools</c>, Anthropic tool-use <c>content</c>).
    ///
    /// <para><b>Usage:</b> derive a base class from <see cref=""AutoSDKPolymorphicFormat""/>, mark
    /// it with <see cref=""AutoSDKPolymorphicFormatVariantAttribute""/> entries for each known
    /// type token, derive sealed subclasses for each variant, and the
    /// <see cref=""AutoSDKPolymorphicFormatJsonConverter{{TBase}}""/> reads strings as the matching
    /// no-fields subclass and objects as the typed subclass via the <c>type</c> discriminator.</para>
    /// </summary>
    public abstract partial class AutoSDKPolymorphicFormat
    {{
        /// <summary>
        /// The variant discriminator value. Maps to the inline enum string when the wire form is a bare
        /// string, or to the <c>type</c> property when the wire form is an object.
        /// </summary>
        public abstract string Type {{ get; }}

        /// <summary>
        /// When true, the converter writes the variant as a bare string (the discriminator value)
        /// instead of an object. Defaults to <c>false</c>. Override and return <c>true</c> for
        /// subclasses that represent the bare-string variants of the schema.
        /// </summary>
        public virtual bool IsBareString => false;
    }}

    /// <summary>
    /// Registers a concrete <see cref=""AutoSDKPolymorphicFormat""/> subclass with the converter.
    /// Place on the abstract base class once per known variant (string value + concrete type).
    /// Multiple attributes are supported.
    /// </summary>
    [global::System.AttributeUsage(global::System.AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
    public sealed class AutoSDKPolymorphicFormatVariantAttribute : global::System.Attribute
    {{
        /// <summary>
        /// Initializes a new instance of <see cref=""AutoSDKPolymorphicFormatVariantAttribute""/>.
        /// </summary>
        /// <param name=""discriminatorValue"">The string value matched on the wire (e.g. <c>""markdown""</c>, <c>""json""</c>).</param>
        /// <param name=""variantType"">The concrete subclass type representing this variant.</param>
        public AutoSDKPolymorphicFormatVariantAttribute(string discriminatorValue, global::System.Type variantType)
        {{
            DiscriminatorValue = discriminatorValue ?? throw new global::System.ArgumentNullException(nameof(discriminatorValue));
            VariantType = variantType ?? throw new global::System.ArgumentNullException(nameof(variantType));
        }}

        /// <summary>The string token matched on the wire.</summary>
        public string DiscriminatorValue {{ get; }}

        /// <summary>The concrete subclass instantiated for this token.</summary>
        public global::System.Type VariantType {{ get; }}
    }}

    /// <summary>
    /// <see cref=""global::System.Text.Json.Serialization.JsonConverter""/> for
    /// <see cref=""AutoSDKPolymorphicFormat""/> hierarchies. Reads:
    /// <list type=""bullet"">
    ///   <item>A bare JSON string -> the variant whose <c>DiscriminatorValue</c> matches and whose <see cref=""AutoSDKPolymorphicFormat.IsBareString""/> is <c>true</c> (constructed via parameterless ctor).</item>
    ///   <item>A JSON object with a <c>type</c> property -> the matching typed variant deserialized from the object body.</item>
    /// </list>
    /// Writes the symmetric form based on each instance's <see cref=""AutoSDKPolymorphicFormat.IsBareString""/>.
    /// </summary>
    /// <typeparam name=""TBase""></typeparam>
    [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode(""AutoSDKPolymorphicFormatJsonConverter uses reflection to instantiate variant subclasses. Use [AutoSDKPolymorphicFormatVariant] attributes; concrete subclasses are constructed via Activator.CreateInstance."")]
    [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode(""AutoSDKPolymorphicFormatJsonConverter dispatches deserialization to concrete subclasses via reflection; mark variant types DynamicallyAccessedMembers when trimming."")]
    public sealed class AutoSDKPolymorphicFormatJsonConverter<TBase> : global::System.Text.Json.Serialization.JsonConverter<TBase>
        where TBase : global::{settings.Namespace}.AutoSDKPolymorphicFormat
    {{
        private static readonly global::System.Collections.Generic.IReadOnlyDictionary<string, global::System.Type> VariantMap = BuildVariantMap();

        /// <inheritdoc />
        public override TBase? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {{
            if (reader.TokenType == global::System.Text.Json.JsonTokenType.Null)
            {{
                return null;
            }}

            if (reader.TokenType == global::System.Text.Json.JsonTokenType.String)
            {{
                var token = reader.GetString();
                if (token is null || !VariantMap.TryGetValue(token, out var variantType))
                {{
                    throw new global::System.Text.Json.JsonException(
                        $""Unknown polymorphic format token '{{token}}' for base {{typeof(TBase).FullName}}."");
                }}

                var instance = (TBase?)global::System.Activator.CreateInstance(variantType);
                if (instance is null || !instance.IsBareString)
                {{
                    throw new global::System.Text.Json.JsonException(
                        $""Variant '{{token}}' was registered but does not override IsBareString to true; cannot deserialize from bare string."");
                }}

                return instance;
            }}

            if (reader.TokenType != global::System.Text.Json.JsonTokenType.StartObject)
            {{
                throw new global::System.Text.Json.JsonException(
                    $""Expected string or object for polymorphic format {{typeof(TBase).FullName}}; got {{reader.TokenType}}."");
            }}

            using var document = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            if (!document.RootElement.TryGetProperty(""type"", out var typeElement) ||
                typeElement.ValueKind != global::System.Text.Json.JsonValueKind.String)
            {{
                throw new global::System.Text.Json.JsonException(
                    $""Polymorphic format {{typeof(TBase).FullName}} requires a string-typed 'type' property when serialized as an object."");
            }}

            var discriminator = typeElement.GetString();
            if (discriminator is null || !VariantMap.TryGetValue(discriminator, out var matchedType))
            {{
                throw new global::System.Text.Json.JsonException(
                    $""Unknown polymorphic format type '{{discriminator}}' for base {{typeof(TBase).FullName}}."");
            }}

            return (TBase?)global::System.Text.Json.JsonSerializer.Deserialize(
                document.RootElement.GetRawText(),
                matchedType,
                options);
        }}

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            TBase value,
            global::System.Text.Json.JsonSerializerOptions options)
        {{
            if (value is null)
            {{
                writer.WriteNullValue();
                return;
            }}

            if (value.IsBareString)
            {{
                writer.WriteStringValue(value.Type);
                return;
            }}

            global::System.Text.Json.JsonSerializer.Serialize(writer, (object)value, value.GetType(), options);
        }}

        private static global::System.Collections.Generic.IReadOnlyDictionary<string, global::System.Type> BuildVariantMap()
        {{
            var map = new global::System.Collections.Generic.Dictionary<string, global::System.Type>(global::System.StringComparer.Ordinal);
            foreach (var attribute in typeof(TBase).GetCustomAttributes(
                typeof(global::{settings.Namespace}.AutoSDKPolymorphicFormatVariantAttribute),
                inherit: false))
            {{
                if (attribute is global::{settings.Namespace}.AutoSDKPolymorphicFormatVariantAttribute variant)
                {{
                    map[variant.DiscriminatorValue] = variant.VariantType;
                }}
            }}

            return map;
        }}
    }}
}}".RemoveBlankLinesWhereOnlyWhitespaces();
    }
}
