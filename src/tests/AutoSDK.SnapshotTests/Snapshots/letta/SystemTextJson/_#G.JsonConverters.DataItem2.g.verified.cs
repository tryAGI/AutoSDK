//HintName: G.JsonConverters.DataItem2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class DataItem2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.DataItem2>
    {
        /// <inheritdoc />
        public override global::G.DataItem2 Read(
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
            if (__jsonProps.Contains("access")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }

            global::G.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1? agent = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        agent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (agent == null)
            {
                try
                {
                    agent = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.DataItem2(
                agent
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.DataItem2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsAgent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Agent, typeof(global::G.ClientSideAccessTokensListClientSideAccessTokensResponseTokenPolicyDataItemVariant1), options);
            }
        }
    }
}