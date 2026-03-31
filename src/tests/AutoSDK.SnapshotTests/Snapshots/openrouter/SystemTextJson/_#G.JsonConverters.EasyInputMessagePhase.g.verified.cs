//HintName: G.JsonConverters.EasyInputMessagePhase.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class EasyInputMessagePhaseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.EasyInputMessagePhase>
    {
        /// <inheritdoc />
        public override global::G.EasyInputMessagePhase Read(
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::G.EasyInputMessagePhase0), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::G.EasyInputMessagePhase1), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(object), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score2++;
                    }
                }
            }
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.EasyInputMessagePhase0? easyInputMessagePhase0 = default;
            global::G.EasyInputMessagePhase1? easyInputMessagePhase1 = default;
            object? value3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EasyInputMessagePhase0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EasyInputMessagePhase0> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EasyInputMessagePhase0).Name}");
                        easyInputMessagePhase0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EasyInputMessagePhase1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EasyInputMessagePhase1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EasyInputMessagePhase1).Name}");
                        easyInputMessagePhase1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                        value3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (easyInputMessagePhase0 == null && easyInputMessagePhase1 == null && value3 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EasyInputMessagePhase0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EasyInputMessagePhase0> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EasyInputMessagePhase0).Name}");
                    easyInputMessagePhase0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EasyInputMessagePhase1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EasyInputMessagePhase1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EasyInputMessagePhase1).Name}");
                    easyInputMessagePhase1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                    value3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.EasyInputMessagePhase(
                easyInputMessagePhase0,

                easyInputMessagePhase1,

                value3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.EasyInputMessagePhase value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsEasyInputMessagePhase0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EasyInputMessagePhase0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EasyInputMessagePhase0> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EasyInputMessagePhase0).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EasyInputMessagePhase0!.Value, typeInfo);
            }
            else if (value.IsEasyInputMessagePhase1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EasyInputMessagePhase1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EasyInputMessagePhase1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EasyInputMessagePhase1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EasyInputMessagePhase1!.Value, typeInfo);
            }
            else if (value.IsValue3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3!, typeInfo);
            }
        }
    }
}