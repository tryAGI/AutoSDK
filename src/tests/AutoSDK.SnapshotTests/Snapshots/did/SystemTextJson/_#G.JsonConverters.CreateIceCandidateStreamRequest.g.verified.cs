//HintName: G.JsonConverters.CreateIceCandidateStreamRequest.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CreateIceCandidateStreamRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateIceCandidateStreamRequest>
    {
        /// <inheritdoc />
        public override global::G.CreateIceCandidateStreamRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

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
            var __score1 = 0;
            if (__jsonProps.Contains("session_id")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.AnyOf<global::G.CreateIceCandidateStreamRequestVariant1Variant1, object>? createIceCandidateStreamRequestVariant1 = default;
            global::G.CreateIceCandidateStreamRequestVariant2? createIceCandidateStreamRequestVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        createIceCandidateStreamRequestVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AnyOf<global::G.CreateIceCandidateStreamRequestVariant1Variant1, object>>(__rawJson, options);
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
                        createIceCandidateStreamRequestVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateIceCandidateStreamRequestVariant2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (createIceCandidateStreamRequestVariant1 == null && createIceCandidateStreamRequestVariant2 == null)
            {
                try
                {
                    createIceCandidateStreamRequestVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.AnyOf<global::G.CreateIceCandidateStreamRequestVariant1Variant1, object>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    createIceCandidateStreamRequestVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateIceCandidateStreamRequestVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.CreateIceCandidateStreamRequest(
                createIceCandidateStreamRequestVariant1,

                createIceCandidateStreamRequestVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateIceCandidateStreamRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsCreateIceCandidateStreamRequestVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateIceCandidateStreamRequestVariant1, typeof(global::G.AnyOf<global::G.CreateIceCandidateStreamRequestVariant1Variant1, object>), options);
            }
            else if (value.IsCreateIceCandidateStreamRequestVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateIceCandidateStreamRequestVariant2, typeof(global::G.CreateIceCandidateStreamRequestVariant2), options);
            }
        }
    }
}