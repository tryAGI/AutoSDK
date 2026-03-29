//HintName: G.JsonConverters.LocalizeDialect.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class LocalizeDialectJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.LocalizeDialect>
    {
        /// <inheritdoc />
        public override global::G.LocalizeDialect Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::G.LocalizeEnglishDialect), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score0++;
                    }
                }
            }
            var __score1 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::G.LocalizeSpanishDialect), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score1++;
                    }
                }
            }
            var __score2 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::G.LocalizePortugueseDialect), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score2++;
                    }
                }
            }
            var __score3 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::G.LocalizeFrenchDialect), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score3++;
                    }
                }
            }
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::G.LocalizeEnglishDialect? localizeEnglishDialect = default;
            global::G.LocalizeSpanishDialect? localizeSpanishDialect = default;
            global::G.LocalizePortugueseDialect? localizePortugueseDialect = default;
            global::G.LocalizeFrenchDialect? localizeFrenchDialect = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LocalizeEnglishDialect), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LocalizeEnglishDialect> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LocalizeEnglishDialect).Name}");
                        localizeEnglishDialect = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 1)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LocalizeSpanishDialect), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LocalizeSpanishDialect> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LocalizeSpanishDialect).Name}");
                        localizeSpanishDialect = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 2)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LocalizePortugueseDialect), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LocalizePortugueseDialect> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LocalizePortugueseDialect).Name}");
                        localizePortugueseDialect = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 3)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LocalizeFrenchDialect), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LocalizeFrenchDialect> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LocalizeFrenchDialect).Name}");
                        localizeFrenchDialect = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (localizeEnglishDialect == null && localizeSpanishDialect == null && localizePortugueseDialect == null && localizeFrenchDialect == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LocalizeEnglishDialect), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LocalizeEnglishDialect> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LocalizeEnglishDialect).Name}");
                    localizeEnglishDialect = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LocalizeSpanishDialect), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LocalizeSpanishDialect> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LocalizeSpanishDialect).Name}");
                    localizeSpanishDialect = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LocalizePortugueseDialect), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LocalizePortugueseDialect> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LocalizePortugueseDialect).Name}");
                    localizePortugueseDialect = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LocalizeFrenchDialect), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LocalizeFrenchDialect> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LocalizeFrenchDialect).Name}");
                    localizeFrenchDialect = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.LocalizeDialect(
                localizeEnglishDialect,

                localizeSpanishDialect,

                localizePortugueseDialect,

                localizeFrenchDialect
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.LocalizeDialect value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsLocalizeEnglishDialect)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LocalizeEnglishDialect), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LocalizeEnglishDialect> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LocalizeEnglishDialect).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LocalizeEnglishDialect, typeInfo);
            }
            else if (value.IsLocalizeSpanishDialect)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LocalizeSpanishDialect), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LocalizeSpanishDialect> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LocalizeSpanishDialect).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LocalizeSpanishDialect, typeInfo);
            }
            else if (value.IsLocalizePortugueseDialect)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LocalizePortugueseDialect), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LocalizePortugueseDialect> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LocalizePortugueseDialect).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LocalizePortugueseDialect, typeInfo);
            }
            else if (value.IsLocalizeFrenchDialect)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LocalizeFrenchDialect), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LocalizeFrenchDialect> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LocalizeFrenchDialect).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LocalizeFrenchDialect, typeInfo);
            }
        }
    }
}