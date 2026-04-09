//HintName: G.JsonConverters.OutputItemReasoningStatus.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class OutputItemReasoningStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.OutputItemReasoningStatus>
    {
        /// <inheritdoc />
        public override global::G.OutputItemReasoningStatus Read(
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputItemReasoningStatus0), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputItemReasoningStatus1), options);
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
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputItemReasoningStatus2), options);
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

            global::G.OutputItemReasoningStatus0? outputItemReasoningStatus0 = default;
            global::G.OutputItemReasoningStatus1? outputItemReasoningStatus1 = default;
            global::G.OutputItemReasoningStatus2? outputItemReasoningStatus2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputItemReasoningStatus0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputItemReasoningStatus0> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputItemReasoningStatus0).Name}");
                        outputItemReasoningStatus0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputItemReasoningStatus1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputItemReasoningStatus1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputItemReasoningStatus1).Name}");
                        outputItemReasoningStatus1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputItemReasoningStatus2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputItemReasoningStatus2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputItemReasoningStatus2).Name}");
                        outputItemReasoningStatus2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (outputItemReasoningStatus0 == null && outputItemReasoningStatus1 == null && outputItemReasoningStatus2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputItemReasoningStatus0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputItemReasoningStatus0> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputItemReasoningStatus0).Name}");
                    outputItemReasoningStatus0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputItemReasoningStatus1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputItemReasoningStatus1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputItemReasoningStatus1).Name}");
                    outputItemReasoningStatus1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputItemReasoningStatus2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputItemReasoningStatus2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputItemReasoningStatus2).Name}");
                    outputItemReasoningStatus2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.OutputItemReasoningStatus(
                outputItemReasoningStatus0,

                outputItemReasoningStatus1,

                outputItemReasoningStatus2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.OutputItemReasoningStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOutputItemReasoningStatus0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputItemReasoningStatus0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputItemReasoningStatus0> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputItemReasoningStatus0).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputItemReasoningStatus0!.Value, typeInfo);
            }
            else if (value.IsOutputItemReasoningStatus1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputItemReasoningStatus1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputItemReasoningStatus1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputItemReasoningStatus1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputItemReasoningStatus1!.Value, typeInfo);
            }
            else if (value.IsOutputItemReasoningStatus2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OutputItemReasoningStatus2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OutputItemReasoningStatus2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OutputItemReasoningStatus2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OutputItemReasoningStatus2!.Value, typeInfo);
            }
        }
    }
}