//HintName: G.JsonConverters.InputsOneOf1ItemsOneOf5Content.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class InputsOneOf1ItemsOneOf5ContentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.InputsOneOf1ItemsOneOf5Content>
    {
        /// <inheritdoc />
        public override global::G.InputsOneOf1ItemsOneOf5Content Read(
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
            var __score2 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::System.Collections.Generic.IList<global::G.InputsOneOf1ItemsOneOf5ContentOneOf0Items>? inputsOneOf1ItemsOneOf5Content0 = default;
            string? inputsOneOf1ItemsOneOf5ContentVariant2 = default;
            object? inputsOneOf1ItemsOneOf5ContentVariant3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        inputsOneOf1ItemsOneOf5Content0 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.InputsOneOf1ItemsOneOf5ContentOneOf0Items>>(__rawJson, options);
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

                        inputsOneOf1ItemsOneOf5ContentVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
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

                        inputsOneOf1ItemsOneOf5ContentVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (inputsOneOf1ItemsOneOf5Content0 == null && inputsOneOf1ItemsOneOf5ContentVariant2 == null && inputsOneOf1ItemsOneOf5ContentVariant3 == null)
            {
                try
                {

                    inputsOneOf1ItemsOneOf5Content0 = global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.InputsOneOf1ItemsOneOf5ContentOneOf0Items>>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    inputsOneOf1ItemsOneOf5ContentVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<string>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {

                    inputsOneOf1ItemsOneOf5ContentVariant3 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.InputsOneOf1ItemsOneOf5Content(
                inputsOneOf1ItemsOneOf5Content0,

                inputsOneOf1ItemsOneOf5ContentVariant2,

                inputsOneOf1ItemsOneOf5ContentVariant3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.InputsOneOf1ItemsOneOf5Content value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsInputsOneOf1ItemsOneOf5Content0)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputsOneOf1ItemsOneOf5Content0, typeof(global::System.Collections.Generic.IList<global::G.InputsOneOf1ItemsOneOf5ContentOneOf0Items>), options);
            }
            else if (value.IsInputsOneOf1ItemsOneOf5ContentVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputsOneOf1ItemsOneOf5ContentVariant2, typeof(string), options);
            }
            else if (value.IsInputsOneOf1ItemsOneOf5ContentVariant3)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InputsOneOf1ItemsOneOf5ContentVariant3, typeof(object), options);
            }
        }
    }
}