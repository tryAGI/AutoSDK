using AutoSDK.Extensions;
using AutoSDK.Helpers;
using AutoSDK.Models;

namespace AutoSDK.Generation;

public static partial class Sources
{
    internal static FileWithName SharedJsonMetadataContext(Client client, EquatableArray<TypeData> types,
        string[] dependencies, SharedJsonMetadataPlan metadata, bool internalContext,
        IReadOnlyCollection<ModelData>? models = null)
    {
        var state = new JsonSerializerContextGenerationState();
        var components = state.GetJsonSerializableTypeComponents(types);
        var nullable = state.GetNullableValueTypes(types);
        var ownTypes = components.DistinctTypes.Concat(components.ConcreteListTypes).Concat(nullable)
            .Distinct(StringComparer.Ordinal).ToArray();
        var deprecated = types.Where(static type => type.IsDeprecated)
            .Select(static type => type.CSharpTypeWithoutNullability)
            .Concat(models?.Select(static model => model.GlobalClassName) ?? [])
            .Distinct(StringComparer.Ordinal).ToArray();
        var registrations = GenerateJsonSerializableAttributeRegistrations(client, types,
            (ownTypes, components.ExplicitNullableValueTypes, []), state.TypeInfoNames, nullable, deprecated);
        var name = GetJsonSerializerContextClassName(client);
        var scope = metadata.ScopeTypeName;
        using var builder = new PooledStringBuilder(4096);
        builder.Append($@"
#nullable enable
namespace {client.Settings.Namespace}
{{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    {(internalContext ? "internal static partial class " + name : "public sealed partial class " + name + " : global::System.Text.Json.Serialization.JsonSerializerContext")}
    {{
{(internalContext ? $@"
        internal static readonly {scope} MetadataScope = new(
                {(registrations.Length == 0 ? "null" : "new SharedMetadataResolver()")},
                new global::System.Func<{scope}>[] {{
{dependencies.Select(dependency => $"                    static () => global::{dependency}.MetadataScope,").Inject()}
                }}, {(client.Converters.Length == 0 ? "null" : "ContributeConverters")});
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;
" : $@"
        internal static {scope} MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {{
            internal static readonly {scope} Value = new(
                {(registrations.Length == 0 ? "null" : "new SharedMetadataResolver()")},
                new global::System.Func<{scope}>[] {{
{dependencies.Select(dependency => $"                    static () => global::{dependency}.MetadataScope,").Inject()}
                }}, {(client.Converters.Length == 0 ? "null" : "ContributeConverters")});
        }}
        private static class DefaultHolder
        {{
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly {name} Instance = new(Options);
        }}
        /// <summary>The default context for this scope.</summary>
        public static {name} Default => DefaultHolder.Instance;
        private {name}(global::System.Text.Json.JsonSerializerOptions options) : base(options) {{ }}
        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultHolder.Options;
        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type) =>
            MetadataScope.GetTypeInfo(type, Options);
")}
        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);
");
        if (client.Converters.Length != 0)
        {
            var lazy = GetLazyEnumConverterRegistrations(client.Converters);
            var lazyTypes = new HashSet<string>(lazy.Select(static registration => registration.ConverterType), StringComparer.Ordinal);
            builder.Append($@"
        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters({scope}.ConverterCollector collector)
        {{");
            foreach (var registration in lazy)
            {
                builder.Append($@"
            collector.AddEnum(typeof({registration.TargetType}), static () => new {registration.ConverterType}());");
            }
            foreach (var converter in client.Converters.Where(converter => !lazyTypes.Contains(converter)))
            {
                builder.Append($@"
            collector.AddEager<{converter}>(static () => new {converter}());");
            }
            builder.Append(@"
        }
        #pragma warning restore CS0612, CS0618
");
        }
        if (registrations.Length != 0)
        {
            AppendSharedMetadataResolver(builder, registrations, metadata);
        }
        builder.Append("\n    }\n}");
        var fileName = client.FileNameWithoutExtension.TrimEnd('.');
        return new FileWithName(fileName + ".JsonSerializerContext.g.cs",
            builder.ToString().RemoveBlankLinesWhereOnlyWhitespaces());
    }

    private static FileWithName SharedJsonMetadataRuntime(Client client, IReadOnlyDictionary<string, string> factories)
    {
        // Object-valued extension data is read as JsonElement. Reserializing it (or nested
        // untyped maps/arrays) needs these bounded BCL factories, never an SDK-wide resolver.
        // Preserve primitive metadata already registered by this SDK for manually supplied values.
        var intrinsicTypes = new[]
        {
            "string", "object", "bool", "byte", "sbyte", "short", "ushort", "int", "uint", "long", "ulong",
            "float", "double", "decimal", "char", "byte[]", "global::System.DateTime", "global::System.DateTimeOffset",
            "global::System.Guid", "global::System.TimeSpan", "global::System.DateOnly", "global::System.TimeOnly",
            "global::System.Uri", "global::System.Text.Json.JsonElement", "global::System.Text.Json.JsonElement?",
            "global::System.Collections.Generic.Dictionary<string, string>",
            "global::System.Collections.Generic.Dictionary<string, object>",
            "global::System.Collections.Generic.IDictionary<string, object>",
            "global::System.Collections.Generic.IDictionary<string, global::System.Text.Json.JsonElement>",
            "global::System.Collections.Generic.List<object>",
        };
        using var intrinsic = new PooledStringBuilder(4096);
        AppendSharedMetadataResolver(intrinsic, intrinsicTypes.Where(factories.ContainsKey)
            .Select(static type => new JsonSerializableAttributeRegistration(type, null, null, false, false))
            .ToArray(), factories);
        var name = GetJsonSerializerContextClassName(client) + "MetadataScope";
        return new FileWithName(client.Settings.Namespace + "." + name + ".g.cs", $@"
#nullable enable
namespace {client.Settings.Namespace}
{{
    // Instances reference only this component and its outgoing dependency components.
    internal sealed partial class {name} : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
    {{
{intrinsic}
        private static readonly SharedMetadataResolver Intrinsic = new();
        private readonly global::System.Lazy<ScopedContext> _default;
        internal global::System.Text.Json.Serialization.JsonSerializerContext Default => _default.Value;
        // One options-bound context implementation serves every internal component.
        // Options are created lazily, after all component initializers have completed.
        private sealed class ScopedContext : global::System.Text.Json.Serialization.JsonSerializerContext
        {{
            private readonly {name} _scope;
            internal ScopedContext({name} scope) : base(scope.CreateOptions()) => _scope = scope;
            protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => Options;
            public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type) =>
                _scope.GetTypeInfo(type, Options);
        }}
        private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver? _own;
        private readonly global::System.Func<{name}>[] _dependencies;
        private readonly global::System.Action<ConverterCollector>? _contribute;
        internal {name}(global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver? own,
            global::System.Func<{name}>[] dependencies, global::System.Action<ConverterCollector>? contribute)
        {{
            _default = new global::System.Lazy<ScopedContext>(() => new ScopedContext(this));
            _own = own;
            _dependencies = dependencies;
            _contribute = contribute;
        }}
        // Iteration bounds deep graphs and visits a shared diamond dependency only once.
        private global::System.Collections.Generic.IEnumerable<{name}> Traverse()
        {{
            var visited = new global::System.Collections.Generic.HashSet<{name}>();
            var pending = new global::System.Collections.Generic.Stack<{name}>();
            pending.Push(this);
            while (pending.Count != 0)
            {{
                var scope = pending.Pop();
                if (!visited.Add(scope)) continue;
                yield return scope;
                for (var index = scope._dependencies.Length - 1; index >= 0; index--)
                    pending.Push(scope._dependencies[index]());
            }}
        }}
        public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
            global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
        {{
            foreach (var scope in Traverse())
                if (scope._own?.GetTypeInfo(type, options) is {{ }} info) return info;
            return Intrinsic.GetTypeInfo(type, options);
        }}
        internal global::System.Text.Json.JsonSerializerOptions CreateOptions()
        {{
            var options = new global::System.Text.Json.JsonSerializerOptions
            {{
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = this,
            }};
            AddConverters(options);
            return options;
        }}
        internal void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {{
            var collector = new ConverterCollector(options);
            foreach (var scope in Traverse()) scope._contribute?.Invoke(collector);
            collector.Complete();
        }}
        internal sealed class ConverterCollector(global::System.Text.Json.JsonSerializerOptions options)
        {{
            private readonly global::System.Collections.Generic.Dictionary<global::System.Type,
                global::System.Func<global::System.Text.Json.Serialization.JsonConverter>> _enums = new();
            private readonly global::System.Collections.Generic.HashSet<global::System.Type> _eager = new();
            internal void AddEnum(global::System.Type type,
                global::System.Func<global::System.Text.Json.Serialization.JsonConverter> factory) => _enums.TryAdd(type, factory);
            internal void AddEager<T>(global::System.Func<T> factory) where T : global::System.Text.Json.Serialization.JsonConverter
            {{
                if (!_eager.Add(typeof(T))) return;
                foreach (var converter in options.Converters) if (converter is T) return;
                options.Converters.Add(factory());
            }}
            internal void Complete()
            {{
                if (_enums.Count != 0) options.Converters.Add(new EnumConverters(_enums));
            }}
        }}
        private sealed class EnumConverters(global::System.Collections.Generic.Dictionary<global::System.Type,
            global::System.Func<global::System.Text.Json.Serialization.JsonConverter>> factories)
            : global::System.Text.Json.Serialization.JsonConverterFactory
        {{
            public override bool CanConvert(global::System.Type typeToConvert) => factories.ContainsKey(typeToConvert);
            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert, global::System.Text.Json.JsonSerializerOptions options) =>
                factories.TryGetValue(typeToConvert, out var factory) ? factory() :
                    throw new global::System.NotSupportedException(typeToConvert.FullName);
        }}
    }}

    // A lookup facade only: never assign it to JsonSerializerOptions.TypeInfoResolver.
    // The framework cache stays owned by the caller's options and handles recursive graphs.
    internal sealed class AutoSDKJsonMetadataCachedResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
    {{
        internal static readonly AutoSDKJsonMetadataCachedResolver Instance = new();
        public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
            global::System.Type type, global::System.Text.Json.JsonSerializerOptions options) =>
            options.TryGetTypeInfo(type, out var info) ? info : null;
    }}
}}");
    }
}
