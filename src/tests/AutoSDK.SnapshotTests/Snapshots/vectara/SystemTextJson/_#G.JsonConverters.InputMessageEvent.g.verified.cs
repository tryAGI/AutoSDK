//HintName: G.JsonConverters.InputMessageEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class InputMessageEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.InputMessageEvent>
    {
        /// <inheritdoc />
        public override global::G.InputMessageEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::G.AgentEventBase? agentBase = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentEventBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentEventBase> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AgentEventBase).Name}");
                agentBase = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::G.InputMessageEventVariant2? inputMessageEventVariant2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputMessageEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputMessageEventVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputMessageEventVariant2).Name}");
                inputMessageEventVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::G.InputMessageEvent(
                agentBase,

                inputMessageEventVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.InputMessageEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsAgentBase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentEventBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentEventBase?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AgentEventBase).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.AgentBase!, typeInfo);
                if (__element0.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element0.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            if (value.IsInputMessageEventVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.InputMessageEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.InputMessageEventVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.InputMessageEventVariant2).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.InputMessageEventVariant2!, typeInfo);
                if (__element1.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element1.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            writer.WriteEndObject();
        }
    }
}