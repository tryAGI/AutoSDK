//HintName: G.JsonConverters.BaseInputsOneOf1ItemsOneOf2Output.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class BaseInputsOneOf1ItemsOneOf2OutputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BaseInputsOneOf1ItemsOneOf2Output>
    {
        /// <inheritdoc />
        public override global::G.BaseInputsOneOf1ItemsOneOf2Output Read(
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
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            string? baseInputsOneOf1ItemsOneOf2OutputVariant1 = default;
            global::System.Collections.Generic.IList<global::G.BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items>? baseInputsOneOf1ItemsOneOf2Output1 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        baseInputsOneOf1ItemsOneOf2OutputVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
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

                        baseInputsOneOf1ItemsOneOf2Output1 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items>>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (baseInputsOneOf1ItemsOneOf2OutputVariant1 == null && baseInputsOneOf1ItemsOneOf2Output1 == null)
            {
                try
                {

                    baseInputsOneOf1ItemsOneOf2OutputVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    baseInputsOneOf1ItemsOneOf2Output1 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.BaseInputsOneOf1ItemsOneOf2Output(
                baseInputsOneOf1ItemsOneOf2OutputVariant1,

                baseInputsOneOf1ItemsOneOf2Output1
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BaseInputsOneOf1ItemsOneOf2Output value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsBaseInputsOneOf1ItemsOneOf2OutputVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseInputsOneOf1ItemsOneOf2OutputVariant1, typeof(string), options);
            }
            else if (value.IsBaseInputsOneOf1ItemsOneOf2Output1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseInputsOneOf1ItemsOneOf2Output1, typeof(global::System.Collections.Generic.IList<global::G.BaseInputsOneOf1ItemsOneOf2OutputOneOf1Items>), options);
            }
        }
    }
}